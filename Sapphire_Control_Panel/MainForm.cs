﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapphire_Control_Panel
{
    public partial class MainForm : Form
    {
        private bool _isConnected;
        private bool _isLSimple;

        private string _openFilePath;
        private string _cacheFilePath;

        private List<byte[]> buffers = new List<byte[]>();

        private readonly byte[] _correctionData = new byte[]{0x7F};

        public MainForm()
        {
            InitializeComponent();
        }

        //シリアルポート一覧を取得
        private string[] GetComPorts()
        {
            try
            {
                var ret = SerialPort.GetPortNames();
                AddLogMessage("シリアルポート一覧を取得　総数：" + ret.Length);
                return ret;

            }
            catch(Exception e)
            {
                AddLogMessage(e.ToString());
                return null;
            }
        }

        //シリアルポート一覧を更新
        private void UpdateComPortsList()
        {
            var list = GetComPorts();

            portList.Items.Clear();

            foreach (var item in list)
            {
                portList.Items.Add(item);
            }

            if (portList.Items.Count > 0)
            {
                portList.SelectedIndex = 0;
            }
        }

        //ログにメッセージを追加
        private void AddLogMessage(string msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(this.AddLogMessage),msg);
                return;
            }

            DateTime dt = DateTime.Now;
            logBox.AppendText("[" + dt.ToString("HH:mm:ss") + "]" + msg + "\r\n");
        }

        //1バイト書き込み
        private bool WriteSingle(byte data)
        {
            try
            {
                byte[] send = new byte[] {data};

                port.Write(send,0,1);

                return true;
            }
            catch(Exception e)
            {
                AddLogMessage(e.ToString());
                return false;
            }
        }

        //バースト書き込み
        private bool WriteBurst(byte[] data, int length, int offset = 0)
        {
            try
            {
                port.Write(data,offset,length);

                return true;
            }
            catch (Exception e)
            {
                AddLogMessage(e.ToString());
                return false;
            }
        }

        //インジケータの一括変更
        private void SetIndicator(bool isConnected)
        {
            if (isConnected)
            {
                connectIndicator.BackColor = Color.Green;
                disconnectIndicator.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
            else
            {
                connectIndicator.BackColor = Color.FromKnownColor(KnownColor.Control);
                disconnectIndicator.BackColor = Color.Crimson;
            }
            connectIndicator.Checked = isConnected;
            disconnectIndicator.Checked = !isConnected;

            connectIndicator.UseVisualStyleBackColor = true;
            disconnectIndicator.UseVisualStyleBackColor = true;
        }

        
        //COMポートをオープン
        private bool OpenPort(string portName,int baud)
        {
            AddLogMessage("COMポートをオープン　対象ポート：" + portName);
            try
            {
                this.port.BaudRate = baud;
                this.port.Parity = Parity.None;
                this.port.DataBits = 8;
                this.port.StopBits = StopBits.One;
                this.port.Handshake = Handshake.None;
                this.port.PortName = portName;
                this.port.Open();

                return true;
            }
            catch (Exception e)
            {
                AddLogMessage(e.ToString());

                return false;
            }
        }

        //COMポートをクローズ
        private bool ClosePort()
        {
            AddLogMessage("COMポートをクローズ");
            try
            {
                this.port.Dispose();
                this.port.Close();
                return true;
            }
            catch (Exception e)
            {
                AddLogMessage(e.ToString());
                return false;
            }
        }

        /* ステータスを更新
         * status
         * 0:IDLE
         * 1:GENERATING
         * 2:SHOWING
         * -1:ERROR
         */
        private void SetStatus(int status)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<int>(this.SetStatus), status);
                return;
            }
            switch (status)
            {
                case 0:
                    //IDLE
                    statusBox.Text = "IDLE";
                    statusBox.BackColor = Color.LightSalmon;
                    break;
                case 1:
                    //GENERATING
                    statusBox.Text = "GENERATING";
                    statusBox.BackColor = Color.LightSeaGreen;
                    break;
                case 2:
                    //SHOWING
                    statusBox.Text = "SHOWING";
                    statusBox.BackColor = Color.LightBlue;
                    break;
                case -1:
                    //ERROR
                    statusBox.Text = "ERROR";
                    statusBox.BackColor = Color.LightCoral;
                    break;
                default:
                    //undefined
                    return;
            }
        }

        //進捗を更新
        private void SetProgress(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<int>(this.SetProgress), value);
                return;
            }

            progress.Value = value;
        }

        private void ShowPreview(Bitmap bmp)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<Bitmap>(this.ShowPreview), bmp);
                return;
            }

            previewPic.Image = bmp;
        }

        private void SetTransferMethod(bool isLSimple)
        {
            if (isLSimple)
            {
                selectLSimple.BackColor = Color.Violet;
                selectLV2.BackColor = Color.FromKnownColor(KnownColor.Control);

                selectLV2.Checked = false;
            }
            else
            {
                selectLSimple.BackColor = Color.FromKnownColor(KnownColor.Control);
                selectLV2.BackColor = Color.Violet;

                selectLSimple.Checked = false;
            }

            selectLSimple.UseVisualStyleBackColor = true;
            selectLV2.UseVisualStyleBackColor = true;
            _isLSimple = isLSimple;
        }

        private string GetFilePath()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "静止画ファイル(.jpg/.png/.bmp)|*.jpg;*.png;*.bmp";
                ofd.FilterIndex = 1;
                ofd.Title = "開くファイルを選択してください";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return ofd.FileName;
                }

                return null;
            }
            catch (Exception e)
            {
                AddLogMessage(e.ToString());
                return null;
            }

        }

        private void RunFFmpeg(string arg)
        {
            var proc = new Process();
            proc.StartInfo.FileName = "ffmpeg.exe";
            proc.StartInfo.Arguments = arg;
            proc.StartInfo.CreateNoWindow =true;
            proc.StartInfo.UseShellExecute = false;
            proc.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //インジケータを初期化
            AddLogMessage("初期化開始");
            logBox.HideSelection = false;
            selectLV2.Checked = true;
            SetStatus(0);
            SetIndicator(false);
            UpdateComPortsList();
            AddLogMessage("初期化終了");
        }

        private void updatePortsListButton_Click(object sender, EventArgs e)
        {
            UpdateComPortsList();
        }

        private void baudrateCorrectionButton_Click(object sender, EventArgs e)
        {
            if (_isConnected)
            {
                AddLogMessage("ボーレート校正を開始　送信データ:0x" + _correctionData[0].ToString("X"));
                port.Write(_correctionData,0,1);
            }
            else
            {
                AddLogMessage("ボーレート校正できません　接続されていません");
            }
            
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            int.TryParse(baudrateBox.Text, out var baud);
            if (OpenPort(portList.SelectedItem.ToString(), baud))
            {
                AddLogMessage("COMポートのオープンに成功");
                _isConnected = true;
                SetIndicator(true);
            }
            
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            if (ClosePort())
            {
                AddLogMessage("COMポートのクローズに成功");
                _isConnected = false;
                SetIndicator(false);
            }
        }

        private void baudrateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void selectLSimple_CheckedChanged(object sender, EventArgs e)
        {
            SetTransferMethod(selectLSimple.Checked);
        }

        private void selectLV2_CheckedChanged(object sender, EventArgs e)
        {
            SetTransferMethod(!selectLV2.Checked);
        }

        private void refOpenFileButton_Click(object sender, EventArgs e)
        {
            string path = GetFilePath();
            AddLogMessage("ファイルを選択　選択したファイルのパス：" + path);
            openFilePath.Text = path;
            _openFilePath = path;
        }


        private void generateButton_Click(object sender, EventArgs e)
        {
            SetStatus(1);
            SetProgress(0);
            Bitmap bitmap;
            string ext = Path.GetExtension(_openFilePath);
            string path;
                //静止画
                if (resizeCheck.Checked)
                {
                    string arg = "";
                    arg = $"-i \"{_openFilePath}\" -vf \"scale=w=trunc(ih*dar/2)*2:h=trunc(ih/2)*2, setsar=1/1, scale=w=240:h=64:force_original_aspect_ratio=1, pad=w=240:h=64:x=(ow-iw)/2:y=(oh-ih)/2:color=#000000\" \"tmp{ext}\"";
                    //リサイズをする
                    if (File.Exists("tmp" + ext)) File.Delete("tmp" + ext);
                    RunFFmpeg(arg);
                    var entryLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
                    path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(entryLocation), "tmp" + ext);
                }
                else
                {
                    path = _openFilePath;
                }

                Task task = Task.Run(() => {
                    while (!File.Exists(path))
                    { }
                    bitmap = new Bitmap(path);

                    Bitmap newImg = new Bitmap(bitmap.Width, bitmap.Height,
                        PixelFormat.Format1bppIndexed);

                    //Bitmapをロックする
                    BitmapData bitmapData = newImg.LockBits(
                        new Rectangle(0, 0, newImg.Width, newImg.Height),
                        ImageLockMode.WriteOnly, newImg.PixelFormat);

                    //現在の行と次の行の誤差を記憶する配列
                    float[][] errors = new float[2][] {
                        new float[bitmapData.Width + 1],
                        new float[bitmapData.Width + 1]
                    };

                    //新しい画像のピクセルデータを作成する
                    byte[] pixels = new byte[bitmapData.Stride * bitmapData.Height];
                    for (int y = 0; y < bitmapData.Height; y++)
                    {
                        for (int x = 0; x < bitmapData.Width; x++)
                        {
                            //ピクセルの明るさに、誤差を加える
                            float err = bitmap.GetPixel(x, y).GetBrightness() + errors[0][x];
                            //明るさが0.5以上の時は白くする
                            if (0.5f <= err)
                            {   
                                //ピクセルデータの位置
                                int pos = (x >> 3) + bitmapData.Stride * y;
                                //白くする
                                pixels[pos] |= (byte)(0x80 >> (x & 0x7));
                                //誤差を計算（黒くした時の誤差はerr-0なので、そのまま）
                                err -= 1f;
                            }

                            //誤差を振り分ける
                            errors[0][x + 1] += err * 7f / 16f;
                            if (x > 0)
                            {
                                errors[1][x - 1] += err * 3f / 16f;
                            }
                            errors[1][x] += err * 5f / 16f;
                            errors[1][x + 1] += err * 1f / 16f;
                        }
                        //誤差を記憶した配列を入れ替える
                        errors[0] = errors[1];
                        errors[1] = new float[errors[0].Length];
                    }
                    //作成したピクセルデータをコピーする
                    IntPtr ptr = bitmapData.Scan0;
                    System.Runtime.InteropServices.Marshal.Copy(pixels, 0, ptr, pixels.Length);

                    //ロックを解除する
                    newImg.UnlockBits(bitmapData);

                    int width = bitmap.Width;
                    int height = bitmap.Height;
                    int bitPos = 0;
                    int bytePos = 0;
                    Color pixel;
                    int data = 0x00;
                    buffers.Add(new byte[30*64]);

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            pixel = newImg.GetPixel(x, y);

                            data <<= 1;

                            data |= (pixel.R != 0xFF) ? 1 : 0;
                            bitPos++;

                            if (bitPos == 8)
                            {
                                buffers[0][bytePos++] = (byte) data;
                                data = 0;
                                bitPos = 0;
                                
                            }
                        }
                    }
                    ShowPreview(newImg);
                    bitmap.Dispose();
                    SetStatus(0);
                    SetProgress(100);
                });

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            SetProgress(0);
            SetStatus(2);
            if (_isLSimple)
            {
                byte[] head = new byte[2] {0x55, 0xAA};
                WriteBurst(head, 2);
                WriteBurst(buffers[0], 30 * 64);
            }
            else
            {
                WriteSingle(0x80);
                byte[] sends = new byte[64 * 30 * 2];
                int ptr = 0;
                for (int i = 0; i < 30 * 64; i++)
                {
                    SetProgress((int)(((float)i / (30*64)) * 90));
                    byte tmp = buffers[0][i];
                    sends[ptr++] = (byte) (((tmp & 0xF0) >> 4) | 0x10);
                    sends[ptr++] = (byte) (tmp & 0x0F);
                }

                WriteBurst(sends, 30 * 64 * 2);
                SetProgress(100);
            }
            SetStatus(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteSingle(0xFF);
        }
    }
}