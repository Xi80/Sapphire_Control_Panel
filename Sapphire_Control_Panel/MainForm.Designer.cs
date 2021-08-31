
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
            this.selectLV2 = new System.Windows.Forms.RadioButton();
            this.selectLSimple = new System.Windows.Forms.RadioButton();
            this.resizeCheck = new System.Windows.Forms.CheckBox();
            this.refOpenFileButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.openFilePath = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.previewPic = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.xorCheck = new System.Windows.Forms.RadioButton();
            this.orCheck = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.overlayCheck = new System.Windows.Forms.CheckBox();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPic)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(203, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接続";
            // 
            // baudrateCorrectionButton
            // 
            this.baudrateCorrectionButton.Location = new System.Drawing.Point(8, 208);
            this.baudrateCorrectionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.baudrateCorrectionButton.Name = "baudrateCorrectionButton";
            this.baudrateCorrectionButton.Size = new System.Drawing.Size(187, 43);
            this.baudrateCorrectionButton.TabIndex = 12;
            this.baudrateCorrectionButton.Text = "ボーレート校正";
            this.baudrateCorrectionButton.UseVisualStyleBackColor = true;
            this.baudrateCorrectionButton.Click += new System.EventHandler(this.baudrateCorrectionButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "ボーレート";
            // 
            // baudrateBox
            // 
            this.baudrateBox.Location = new System.Drawing.Point(11, 182);
            this.baudrateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.baudrateBox.Name = "baudrateBox";
            this.baudrateBox.Size = new System.Drawing.Size(184, 23);
            this.baudrateBox.TabIndex = 8;
            this.baudrateBox.Text = "300";
            this.baudrateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.baudrateBox_KeyPress);
            // 
            // updatePortsListButton
            // 
            this.updatePortsListButton.Location = new System.Drawing.Point(11, 63);
            this.updatePortsListButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.updatePortsListButton.Name = "updatePortsListButton";
            this.updatePortsListButton.Size = new System.Drawing.Size(128, 43);
            this.updatePortsListButton.TabIndex = 7;
            this.updatePortsListButton.Text = "更新";
            this.updatePortsListButton.UseVisualStyleBackColor = true;
            this.updatePortsListButton.Click += new System.EventHandler(this.updatePortsListButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(142, 63);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(53, 43);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "切断";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(11, 107);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(184, 53);
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
            this.portList.Location = new System.Drawing.Point(11, 38);
            this.portList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(184, 24);
            this.portList.TabIndex = 0;
            // 
            // disconnectIndicator
            // 
            this.disconnectIndicator.AutoCheck = false;
            this.disconnectIndicator.AutoSize = true;
            this.disconnectIndicator.Location = new System.Drawing.Point(190, 74);
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
            this.connectIndicator.Location = new System.Drawing.Point(94, 74);
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
            this.groupBox2.Location = new System.Drawing.Point(13, 279);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(203, 162);
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
            this.button1.Size = new System.Drawing.Size(187, 128);
            this.button1.TabIndex = 0;
            this.button1.Text = "PANIC!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.logBox);
            this.groupBox3.Location = new System.Drawing.Point(13, 579);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(470, 90);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ログ";
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("PC-9800", 8.25F);
            this.logBox.Location = new System.Drawing.Point(8, 22);
            this.logBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(454, 61);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.selectLV2);
            this.groupBox4.Controls.Add(this.selectLSimple);
            this.groupBox4.Controls.Add(this.resizeCheck);
            this.groupBox4.Controls.Add(this.refOpenFileButton);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.openFilePath);
            this.groupBox4.Location = new System.Drawing.Point(224, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(259, 160);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "メイン";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 107);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "転送方式";
            // 
            // selectLV2
            // 
            this.selectLV2.AutoSize = true;
            this.selectLV2.Location = new System.Drawing.Point(134, 126);
            this.selectLV2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectLV2.Name = "selectLV2";
            this.selectLV2.Size = new System.Drawing.Size(66, 20);
            this.selectLV2.TabIndex = 27;
            this.selectLV2.TabStop = true;
            this.selectLV2.Text = "L-V2+";
            this.selectLV2.UseVisualStyleBackColor = true;
            this.selectLV2.CheckedChanged += new System.EventHandler(this.selectLV2_CheckedChanged);
            // 
            // selectLSimple
            // 
            this.selectLSimple.AutoSize = true;
            this.selectLSimple.Location = new System.Drawing.Point(8, 126);
            this.selectLSimple.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectLSimple.Name = "selectLSimple";
            this.selectLSimple.Size = new System.Drawing.Size(90, 20);
            this.selectLSimple.TabIndex = 26;
            this.selectLSimple.TabStop = true;
            this.selectLSimple.Text = "L-Simple";
            this.selectLSimple.UseVisualStyleBackColor = true;
            this.selectLSimple.CheckedChanged += new System.EventHandler(this.selectLSimple_CheckedChanged);
            // 
            // resizeCheck
            // 
            this.resizeCheck.AutoSize = true;
            this.resizeCheck.Location = new System.Drawing.Point(8, 75);
            this.resizeCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resizeCheck.Name = "resizeCheck";
            this.resizeCheck.Size = new System.Drawing.Size(91, 20);
            this.resizeCheck.TabIndex = 15;
            this.resizeCheck.Text = "リサイズ";
            this.resizeCheck.UseVisualStyleBackColor = true;
            // 
            // refOpenFileButton
            // 
            this.refOpenFileButton.Location = new System.Drawing.Point(173, 72);
            this.refOpenFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refOpenFileButton.Name = "refOpenFileButton";
            this.refOpenFileButton.Size = new System.Drawing.Size(75, 24);
            this.refOpenFileButton.TabIndex = 14;
            this.refOpenFileButton.Text = "参照";
            this.refOpenFileButton.UseVisualStyleBackColor = true;
            this.refOpenFileButton.Click += new System.EventHandler(this.refOpenFileButton_Click);
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
            // openFilePath
            // 
            this.openFilePath.Location = new System.Drawing.Point(8, 40);
            this.openFilePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openFilePath.Name = "openFilePath";
            this.openFilePath.Size = new System.Drawing.Size(240, 23);
            this.openFilePath.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.generateButton);
            this.groupBox6.Controls.Add(this.showButton);
            this.groupBox6.Location = new System.Drawing.Point(224, 386);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(259, 55);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "操作";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(8, 22);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(102, 25);
            this.generateButton.TabIndex = 13;
            this.generateButton.Text = "データ生成";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("PC-9800", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.showButton.Location = new System.Drawing.Point(118, 22);
            this.showButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(130, 25);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "転送";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(96, 19);
            this.statusBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(152, 23);
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
            this.label7.Location = new System.Drawing.Point(5, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "進捗";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(96, 52);
            this.progress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(152, 16);
            this.progress.TabIndex = 11;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.previewPic);
            this.groupBox7.Location = new System.Drawing.Point(224, 178);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(259, 95);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "プレビュー";
            // 
            // previewPic
            // 
            this.previewPic.Location = new System.Drawing.Point(8, 21);
            this.previewPic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previewPic.Name = "previewPic";
            this.previewPic.Size = new System.Drawing.Size(240, 64);
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
            this.groupBox5.Location = new System.Drawing.Point(224, 279);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 101);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "状態";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "COMポート";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.xorCheck);
            this.groupBox8.Controls.Add(this.orCheck);
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.overlayCheck);
            this.groupBox8.Controls.Add(this.inputText);
            this.groupBox8.Location = new System.Drawing.Point(12, 447);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(471, 126);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "テキスト領域";
            // 
            // xorCheck
            // 
            this.xorCheck.AutoSize = true;
            this.xorCheck.Location = new System.Drawing.Point(330, 70);
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
            this.orCheck.Location = new System.Drawing.Point(330, 48);
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
            this.button2.Location = new System.Drawing.Point(330, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "文字転送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // overlayCheck
            // 
            this.overlayCheck.AutoSize = true;
            this.overlayCheck.Location = new System.Drawing.Point(330, 22);
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
            this.inputText.Size = new System.Drawing.Size(310, 98);
            this.inputText.TabIndex = 0;
            this.inputText.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 681);
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
        private System.Windows.Forms.RadioButton selectLV2;
        private System.Windows.Forms.RadioButton selectLSimple;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.CheckBox resizeCheck;
        private System.Windows.Forms.Button refOpenFileButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox openFilePath;
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
    }
}

