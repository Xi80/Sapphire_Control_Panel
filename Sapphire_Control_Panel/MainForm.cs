using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapphire_Control_Panel
{
    public partial class MainForm : Form
    {
        private readonly byte[] _correctionData = {0x7F};
        private bool _isConnected;
        private bool _isShrinkedPictureTransfer;
        private bool _isShrinkedMovieTransfer;

        private string _openMovieFilePath;
        private string _openPictureFilePath;

        private readonly List<byte[]> buffers = new List<byte[]>();

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
            catch (Exception e)
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

            foreach (var item in list) portList.Items.Add(item);

            if (portList.Items.Count > 0) portList.SelectedIndex = 0;
        }

        //ログにメッセージを追加
        private void AddLogMessage(string msg)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddLogMessage), msg);
                return;
            }

            var dt = DateTime.Now;
            logBox.AppendText("[" + dt.ToString("HH:mm:ss") + "]" + msg + "\r\n");
        }

        //1バイト書き込み
        private bool WriteSingle(byte data)
        {
            try
            {
                byte[] send = {data};

                port.Write(send, 0, 1);

                return true;
            }
            catch (Exception e)
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
                port.Write(data, offset, length);

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
        private bool OpenPort(string portName, int baud)
        {
            AddLogMessage("COMポートをオープン　対象ポート：" + portName);
            try
            {
                port.BaudRate = baud;
                port.Parity = Parity.None;
                port.DataBits = 8;
                port.StopBits = StopBits.One;
                port.Handshake = Handshake.None;
                port.PortName = portName;
                port.Open();

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
                port.Dispose();
                port.Close();
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
            if (InvokeRequired)
            {
                Invoke(new Action<int>(SetStatus), status);
                return;
            }

            switch (status)
            {
                case 0:
                    //IDLE
                    statusBox.Text = @"IDLE";
                    statusBox.BackColor = Color.LightSalmon;
                    break;
                case 1:
                    //GENERATING
                    statusBox.Text = @"GENERATING";
                    statusBox.BackColor = Color.LightSeaGreen;
                    break;
                case 2:
                    //SHOWING
                    statusBox.Text = @"SHOWING";
                    statusBox.BackColor = Color.LightBlue;
                    break;
                case -1:
                    //ERROR
                    statusBox.Text = @"ERROR";
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
            if (InvokeRequired)
            {
                Invoke(new Action<int>(SetProgress), value);
                return;
            }

            progress.Value = value;
        }

        private void ShowPreview(Bitmap bmp)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Bitmap>(ShowPreview), bmp);
                return;
            }

            previewPic.Image = bmp;
        }

        private void SetTransferMethod(bool isPicture, bool isShrinkedTransfer)
        {
            if (isPicture)
            {
                if (isShrinkedTransfer)
                {
                    selectShrinkedTransfer_pic.BackColor = Color.Violet;
                    selectAllTransfer_pic.BackColor = Color.FromKnownColor(KnownColor.Control);

                    selectAllTransfer_pic.Checked = false;
                }
                else
                {
                    selectShrinkedTransfer_pic.BackColor = Color.FromKnownColor(KnownColor.Control);
                    selectAllTransfer_pic.BackColor = Color.Violet;

                    selectShrinkedTransfer_pic.Checked = false;
                }

                _isShrinkedPictureTransfer = isShrinkedTransfer;
            }
            else
            {
                if (isShrinkedTransfer)
                {
                    selectShrinkedTransfer_mov.BackColor = Color.Violet;
                    selectAllTransfer_mov.BackColor = Color.FromKnownColor(KnownColor.Control);

                    selectAllTransfer_mov.Checked = false;
                }
                else
                {
                    selectShrinkedTransfer_mov.BackColor = Color.FromKnownColor(KnownColor.Control);
                    selectAllTransfer_mov.BackColor = Color.Violet;

                    selectShrinkedTransfer_mov.Checked = false;
                }

                _isShrinkedMovieTransfer = isShrinkedTransfer;
            }

            selectShrinkedTransfer_mov.UseVisualStyleBackColor = true;
            selectAllTransfer_mov.UseVisualStyleBackColor = true;
            selectShrinkedTransfer_pic.UseVisualStyleBackColor = true;
            selectAllTransfer_pic.UseVisualStyleBackColor = true;
        }

        private string GetFilePath(bool isPicture)
        {
            try
            {
                var ofd = new OpenFileDialog();
                ofd.Filter = isPicture ? @"静止画ファイル(.jpg/.png/.bmp)|*.jpg;*.png;*.bmp" : @"動画ファイル(.mp4)|*.mp4";

                ofd.FilterIndex = 1;
                ofd.Title = @"開くファイルを選択してください";
                return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
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
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.Start();
            proc.WaitForExit();
        }

        private static byte RetKanaCode(char c)
        {
            switch (c)
            {
                case '｡':
                    return 0xA1;
                case '「':
                    return 0xA2;
                case '」':
                    return 0xA3;
                case '、':
                    return 0xA4;
                case '・':
                    return 0xA5;
                case 'ｦ':
                    return 0xA6;
                case 'ｧ':
                    return 0xA7;
                case 'ｨ':
                    return 0xA8;
                case 'ｩ':
                    return 0xA9;
                case 'ｪ':
                    return 0xAA;
                case 'ｫ':
                    return 0xAB;
                case 'ｬ':
                    return 0xAC;
                case 'ｭ':
                    return 0xAD;
                case 'ｮ':
                    return 0xAE;
                case 'ｯ':
                    return 0xAF;
                case 'ｰ':
                    return 0xB0;
                case 'ｱ':
                    return 0xB1;
                case 'ｲ':
                    return 0xB2;
                case 'ｳ':
                    return 0xB3;
                case 'ｴ':
                    return 0xB4;
                case 'ｵ':
                    return 0xB5;
                case 'ｶ':
                    return 0xB6;
                case 'ｷ':
                    return 0xB7;
                case 'ｸ':
                    return 0xB8;
                case 'ｹ':
                    return 0xB9;
                case 'ｺ':
                    return 0xBA;
                case 'ｻ':
                    return 0xBB;
                case 'ｼ':
                    return 0xBC;
                case 'ｽ':
                    return 0xBD;
                case 'ｾ':
                    return 0xBE;
                case 'ｿ':
                    return 0xBF;
                case 'ﾀ':
                    return 0xC0;
                case 'ﾁ':
                    return 0xC1;
                case 'ﾂ':
                    return 0xC2;
                case 'ﾃ':
                    return 0xC3;
                case 'ﾄ':
                    return 0xC4;
                case 'ﾅ':
                    return 0xC5;
                case 'ﾆ':
                    return 0xC6;
                case 'ﾇ':
                    return 0xC7;
                case 'ﾈ':
                    return 0xC8;
                case 'ﾉ':
                    return 0xC9;
                case 'ﾊ':
                    return 0xCA;
                case 'ﾋ':
                    return 0xCB;
                case 'ﾌ':
                    return 0xCC;
                case 'ﾍ':
                    return 0xCD;
                case 'ﾎ':
                    return 0xCE;
                case 'ﾏ':
                    return 0xCF;
                case 'ﾐ':
                    return 0xD0;
                case 'ﾑ':
                    return 0xD1;
                case 'ﾒ':
                    return 0xD2;
                case 'ﾓ':
                    return 0xD3;
                case 'ﾔ':
                    return 0xD4;
                case 'ﾕ':
                    return 0xD5;
                case 'ﾖ':
                    return 0xD6;
                case 'ﾗ':
                    return 0xD7;
                case 'ﾘ':
                    return 0xD8;
                case 'ﾙ':
                    return 0xD9;
                case 'ﾚ':
                    return 0xDA;
                case 'ﾛ':
                    return 0xDB;
                case 'ﾜ':
                    return 0xDC;
                case 'ﾝ':
                    return 0xDD;
                case 'ﾞ':
                    return 0xDE;
                case 'ﾟ':
                    return 0xDF;
                default:
                    return (byte) c;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //インジケータを初期化
            AddLogMessage("初期化開始");
            logBox.HideSelection = false;
            selectAllTransfer_pic.Checked = true;
            selectAllTransfer_mov.Checked = true;
            orCheck.Checked = true;
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
                port.Write(_correctionData, 0, 1);
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

        private void BaudrateCharacterCheck(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b') e.Handled = true;
        }

        private void CheckedShrinkedPictureTransfer(object sender, EventArgs e)
        {
            SetTransferMethod(true, selectShrinkedTransfer_pic.Checked);
        }

        private void CheckedAllPictureTransfer(object sender, EventArgs e)
        {
            SetTransferMethod(true, !selectAllTransfer_pic.Checked);
        }

        private void OpenPicture(object sender, EventArgs e)
        {
            var path = GetFilePath(true);
            AddLogMessage("ファイルを選択　選択したファイルのパス：" + path);
            openPicPath.Text = path;
            _openPictureFilePath = path;
        }


        private void GeneratePictureData(object sender, EventArgs e)
        {
            SetStatus(1);
            SetProgress(0);
            Bitmap bitmap;
            var ext = Path.GetExtension(_openPictureFilePath);
            string path;
            if (resizePicture.Checked)
            {
                var arg = "";
                arg =
                    $"-i \"{_openPictureFilePath}\" -vf \"scale=w=trunc(ih*dar/2)*2:h=trunc(ih/2)*2, setsar=1/1, scale=w=240:h=64:force_original_aspect_ratio=1, pad=w=240:h=64:x=(ow-iw)/2:y=(oh-ih)/2:color=#000000\" \"tmp{ext}\"";
                if (File.Exists("tmp" + ext)) File.Delete("tmp" + ext);
                RunFFmpeg(arg);
                var entryLocation = Assembly.GetEntryAssembly()?.Location;
                path = Path.Combine(Path.GetDirectoryName(entryLocation) ?? string.Empty, "tmp" + ext);
            }
            else
            {
                path = _openPictureFilePath;
            }

            Thread thread = new Thread(new ThreadStart(() =>
            {
                while (!File.Exists(path))
                {
                }

                bitmap = new Bitmap(path);
                var newImg = new Bitmap(bitmap.Width, bitmap.Height,
                    PixelFormat.Format1bppIndexed);
                var bitmapData = newImg.LockBits(
                    new Rectangle(0, 0, newImg.Width, newImg.Height),
                    ImageLockMode.WriteOnly, newImg.PixelFormat);
                var errors = new float[2][]
                {
                    new float[bitmapData.Width + 1],
                    new float[bitmapData.Width + 1]
                };
                var pixels = new byte[bitmapData.Stride * bitmapData.Height];
                for (var y = 0; y < bitmapData.Height; y++)
                {
                    for (var x = 0; x < bitmapData.Width; x++)
                    {
                        var err = bitmap.GetPixel(x, y).GetBrightness() + errors[0][x];
                        if (0.5f <= err)
                        {
                            var pos = (x >> 3) + bitmapData.Stride * y;
                            pixels[pos] |= (byte)(0x80 >> (x & 0x7));
                            err -= 1f;
                        }

                        errors[0][x + 1] += err * 7f / 16f;
                        if (x > 0) errors[1][x - 1] += err * 3f / 16f;
                        errors[1][x] += err * 5f / 16f;
                        errors[1][x + 1] += err * 1f / 16f;
                    }

                    errors[0] = errors[1];
                    errors[1] = new float[errors[0].Length];
                }

                var ptr = bitmapData.Scan0;
                Marshal.Copy(pixels, 0, ptr, pixels.Length);
                newImg.UnlockBits(bitmapData);

                var width = bitmap.Width;
                var height = bitmap.Height;
                var bitPos = 0;
                var bytePos = 0;
                Color pixel;
                var data = 0x00;
                buffers.Clear();
                buffers.Add(new byte[30 * 64]);

                for (var y = 0; y < height; y++)
                    for (var x = 0; x < width; x++)
                    {
                        pixel = newImg.GetPixel(x, y);
                        data <<= 1;
                        data |= pixel.R != 0xFF ? 1 : 0;
                        bitPos++;
                        if (bitPos != 8) continue;
                        buffers[0][bytePos++] = (byte)data;
                        data = 0;
                        bitPos = 0;
                    }

                ShowPreview(newImg);
                bitmap.Dispose();
                SetStatus(0);
                SetProgress(100);
            }));

            thread.Start();
        }

        private void SoftwareReset(object sender, EventArgs e)
        {
            WriteSingle(0xFF);
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            AddLogMessage("PORT:" + port.ReadLine() + "\r\n");
        }

        private void TransferPicture(object sender, EventArgs e)
        {
            SetProgress(0);
            SetStatus(2);
            if (_isShrinkedPictureTransfer)
            {
                var head = new byte[2] {0x55, 0xAA};
                WriteBurst(head, 2);
                WriteBurst(buffers[0], 30 * 64);
            }
            else
            {
                WriteSingle(0x80);

                var sends = new byte[64 * 30 * 2];
                var ptr = 0;
                for (var i = 0; i < 30 * 64; i++)
                {
                    SetProgress((int) ((float) i / (30 * 64) * 90));
                    var tmp = buffers[0][i];
                    sends[ptr++] = (byte) (((tmp & 0xF0) >> 4) | 0x10);
                    sends[ptr++] = (byte) (tmp & 0x0F);
                }

                WriteBurst(sends, 30 * 64 * 2);

                WriteSingle(0x86);
                SetProgress(100);
            }

            SetStatus(0);
        }

        private void TransferMovie(object sender, EventArgs e)
        {
            SetProgress(0);
            SetStatus(2);
            if (_isShrinkedMovieTransfer)
            {
                var head = new byte[2] {0x55, 0xAA};
                WriteBurst(head, 2);
                WriteBurst(buffers[0], 30 * 64);
            }
            else
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    foreach (var b in buffers)
                    {
                        byte[] data = { 0x80, 0x84, 0x86 };
                        port.Write(data, 0, 2);
                        port.Write(b, 0, b.Length);
                        port.Write(data, 2, 1);
                    }
                    SetStatus(0);
                }));
                thread.Start();
            }
        }

        private void TransferCharacter(object sender, EventArgs e)
        {
            var s1 = inputText.Text.Split(new[] {Environment.NewLine}, StringSplitOptions.None);
            WriteSingle(0x83);
            WriteSingle(0x80);
            WriteSingle(0x82);
            WriteSingle(64);
            var line = 65;
            foreach (var s in inputText.Lines)
            {
                foreach (var c in s)
                {
                    var d = RetKanaCode(c);
                    var upper = (byte) (0x10 | ((d & 0xF0) >> 4));
                    var lower = (byte) (d & 0x0F);

                    WriteSingle(upper);
                    WriteSingle(lower);
                }

                WriteSingle(0x82);
                WriteSingle((byte) line++);
                WriteSingle(0x81);
                WriteSingle(0);
            }

            if (!overlayCheck.Checked)
            {
                WriteSingle(0x85);
            }
            else
            {
                if (orCheck.Checked)
                    WriteSingle(0x87);
                else
                    WriteSingle(0x88);
            }
        }

        private void orCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!orCheck.Checked) return;
            xorCheck.Checked = false;
            orCheck.BackColor = Color.Aqua;
            xorCheck.BackColor = Color.FromKnownColor(KnownColor.Control);
            xorCheck.UseVisualStyleBackColor = true;
            orCheck.UseVisualStyleBackColor = true;
        }

        private void xorCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!xorCheck.Checked) return;
            orCheck.Checked = false;
            xorCheck.BackColor = Color.Aqua;
            orCheck.BackColor = Color.FromKnownColor(KnownColor.Control);

            xorCheck.UseVisualStyleBackColor = true;
            orCheck.UseVisualStyleBackColor = true;
        }

        private void GenerateMovieData(object sender, EventArgs e)
        {
            buffers.Clear();
            SetStatus(1);
            SetProgress(0);
            Bitmap bitmap;
            var ext = Path.GetExtension(_openMovieFilePath);
            float frms = float.Parse(framerate.Text);

            if (delCheck.Checked)
            {
                Directory.Delete(Path.GetFileNameWithoutExtension(_openMovieFilePath),true);
            }

            if (!Directory.Exists(Path.GetFileNameWithoutExtension(_openMovieFilePath)))
            {
                Directory.CreateDirectory(Path.GetFileNameWithoutExtension(_openMovieFilePath) ??
                                          throw new InvalidOperationException());

                var arg = "";

                if (!extendedCheck.Checked)
                {
                    arg = $"-i \"{_openMovieFilePath}\" -vf \"scale=w=trunc(ih*dar/2)*2:h=trunc(ih/2)*2, setsar=1/1, scale=w=240:h=64:force_original_aspect_ratio=1, pad=w=240:h=64:x=(ow-iw)/2:y=(oh-ih)/2:color=#000000\" -r {frms} -vcodec png \"{Path.GetFileNameWithoutExtension(_openMovieFilePath)}/image_%04d.png\"";

                }
                else
                {
                    arg = $"-i \"{_openMovieFilePath}\" -vf \"scale=w=trunc(ih*dar/2)*2:h=trunc(ih/2)*2, setsar=1/1, scale=w=240:h=64:force_original_aspect_ratio=1, pad=w=240:h=64:x=(ow-iw):y=(oh-ih):color=#000000\" -r {frms} -vcodec png \"{Path.GetFileNameWithoutExtension(_openMovieFilePath)}/image_%04d.png\"";

                }
                RunFFmpeg(arg);
            }

            int fileCount = Directory.GetFiles(Path.GetFileNameWithoutExtension(_openMovieFilePath), "*.png",
                SearchOption.TopDirectoryOnly).Length;
            AddLogMessage("フレーム分割&再生速度調整終了　総フレーム数:" + fileCount.ToString());
            Thread thread = new Thread(new ThreadStart(() =>
            {
                for (int i = 1; i <= fileCount; i++)
                {
                    if (File.Exists(Path.GetFileNameWithoutExtension(_openMovieFilePath) + "/image_" +
                                    i.ToString("D4") + ".dat"))
                    {
                        System.IO.FileStream fs = new System.IO.FileStream(
                            Path.GetFileNameWithoutExtension(_openMovieFilePath) + "/image_" + i.ToString("D4") +
                            ".dat",
                            System.IO.FileMode.Open,
                            System.IO.FileAccess.Read);
                        byte[] bs = new byte[fs.Length];
                        fs.Read(bs, 0, bs.Length);
                        fs.Close();
                        buffers.Add(bs);
                    }
                    else
                    {
                        bitmap = new Bitmap(Path.GetFileNameWithoutExtension(_openMovieFilePath) + "/image_" +
                                            i.ToString("D4") + ".png");


                        Graphics g = Graphics.FromImage(bitmap);
                        Font fnt = new Font("PC-9800", 11);
                        var span = new TimeSpan(0, 0, (int)(fileCount / frms));
                        var total = span.ToString(@"mm\:ss");
                        span = new TimeSpan(0, 0, (int)(i / frms));
                        var current = span.ToString(@"mm\:ss");
                        g.DrawString($"M:{Path.GetFileNameWithoutExtension(_openMovieFilePath)}", fnt, Brushes.White, 0, 0);
                        g.DrawString($"F:{i:D4}/{fileCount:D4}", fnt, Brushes.White, 0, 25);
                        g.DrawString($"T:{current}/{total}", fnt, Brushes.White, 0, 50);

                        fnt.Dispose();
                        g.Dispose();

                        var newImg = new Bitmap(bitmap.Width, bitmap.Height,
                            PixelFormat.Format1bppIndexed);
                        var bitmapData = newImg.LockBits(
                            new Rectangle(0, 0, newImg.Width, newImg.Height),
                            ImageLockMode.WriteOnly, newImg.PixelFormat);
                        var errors = new float[2][]
                        {
                            new float[bitmapData.Width + 1],
                            new float[bitmapData.Width + 1]
                        };
                        var pixels = new byte[bitmapData.Stride * bitmapData.Height];
                        for (var y = 0; y < bitmapData.Height; y++)
                        {
                            for (var x = 0; x < bitmapData.Width; x++)
                            {
                                var err = bitmap.GetPixel(x, y).GetBrightness() + errors[0][x];
                                if (0.5f <= err)
                                {
                                    var pos = (x >> 3) + bitmapData.Stride * y;
                                    pixels[pos] |= (byte) (0x80 >> (x & 0x7));
                                    err -= 1f;
                                }

                                errors[0][x + 1] += err * 7f / 16f;
                                if (x > 0) errors[1][x - 1] += err * 3f / 16f;
                                errors[1][x] += err * 5f / 16f;
                                errors[1][x + 1] += err * 1f / 16f;
                            }

                            errors[0] = errors[1];
                            errors[1] = new float[errors[0].Length];
                        }



                        var ptr = bitmapData.Scan0;
                        Marshal.Copy(pixels, 0, ptr, pixels.Length);
                        newImg.UnlockBits(bitmapData);


                        var width = bitmap.Width;
                        var height = bitmap.Height;
                        var bitPos = 0;
                        var bytePos = 0;
                        Color pixel;
                        var data = 0x00;

                        buffers.Add(new byte[60 * 64]);

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
                                    buffers[i - 1][bytePos++] = (byte) (((data & 0xF0) >> 4) | 0x10);
                                    buffers[i - 1][bytePos++] = (byte) ((data & 0x0F));
                                    data = 0;
                                    bitPos = 0;
                                }
                            }
                        }

                        ShowPreview(newImg);
                        bitmap.Dispose();
                        System.IO.FileStream fs = new System.IO.FileStream(
                            Path.GetFileNameWithoutExtension(_openMovieFilePath) + "/image_" + i.ToString("D4") +
                            ".dat",
                            System.IO.FileMode.Create,
                            System.IO.FileAccess.Write);
                        fs.Write(buffers[i - 1], 0, buffers[i - 1].Length);
                        fs.Close();
                    }

                    SetProgress((int) (((float) i / (float) fileCount) * 100));
                }
                SetStatus(0);
            }));

            thread.Start();
        }

        private void refOpenMovButton_Click(object sender, EventArgs e)
        {
            _openMovieFilePath = GetFilePath(false);
            openMovPath.Text = _openMovieFilePath;
        }

        private void selectAllTransfer_mov_CheckedChanged(object sender, EventArgs e)
        {
            SetTransferMethod(false, !selectAllTransfer_mov.Checked);
        }

        private void selectShrinkedTransfer_mov_CheckedChanged(object sender, EventArgs e)
        {
            SetTransferMethod(false, selectShrinkedTransfer_mov.Checked);
        }

        private void extendedCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}