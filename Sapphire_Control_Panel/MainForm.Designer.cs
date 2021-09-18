
namespace Sapphire_Control_Panel
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.baudrateCorrectionButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.baudrateBox = new System.Windows.Forms.TextBox();
            this.updatePortsListButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portList = new System.Windows.Forms.ComboBox();
            this.disconnectIndicator = new System.Windows.Forms.RadioButton();
            this.connectIndicator = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.selectAllTransfer_pic = new System.Windows.Forms.RadioButton();
            this.selectShrinkedTransfer_pic = new System.Windows.Forms.RadioButton();
            this.resizePicture = new System.Windows.Forms.CheckBox();
            this.refOpenPicButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.openPicPath = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.generateMovDataButton = new System.Windows.Forms.Button();
            this.transferMovButton = new System.Windows.Forms.Button();
            this.genertatePicDataButton = new System.Windows.Forms.Button();
            this.transferPicButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.previewPic = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.yonBaikaku = new System.Windows.Forms.CheckBox();
            this.yokoBaikaku = new System.Windows.Forms.CheckBox();
            this.tateBaikaku = new System.Windows.Forms.CheckBox();
            this.xorCheck = new System.Windows.Forms.RadioButton();
            this.orCheck = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.overlayCheck = new System.Windows.Forms.CheckBox();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.delCheck = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.framerate = new System.Windows.Forms.TextBox();
            this.extendedCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectAllTransfer_mov = new System.Windows.Forms.RadioButton();
            this.selectShrinkedTransfer_mov = new System.Windows.Forms.RadioButton();
            this.refOpenMovButton = new System.Windows.Forms.Button();
            this.openMovPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPic)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.WriteBufferSize = 16;
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.baudrateCorrectionButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.baudrateBox);
            this.groupBox1.Controls.Add(this.updatePortsListButton);
            this.groupBox1.Controls.Add(this.disconnectButton);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.portList);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(203, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接続";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "bps";
            // 
            // baudrateCorrectionButton
            // 
            this.baudrateCorrectionButton.Location = new System.Drawing.Point(8, 350);
            this.baudrateCorrectionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.baudrateCorrectionButton.Name = "baudrateCorrectionButton";
            this.baudrateCorrectionButton.Size = new System.Drawing.Size(187, 101);
            this.baudrateCorrectionButton.TabIndex = 12;
            this.baudrateCorrectionButton.Text = "ボーレート校正";
            this.baudrateCorrectionButton.UseVisualStyleBackColor = true;
            this.baudrateCorrectionButton.Click += new System.EventHandler(this.baudrateCorrectionButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "ボーレート";
            // 
            // baudrateBox
            // 
            this.baudrateBox.Location = new System.Drawing.Point(11, 313);
            this.baudrateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.baudrateBox.Name = "baudrateBox";
            this.baudrateBox.Size = new System.Drawing.Size(145, 23);
            this.baudrateBox.TabIndex = 8;
            this.baudrateBox.Text = "300";
            this.baudrateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BaudrateCharacterCheck);
            // 
            // updatePortsListButton
            // 
            this.updatePortsListButton.Location = new System.Drawing.Point(11, 70);
            this.updatePortsListButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.updatePortsListButton.Name = "updatePortsListButton";
            this.updatePortsListButton.Size = new System.Drawing.Size(184, 71);
            this.updatePortsListButton.TabIndex = 7;
            this.updatePortsListButton.Text = "更新";
            this.updatePortsListButton.UseVisualStyleBackColor = true;
            this.updatePortsListButton.Click += new System.EventHandler(this.updatePortsListButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(11, 147);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(184, 65);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "切断";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(11, 218);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(184, 73);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "接続";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMポート";
            // 
            // portList
            // 
            this.portList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portList.FormattingEnabled = true;
            this.portList.Location = new System.Drawing.Point(11, 40);
            this.portList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(184, 24);
            this.portList.TabIndex = 0;
            // 
            // disconnectIndicator
            // 
            this.disconnectIndicator.AutoCheck = false;
            this.disconnectIndicator.AutoSize = true;
            this.disconnectIndicator.Location = new System.Drawing.Point(272, 97);
            this.disconnectIndicator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.disconnectIndicator.Name = "disconnectIndicator";
            this.disconnectIndicator.Size = new System.Drawing.Size(58, 20);
            this.disconnectIndicator.TabIndex = 6;
            this.disconnectIndicator.TabStop = true;
            this.disconnectIndicator.Text = "切断";
            this.disconnectIndicator.UseVisualStyleBackColor = true;
            // 
            // connectIndicator
            // 
            this.connectIndicator.AutoCheck = false;
            this.connectIndicator.AutoSize = true;
            this.connectIndicator.BackColor = System.Drawing.SystemColors.Control;
            this.connectIndicator.Location = new System.Drawing.Point(151, 97);
            this.connectIndicator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connectIndicator.Name = "connectIndicator";
            this.connectIndicator.Size = new System.Drawing.Size(58, 20);
            this.connectIndicator.TabIndex = 5;
            this.connectIndicator.TabStop = true;
            this.connectIndicator.Text = "接続";
            this.connectIndicator.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(724, 178);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(523, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "制御";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Meiryo UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(8, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(507, 263);
            this.button1.TabIndex = 0;
            this.button1.Text = "PANIC!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SoftwareReset);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.logBox);
            this.groupBox3.Location = new System.Drawing.Point(13, 709);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1234, 260);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ログ";
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("PC-9800", 12F);
            this.logBox.Location = new System.Drawing.Point(8, 22);
            this.logBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(1218, 232);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.selectAllTransfer_pic);
            this.groupBox4.Controls.Add(this.selectShrinkedTransfer_pic);
            this.groupBox4.Controls.Add(this.resizePicture);
            this.groupBox4.Controls.Add(this.refOpenPicButton);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.openPicPath);
            this.groupBox4.Location = new System.Drawing.Point(224, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(442, 160);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "静止画";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "転送方式";
            // 
            // selectAllTransfer_pic
            // 
            this.selectAllTransfer_pic.AutoSize = true;
            this.selectAllTransfer_pic.Location = new System.Drawing.Point(197, 126);
            this.selectAllTransfer_pic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectAllTransfer_pic.Name = "selectAllTransfer_pic";
            this.selectAllTransfer_pic.Size = new System.Drawing.Size(74, 20);
            this.selectAllTransfer_pic.TabIndex = 27;
            this.selectAllTransfer_pic.TabStop = true;
            this.selectAllTransfer_pic.Text = "全転送";
            this.selectAllTransfer_pic.UseVisualStyleBackColor = true;
            this.selectAllTransfer_pic.CheckedChanged += new System.EventHandler(this.CheckedAllPictureTransfer);
            // 
            // selectShrinkedTransfer_pic
            // 
            this.selectShrinkedTransfer_pic.AutoSize = true;
            this.selectShrinkedTransfer_pic.Location = new System.Drawing.Point(8, 126);
            this.selectShrinkedTransfer_pic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectShrinkedTransfer_pic.Name = "selectShrinkedTransfer_pic";
            this.selectShrinkedTransfer_pic.Size = new System.Drawing.Size(90, 20);
            this.selectShrinkedTransfer_pic.TabIndex = 26;
            this.selectShrinkedTransfer_pic.TabStop = true;
            this.selectShrinkedTransfer_pic.Text = "短縮転送";
            this.selectShrinkedTransfer_pic.UseVisualStyleBackColor = true;
            this.selectShrinkedTransfer_pic.CheckedChanged += new System.EventHandler(this.CheckedShrinkedPictureTransfer);
            // 
            // resizePicture
            // 
            this.resizePicture.AutoSize = true;
            this.resizePicture.Location = new System.Drawing.Point(8, 72);
            this.resizePicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resizePicture.Name = "resizePicture";
            this.resizePicture.Size = new System.Drawing.Size(91, 20);
            this.resizePicture.TabIndex = 15;
            this.resizePicture.Text = "リサイズ";
            this.resizePicture.UseVisualStyleBackColor = true;
            // 
            // refOpenPicButton
            // 
            this.refOpenPicButton.Location = new System.Drawing.Point(318, 72);
            this.refOpenPicButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refOpenPicButton.Name = "refOpenPicButton";
            this.refOpenPicButton.Size = new System.Drawing.Size(75, 24);
            this.refOpenPicButton.TabIndex = 14;
            this.refOpenPicButton.Text = "参照";
            this.refOpenPicButton.UseVisualStyleBackColor = true;
            this.refOpenPicButton.Click += new System.EventHandler(this.OpenPicture);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "表示対象のファイル(静止画)";
            // 
            // openPicPath
            // 
            this.openPicPath.Location = new System.Drawing.Point(8, 40);
            this.openPicPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openPicPath.Name = "openPicPath";
            this.openPicPath.Size = new System.Drawing.Size(385, 23);
            this.openPicPath.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.generateMovDataButton);
            this.groupBox6.Controls.Add(this.transferMovButton);
            this.groupBox6.Controls.Add(this.genertatePicDataButton);
            this.groupBox6.Controls.Add(this.transferPicButton);
            this.groupBox6.Location = new System.Drawing.Point(773, 476);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(474, 227);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "操作";
            // 
            // generateMovDataButton
            // 
            this.generateMovDataButton.Location = new System.Drawing.Point(235, 22);
            this.generateMovDataButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generateMovDataButton.Name = "generateMovDataButton";
            this.generateMovDataButton.Size = new System.Drawing.Size(231, 96);
            this.generateMovDataButton.TabIndex = 15;
            this.generateMovDataButton.Text = "動画\r\nデータ生成";
            this.generateMovDataButton.UseVisualStyleBackColor = true;
            this.generateMovDataButton.Click += new System.EventHandler(this.GenerateMovieData);
            // 
            // transferMovButton
            // 
            this.transferMovButton.Font = new System.Drawing.Font("PC-9800", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.transferMovButton.Location = new System.Drawing.Point(235, 124);
            this.transferMovButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.transferMovButton.Name = "transferMovButton";
            this.transferMovButton.Size = new System.Drawing.Size(231, 90);
            this.transferMovButton.TabIndex = 14;
            this.transferMovButton.Text = "動画転送";
            this.transferMovButton.UseVisualStyleBackColor = true;
            this.transferMovButton.Click += new System.EventHandler(this.TransferMovie);
            // 
            // genertatePicDataButton
            // 
            this.genertatePicDataButton.Location = new System.Drawing.Point(8, 22);
            this.genertatePicDataButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.genertatePicDataButton.Name = "genertatePicDataButton";
            this.genertatePicDataButton.Size = new System.Drawing.Size(219, 96);
            this.genertatePicDataButton.TabIndex = 13;
            this.genertatePicDataButton.Text = "静止画\r\nデータ生成";
            this.genertatePicDataButton.UseVisualStyleBackColor = true;
            this.genertatePicDataButton.Click += new System.EventHandler(this.GeneratePictureData);
            // 
            // transferPicButton
            // 
            this.transferPicButton.Font = new System.Drawing.Font("PC-9800", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.transferPicButton.Location = new System.Drawing.Point(8, 124);
            this.transferPicButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.transferPicButton.Name = "transferPicButton";
            this.transferPicButton.Size = new System.Drawing.Size(219, 90);
            this.transferPicButton.TabIndex = 10;
            this.transferPicButton.Text = "静止画転送";
            this.transferPicButton.UseVisualStyleBackColor = true;
            this.transferPicButton.Click += new System.EventHandler(this.TransferPicture);
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(96, 19);
            this.statusBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(389, 23);
            this.statusBox.TabIndex = 13;
            this.statusBox.Text = "IDLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "ステータス";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "進捗";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(96, 48);
            this.progress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(389, 30);
            this.progress.TabIndex = 11;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.previewPic);
            this.groupBox7.Location = new System.Drawing.Point(13, 476);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(752, 227);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "プレビュー";
            // 
            // previewPic
            // 
            this.previewPic.Location = new System.Drawing.Point(10, 22);
            this.previewPic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previewPic.Name = "previewPic";
            this.previewPic.Size = new System.Drawing.Size(720, 192);
            this.previewPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewPic.TabIndex = 0;
            this.previewPic.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.statusBox);
            this.groupBox5.Controls.Add(this.progress);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.disconnectIndicator);
            this.groupBox5.Controls.Add(this.connectIndicator);
            this.groupBox5.Location = new System.Drawing.Point(224, 346);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(493, 124);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "状態";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "COMポート";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.yonBaikaku);
            this.groupBox8.Controls.Add(this.yokoBaikaku);
            this.groupBox8.Controls.Add(this.tateBaikaku);
            this.groupBox8.Controls.Add(this.xorCheck);
            this.groupBox8.Controls.Add(this.orCheck);
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.overlayCheck);
            this.groupBox8.Controls.Add(this.inputText);
            this.groupBox8.Location = new System.Drawing.Point(223, 178);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(493, 162);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "テキスト領域";
            // 
            // yonBaikaku
            // 
            this.yonBaikaku.AutoSize = true;
            this.yonBaikaku.Location = new System.Drawing.Point(356, 110);
            this.yonBaikaku.Name = "yonBaikaku";
            this.yonBaikaku.Size = new System.Drawing.Size(67, 20);
            this.yonBaikaku.TabIndex = 8;
            this.yonBaikaku.Text = "4倍角";
            this.yonBaikaku.UseVisualStyleBackColor = true;
            // 
            // yokoBaikaku
            // 
            this.yokoBaikaku.AutoSize = true;
            this.yokoBaikaku.Location = new System.Drawing.Point(356, 86);
            this.yokoBaikaku.Name = "yokoBaikaku";
            this.yokoBaikaku.Size = new System.Drawing.Size(75, 20);
            this.yokoBaikaku.TabIndex = 7;
            this.yokoBaikaku.Text = "横倍角";
            this.yokoBaikaku.UseVisualStyleBackColor = true;
            // 
            // tateBaikaku
            // 
            this.tateBaikaku.AutoSize = true;
            this.tateBaikaku.Location = new System.Drawing.Point(356, 61);
            this.tateBaikaku.Name = "tateBaikaku";
            this.tateBaikaku.Size = new System.Drawing.Size(75, 20);
            this.tateBaikaku.TabIndex = 6;
            this.tateBaikaku.Text = "縦倍角";
            this.tateBaikaku.UseVisualStyleBackColor = true;
            // 
            // xorCheck
            // 
            this.xorCheck.AutoSize = true;
            this.xorCheck.Location = new System.Drawing.Point(425, 39);
            this.xorCheck.Name = "xorCheck";
            this.xorCheck.Size = new System.Drawing.Size(50, 20);
            this.xorCheck.TabIndex = 5;
            this.xorCheck.TabStop = true;
            this.xorCheck.Text = "XOR";
            this.xorCheck.UseVisualStyleBackColor = true;
            this.xorCheck.CheckedChanged += new System.EventHandler(this.xorCheck_CheckedChanged);
            // 
            // orCheck
            // 
            this.orCheck.AutoSize = true;
            this.orCheck.Location = new System.Drawing.Point(356, 42);
            this.orCheck.Name = "orCheck";
            this.orCheck.Size = new System.Drawing.Size(42, 20);
            this.orCheck.TabIndex = 4;
            this.orCheck.TabStop = true;
            this.orCheck.Text = "OR";
            this.orCheck.UseVisualStyleBackColor = true;
            this.orCheck.CheckedChanged += new System.EventHandler(this.orCheck_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "文字転送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.TransferCharacter);
            // 
            // overlayCheck
            // 
            this.overlayCheck.AutoSize = true;
            this.overlayCheck.Location = new System.Drawing.Point(356, 22);
            this.overlayCheck.Name = "overlayCheck";
            this.overlayCheck.Size = new System.Drawing.Size(123, 20);
            this.overlayCheck.TabIndex = 2;
            this.overlayCheck.Text = "オーバーレイ";
            this.overlayCheck.UseVisualStyleBackColor = true;
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("PC-9800", 8F);
            this.inputText.Location = new System.Drawing.Point(12, 22);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(334, 128);
            this.inputText.TabIndex = 0;
            this.inputText.Text = "";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.delCheck);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.framerate);
            this.groupBox9.Controls.Add(this.extendedCheck);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.selectAllTransfer_mov);
            this.groupBox9.Controls.Add(this.selectShrinkedTransfer_mov);
            this.groupBox9.Controls.Add(this.refOpenMovButton);
            this.groupBox9.Controls.Add(this.openMovPath);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Location = new System.Drawing.Point(673, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(574, 160);
            this.groupBox9.TabIndex = 33;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "動画";
            // 
            // delCheck
            // 
            this.delCheck.AutoSize = true;
            this.delCheck.Location = new System.Drawing.Point(202, 72);
            this.delCheck.Name = "delCheck";
            this.delCheck.Size = new System.Drawing.Size(59, 20);
            this.delCheck.TabIndex = 39;
            this.delCheck.Text = "削除";
            this.delCheck.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(414, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "フレームレート";
            // 
            // framerate
            // 
            this.framerate.Location = new System.Drawing.Point(417, 125);
            this.framerate.Name = "framerate";
            this.framerate.Size = new System.Drawing.Size(123, 23);
            this.framerate.TabIndex = 37;
            this.framerate.Text = "30.00";
            // 
            // extendedCheck
            // 
            this.extendedCheck.AutoSize = true;
            this.extendedCheck.Location = new System.Drawing.Point(12, 72);
            this.extendedCheck.Name = "extendedCheck";
            this.extendedCheck.Size = new System.Drawing.Size(107, 20);
            this.extendedCheck.TabIndex = 36;
            this.extendedCheck.Text = "詳細モード";
            this.extendedCheck.UseVisualStyleBackColor = true;
            this.extendedCheck.CheckedChanged += new System.EventHandler(this.extendedCheck_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "転送方式";
            // 
            // selectAllTransfer_mov
            // 
            this.selectAllTransfer_mov.AutoSize = true;
            this.selectAllTransfer_mov.Location = new System.Drawing.Point(202, 126);
            this.selectAllTransfer_mov.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectAllTransfer_mov.Name = "selectAllTransfer_mov";
            this.selectAllTransfer_mov.Size = new System.Drawing.Size(74, 20);
            this.selectAllTransfer_mov.TabIndex = 34;
            this.selectAllTransfer_mov.TabStop = true;
            this.selectAllTransfer_mov.Text = "全転送";
            this.selectAllTransfer_mov.UseVisualStyleBackColor = true;
            this.selectAllTransfer_mov.CheckedChanged += new System.EventHandler(this.selectAllTransfer_mov_CheckedChanged);
            // 
            // selectShrinkedTransfer_mov
            // 
            this.selectShrinkedTransfer_mov.AutoSize = true;
            this.selectShrinkedTransfer_mov.Location = new System.Drawing.Point(9, 126);
            this.selectShrinkedTransfer_mov.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectShrinkedTransfer_mov.Name = "selectShrinkedTransfer_mov";
            this.selectShrinkedTransfer_mov.Size = new System.Drawing.Size(90, 20);
            this.selectShrinkedTransfer_mov.TabIndex = 33;
            this.selectShrinkedTransfer_mov.TabStop = true;
            this.selectShrinkedTransfer_mov.Text = "短縮転送";
            this.selectShrinkedTransfer_mov.UseVisualStyleBackColor = true;
            this.selectShrinkedTransfer_mov.CheckedChanged += new System.EventHandler(this.selectShrinkedTransfer_mov_CheckedChanged);
            // 
            // refOpenMovButton
            // 
            this.refOpenMovButton.Location = new System.Drawing.Point(459, 69);
            this.refOpenMovButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refOpenMovButton.Name = "refOpenMovButton";
            this.refOpenMovButton.Size = new System.Drawing.Size(75, 24);
            this.refOpenMovButton.TabIndex = 31;
            this.refOpenMovButton.Text = "参照";
            this.refOpenMovButton.UseVisualStyleBackColor = true;
            this.refOpenMovButton.Click += new System.EventHandler(this.refOpenMovButton_Click);
            // 
            // openMovPath
            // 
            this.openMovPath.Location = new System.Drawing.Point(7, 40);
            this.openMovPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openMovPath.Name = "openMovPath";
            this.openMovPath.Size = new System.Drawing.Size(527, 23);
            this.openMovPath.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "表示対象のファイル(動画)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 981);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("PC-9800", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Sapphire Control Panel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewPic)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton disconnectIndicator;
        private System.Windows.Forms.RadioButton connectIndicator;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portList;
        private System.Windows.Forms.Button updatePortsListButton;
        private System.Windows.Forms.Button baudrateCorrectionButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox baudrateBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton selectAllTransfer_pic;
        private System.Windows.Forms.RadioButton selectShrinkedTransfer_pic;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button genertatePicDataButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button transferPicButton;
        private System.Windows.Forms.CheckBox resizePicture;
        private System.Windows.Forms.Button refOpenPicButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox openPicPath;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox previewPic;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox overlayCheck;
        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.RadioButton xorCheck;
        private System.Windows.Forms.RadioButton orCheck;
        private System.Windows.Forms.Button generateMovDataButton;
        private System.Windows.Forms.Button transferMovButton;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton selectAllTransfer_mov;
        private System.Windows.Forms.RadioButton selectShrinkedTransfer_mov;
        private System.Windows.Forms.Button refOpenMovButton;
        private System.Windows.Forms.TextBox openMovPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox yonBaikaku;
        private System.Windows.Forms.CheckBox yokoBaikaku;
        private System.Windows.Forms.CheckBox tateBaikaku;
        private System.Windows.Forms.CheckBox extendedCheck;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox framerate;
        private System.Windows.Forms.CheckBox delCheck;
    }
}

