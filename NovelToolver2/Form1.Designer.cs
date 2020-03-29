namespace NovelToolver2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainFName = new System.Windows.Forms.TextBox();
            this.mainFLabel = new System.Windows.Forms.Label();
            this.mainFNew = new System.Windows.Forms.Button();
            this.mainFClear = new System.Windows.Forms.Button();
            this.mainFOK = new System.Windows.Forms.Button();
            this.mainFList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.subFLNew = new System.Windows.Forms.Button();
            this.subFLName = new System.Windows.Forms.TextBox();
            this.subFLClear = new System.Windows.Forms.Button();
            this.subFLL = new System.Windows.Forms.Label();
            this.subFLOK = new System.Windows.Forms.Button();
            this.subFLList = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.subFRNew = new System.Windows.Forms.Button();
            this.subFRName = new System.Windows.Forms.TextBox();
            this.subFRClear = new System.Windows.Forms.Button();
            this.subFRL = new System.Windows.Forms.Label();
            this.subFROK = new System.Windows.Forms.Button();
            this.subFRList = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fileLSave = new System.Windows.Forms.Button();
            this.boxL = new System.Windows.Forms.RichTextBox();
            this.fileLView = new System.Windows.Forms.Button();
            this.fileLList = new System.Windows.Forms.ComboBox();
            this.fileLName = new System.Windows.Forms.TextBox();
            this.fileLEdit = new System.Windows.Forms.Button();
            this.fileLClear = new System.Windows.Forms.Button();
            this.fileLL = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fileRSave = new System.Windows.Forms.Button();
            this.boxR = new System.Windows.Forms.RichTextBox();
            this.fileRView = new System.Windows.Forms.Button();
            this.fileRList = new System.Windows.Forms.ComboBox();
            this.fileRName = new System.Windows.Forms.TextBox();
            this.fileREdit = new System.Windows.Forms.Button();
            this.fileRClear = new System.Windows.Forms.Button();
            this.fileRL = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.colorList = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.mainFName);
            this.groupBox1.Controls.Add(this.mainFLabel);
            this.groupBox1.Controls.Add(this.mainFNew);
            this.groupBox1.Controls.Add(this.mainFClear);
            this.groupBox1.Controls.Add(this.mainFOK);
            this.groupBox1.Controls.Add(this.mainFList);
            this.groupBox1.Location = new System.Drawing.Point(167, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "メインフォルダ";
            // 
            // mainFName
            // 
            this.mainFName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainFName.Location = new System.Drawing.Point(64, 49);
            this.mainFName.Name = "mainFName";
            this.mainFName.Size = new System.Drawing.Size(273, 19);
            this.mainFName.TabIndex = 5;
            // 
            // mainFLabel
            // 
            this.mainFLabel.AutoSize = true;
            this.mainFLabel.BackColor = System.Drawing.Color.White;
            this.mainFLabel.Location = new System.Drawing.Point(6, 23);
            this.mainFLabel.Name = "mainFLabel";
            this.mainFLabel.Size = new System.Drawing.Size(52, 12);
            this.mainFLabel.TabIndex = 4;
            this.mainFLabel.Text = "フォルダ名";
            // 
            // mainFNew
            // 
            this.mainFNew.BackColor = System.Drawing.Color.White;
            this.mainFNew.Location = new System.Drawing.Point(343, 47);
            this.mainFNew.Name = "mainFNew";
            this.mainFNew.Size = new System.Drawing.Size(41, 23);
            this.mainFNew.TabIndex = 1;
            this.mainFNew.Text = "生成";
            this.mainFNew.UseVisualStyleBackColor = false;
            this.mainFNew.Click += new System.EventHandler(this.MainFNew_Click);
            // 
            // mainFClear
            // 
            this.mainFClear.BackColor = System.Drawing.Color.White;
            this.mainFClear.Location = new System.Drawing.Point(6, 47);
            this.mainFClear.Name = "mainFClear";
            this.mainFClear.Size = new System.Drawing.Size(52, 23);
            this.mainFClear.TabIndex = 3;
            this.mainFClear.Text = "新規";
            this.mainFClear.UseVisualStyleBackColor = false;
            this.mainFClear.Click += new System.EventHandler(this.MainFClear_Click);
            // 
            // mainFOK
            // 
            this.mainFOK.BackColor = System.Drawing.Color.White;
            this.mainFOK.Location = new System.Drawing.Point(343, 18);
            this.mainFOK.Name = "mainFOK";
            this.mainFOK.Size = new System.Drawing.Size(41, 23);
            this.mainFOK.TabIndex = 2;
            this.mainFOK.Text = "選択";
            this.mainFOK.UseVisualStyleBackColor = false;
            this.mainFOK.Click += new System.EventHandler(this.MainFOK_Click);
            // 
            // mainFList
            // 
            this.mainFList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainFList.FormattingEnabled = true;
            this.mainFList.Location = new System.Drawing.Point(65, 20);
            this.mainFList.Name = "mainFList";
            this.mainFList.Size = new System.Drawing.Size(272, 20);
            this.mainFList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.subFLNew);
            this.groupBox2.Controls.Add(this.subFLName);
            this.groupBox2.Controls.Add(this.subFLClear);
            this.groupBox2.Controls.Add(this.subFLL);
            this.groupBox2.Controls.Add(this.subFLOK);
            this.groupBox2.Controls.Add(this.subFLList);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "左：サブフォルダ";
            // 
            // subFLNew
            // 
            this.subFLNew.BackColor = System.Drawing.Color.White;
            this.subFLNew.Location = new System.Drawing.Point(296, 42);
            this.subFLNew.Name = "subFLNew";
            this.subFLNew.Size = new System.Drawing.Size(41, 23);
            this.subFLNew.TabIndex = 6;
            this.subFLNew.Text = "生成";
            this.subFLNew.UseVisualStyleBackColor = false;
            this.subFLNew.Click += new System.EventHandler(this.SubFLNew_Click);
            // 
            // subFLName
            // 
            this.subFLName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subFLName.Location = new System.Drawing.Point(64, 44);
            this.subFLName.Name = "subFLName";
            this.subFLName.Size = new System.Drawing.Size(226, 19);
            this.subFLName.TabIndex = 7;
            // 
            // subFLClear
            // 
            this.subFLClear.BackColor = System.Drawing.Color.White;
            this.subFLClear.Location = new System.Drawing.Point(8, 42);
            this.subFLClear.Name = "subFLClear";
            this.subFLClear.Size = new System.Drawing.Size(50, 23);
            this.subFLClear.TabIndex = 7;
            this.subFLClear.Text = "新規";
            this.subFLClear.UseVisualStyleBackColor = false;
            this.subFLClear.Click += new System.EventHandler(this.SubFLClear_Click);
            // 
            // subFLL
            // 
            this.subFLL.AutoSize = true;
            this.subFLL.BackColor = System.Drawing.Color.White;
            this.subFLL.Location = new System.Drawing.Point(6, 23);
            this.subFLL.Name = "subFLL";
            this.subFLL.Size = new System.Drawing.Size(52, 12);
            this.subFLL.TabIndex = 6;
            this.subFLL.Text = "フォルダ名";
            // 
            // subFLOK
            // 
            this.subFLOK.BackColor = System.Drawing.Color.White;
            this.subFLOK.Location = new System.Drawing.Point(296, 18);
            this.subFLOK.Name = "subFLOK";
            this.subFLOK.Size = new System.Drawing.Size(41, 23);
            this.subFLOK.TabIndex = 6;
            this.subFLOK.Text = "選択";
            this.subFLOK.UseVisualStyleBackColor = false;
            this.subFLOK.Click += new System.EventHandler(this.SubFLOK_Click);
            // 
            // subFLList
            // 
            this.subFLList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subFLList.FormattingEnabled = true;
            this.subFLList.Location = new System.Drawing.Point(64, 20);
            this.subFLList.Name = "subFLList";
            this.subFLList.Size = new System.Drawing.Size(226, 20);
            this.subFLList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.subFRNew);
            this.groupBox3.Controls.Add(this.subFRName);
            this.groupBox3.Controls.Add(this.subFRClear);
            this.groupBox3.Controls.Add(this.subFRL);
            this.groupBox3.Controls.Add(this.subFROK);
            this.groupBox3.Controls.Add(this.subFRList);
            this.groupBox3.Location = new System.Drawing.Point(366, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 72);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "右：サブフォルダ";
            // 
            // subFRNew
            // 
            this.subFRNew.BackColor = System.Drawing.Color.White;
            this.subFRNew.Location = new System.Drawing.Point(296, 42);
            this.subFRNew.Name = "subFRNew";
            this.subFRNew.Size = new System.Drawing.Size(41, 23);
            this.subFRNew.TabIndex = 6;
            this.subFRNew.Text = "生成";
            this.subFRNew.UseVisualStyleBackColor = false;
            this.subFRNew.Click += new System.EventHandler(this.SubFRNew_Click);
            // 
            // subFRName
            // 
            this.subFRName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subFRName.Location = new System.Drawing.Point(64, 44);
            this.subFRName.Name = "subFRName";
            this.subFRName.Size = new System.Drawing.Size(226, 19);
            this.subFRName.TabIndex = 7;
            // 
            // subFRClear
            // 
            this.subFRClear.BackColor = System.Drawing.Color.White;
            this.subFRClear.Location = new System.Drawing.Point(8, 42);
            this.subFRClear.Name = "subFRClear";
            this.subFRClear.Size = new System.Drawing.Size(50, 23);
            this.subFRClear.TabIndex = 7;
            this.subFRClear.Text = "新規";
            this.subFRClear.UseVisualStyleBackColor = false;
            this.subFRClear.Click += new System.EventHandler(this.SubFRClear_Click);
            // 
            // subFRL
            // 
            this.subFRL.AutoSize = true;
            this.subFRL.BackColor = System.Drawing.Color.White;
            this.subFRL.Location = new System.Drawing.Point(7, 23);
            this.subFRL.Name = "subFRL";
            this.subFRL.Size = new System.Drawing.Size(52, 12);
            this.subFRL.TabIndex = 6;
            this.subFRL.Text = "フォルダ名";
            // 
            // subFROK
            // 
            this.subFROK.BackColor = System.Drawing.Color.White;
            this.subFROK.Location = new System.Drawing.Point(296, 18);
            this.subFROK.Name = "subFROK";
            this.subFROK.Size = new System.Drawing.Size(41, 23);
            this.subFROK.TabIndex = 6;
            this.subFROK.Text = "選択";
            this.subFROK.UseVisualStyleBackColor = false;
            this.subFROK.Click += new System.EventHandler(this.SubFROK_Click);
            // 
            // subFRList
            // 
            this.subFRList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subFRList.FormattingEnabled = true;
            this.subFRList.Location = new System.Drawing.Point(64, 20);
            this.subFRList.Name = "subFRList";
            this.subFRList.Size = new System.Drawing.Size(226, 20);
            this.subFRList.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.fileLSave);
            this.groupBox4.Controls.Add(this.boxL);
            this.groupBox4.Controls.Add(this.fileLView);
            this.groupBox4.Controls.Add(this.fileLList);
            this.groupBox4.Controls.Add(this.fileLName);
            this.groupBox4.Controls.Add(this.fileLEdit);
            this.groupBox4.Controls.Add(this.fileLClear);
            this.groupBox4.Controls.Add(this.fileLL);
            this.groupBox4.Location = new System.Drawing.Point(12, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 425);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "左：ファイル";
            // 
            // fileLSave
            // 
            this.fileLSave.BackColor = System.Drawing.Color.White;
            this.fileLSave.Location = new System.Drawing.Point(261, 64);
            this.fileLSave.Name = "fileLSave";
            this.fileLSave.Size = new System.Drawing.Size(76, 23);
            this.fileLSave.TabIndex = 15;
            this.fileLSave.Text = "保存";
            this.fileLSave.UseVisualStyleBackColor = false;
            this.fileLSave.Click += new System.EventHandler(this.FileLSave_Click);
            // 
            // boxL
            // 
            this.boxL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.boxL.Location = new System.Drawing.Point(8, 90);
            this.boxL.Name = "boxL";
            this.boxL.Size = new System.Drawing.Size(329, 329);
            this.boxL.TabIndex = 14;
            this.boxL.Text = "";
            this.boxL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BoxL_CS);
            // 
            // fileLView
            // 
            this.fileLView.BackColor = System.Drawing.Color.White;
            this.fileLView.Location = new System.Drawing.Point(64, 64);
            this.fileLView.Name = "fileLView";
            this.fileLView.Size = new System.Drawing.Size(50, 23);
            this.fileLView.TabIndex = 9;
            this.fileLView.Text = "閲覧";
            this.fileLView.UseVisualStyleBackColor = false;
            this.fileLView.Click += new System.EventHandler(this.FileLView_Click);
            // 
            // fileLList
            // 
            this.fileLList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fileLList.FormattingEnabled = true;
            this.fileLList.Location = new System.Drawing.Point(64, 18);
            this.fileLList.Name = "fileLList";
            this.fileLList.Size = new System.Drawing.Size(273, 20);
            this.fileLList.TabIndex = 8;
            // 
            // fileLName
            // 
            this.fileLName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fileLName.Location = new System.Drawing.Point(64, 42);
            this.fileLName.Name = "fileLName";
            this.fileLName.Size = new System.Drawing.Size(273, 19);
            this.fileLName.TabIndex = 12;
            this.fileLName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoxL_CS);
            // 
            // fileLEdit
            // 
            this.fileLEdit.BackColor = System.Drawing.Color.White;
            this.fileLEdit.Location = new System.Drawing.Point(8, 64);
            this.fileLEdit.Name = "fileLEdit";
            this.fileLEdit.Size = new System.Drawing.Size(50, 23);
            this.fileLEdit.TabIndex = 11;
            this.fileLEdit.Text = "編集";
            this.fileLEdit.UseVisualStyleBackColor = false;
            this.fileLEdit.Click += new System.EventHandler(this.FileLEdit_Click);
            // 
            // fileLClear
            // 
            this.fileLClear.BackColor = System.Drawing.Color.White;
            this.fileLClear.Location = new System.Drawing.Point(8, 40);
            this.fileLClear.Name = "fileLClear";
            this.fileLClear.Size = new System.Drawing.Size(50, 23);
            this.fileLClear.TabIndex = 13;
            this.fileLClear.Text = "新規";
            this.fileLClear.UseVisualStyleBackColor = false;
            this.fileLClear.Click += new System.EventHandler(this.FileLClear_Click);
            // 
            // fileLL
            // 
            this.fileLL.AutoSize = true;
            this.fileLL.BackColor = System.Drawing.Color.White;
            this.fileLL.Location = new System.Drawing.Point(7, 21);
            this.fileLL.Name = "fileLL";
            this.fileLL.Size = new System.Drawing.Size(51, 12);
            this.fileLL.TabIndex = 10;
            this.fileLL.Text = "ファイル名";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.fileRSave);
            this.groupBox5.Controls.Add(this.boxR);
            this.groupBox5.Controls.Add(this.fileRView);
            this.groupBox5.Controls.Add(this.fileRList);
            this.groupBox5.Controls.Add(this.fileRName);
            this.groupBox5.Controls.Add(this.fileREdit);
            this.groupBox5.Controls.Add(this.fileRClear);
            this.groupBox5.Controls.Add(this.fileRL);
            this.groupBox5.Location = new System.Drawing.Point(366, 174);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(348, 425);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "右：ファイル";
            // 
            // fileRSave
            // 
            this.fileRSave.BackColor = System.Drawing.Color.White;
            this.fileRSave.Location = new System.Drawing.Point(261, 64);
            this.fileRSave.Name = "fileRSave";
            this.fileRSave.Size = new System.Drawing.Size(76, 23);
            this.fileRSave.TabIndex = 15;
            this.fileRSave.Text = "保存";
            this.fileRSave.UseVisualStyleBackColor = false;
            this.fileRSave.Click += new System.EventHandler(this.FileRSave_Click);
            // 
            // boxR
            // 
            this.boxR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.boxR.ForeColor = System.Drawing.Color.Black;
            this.boxR.Location = new System.Drawing.Point(8, 90);
            this.boxR.Name = "boxR";
            this.boxR.Size = new System.Drawing.Size(329, 329);
            this.boxR.TabIndex = 14;
            this.boxR.Text = "";
            this.boxR.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BoxR_CS);
            // 
            // fileRView
            // 
            this.fileRView.BackColor = System.Drawing.Color.White;
            this.fileRView.Location = new System.Drawing.Point(64, 64);
            this.fileRView.Name = "fileRView";
            this.fileRView.Size = new System.Drawing.Size(50, 23);
            this.fileRView.TabIndex = 9;
            this.fileRView.Text = "閲覧";
            this.fileRView.UseVisualStyleBackColor = false;
            this.fileRView.Click += new System.EventHandler(this.FileRView_Click);
            // 
            // fileRList
            // 
            this.fileRList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fileRList.FormattingEnabled = true;
            this.fileRList.Location = new System.Drawing.Point(64, 18);
            this.fileRList.Name = "fileRList";
            this.fileRList.Size = new System.Drawing.Size(273, 20);
            this.fileRList.TabIndex = 8;
            // 
            // fileRName
            // 
            this.fileRName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fileRName.Location = new System.Drawing.Point(64, 42);
            this.fileRName.Name = "fileRName";
            this.fileRName.Size = new System.Drawing.Size(273, 19);
            this.fileRName.TabIndex = 12;
            // 
            // fileREdit
            // 
            this.fileREdit.BackColor = System.Drawing.Color.White;
            this.fileREdit.Location = new System.Drawing.Point(8, 64);
            this.fileREdit.Name = "fileREdit";
            this.fileREdit.Size = new System.Drawing.Size(50, 23);
            this.fileREdit.TabIndex = 11;
            this.fileREdit.Text = "編集";
            this.fileREdit.UseVisualStyleBackColor = false;
            this.fileREdit.Click += new System.EventHandler(this.FileREdit_Click);
            // 
            // fileRClear
            // 
            this.fileRClear.BackColor = System.Drawing.Color.White;
            this.fileRClear.Location = new System.Drawing.Point(8, 40);
            this.fileRClear.Name = "fileRClear";
            this.fileRClear.Size = new System.Drawing.Size(50, 23);
            this.fileRClear.TabIndex = 13;
            this.fileRClear.Text = "新規";
            this.fileRClear.UseVisualStyleBackColor = false;
            this.fileRClear.Click += new System.EventHandler(this.FileRClear_Click);
            // 
            // fileRL
            // 
            this.fileRL.AutoSize = true;
            this.fileRL.BackColor = System.Drawing.Color.White;
            this.fileRL.Location = new System.Drawing.Point(7, 21);
            this.fileRL.Name = "fileRL";
            this.fileRL.Size = new System.Drawing.Size(51, 12);
            this.fileRL.TabIndex = 10;
            this.fileRL.Text = "ファイル名";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(17, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(129, 19);
            this.title.TabIndex = 17;
            this.title.Text = "NovelTool EX";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.White;
            this.version.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.version.ForeColor = System.Drawing.Color.SteelBlue;
            this.version.Location = new System.Drawing.Point(21, 54);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(45, 13);
            this.version.TabIndex = 18;
            this.version.Text = "ver.1.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(582, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "カラーテーマ";
            // 
            // colorList
            // 
            this.colorList.BackColor = System.Drawing.Color.White;
            this.colorList.FormattingEnabled = true;
            this.colorList.Items.AddRange(new object[] {
            "ライト",
            "ダーク",
            "サクラ"});
            this.colorList.Location = new System.Drawing.Point(612, 42);
            this.colorList.Name = "colorList";
            this.colorList.Size = new System.Drawing.Size(102, 20);
            this.colorList.TabIndex = 20;
            this.colorList.SelectedIndexChanged += new System.EventHandler(this.ColorList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 611);
            this.Controls.Add(this.colorList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.version);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NovelTool EX";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mainFName;
        private System.Windows.Forms.Label mainFLabel;
        private System.Windows.Forms.Button mainFNew;
        private System.Windows.Forms.Button mainFClear;
        private System.Windows.Forms.Button mainFOK;
        private System.Windows.Forms.ComboBox mainFList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button subFLNew;
        private System.Windows.Forms.TextBox subFLName;
        private System.Windows.Forms.Button subFLClear;
        private System.Windows.Forms.Label subFLL;
        private System.Windows.Forms.Button subFLOK;
        private System.Windows.Forms.ComboBox subFLList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button subFRNew;
        private System.Windows.Forms.TextBox subFRName;
        private System.Windows.Forms.Button subFRClear;
        private System.Windows.Forms.Label subFRL;
        private System.Windows.Forms.Button subFROK;
        private System.Windows.Forms.ComboBox subFRList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button fileLSave;
        private System.Windows.Forms.RichTextBox boxL;
        private System.Windows.Forms.Button fileLView;
        private System.Windows.Forms.ComboBox fileLList;
        private System.Windows.Forms.TextBox fileLName;
        private System.Windows.Forms.Button fileLEdit;
        private System.Windows.Forms.Button fileLClear;
        private System.Windows.Forms.Label fileLL;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button fileRSave;
        private System.Windows.Forms.RichTextBox boxR;
        private System.Windows.Forms.Button fileRView;
        private System.Windows.Forms.ComboBox fileRList;
        private System.Windows.Forms.TextBox fileRName;
        private System.Windows.Forms.Button fileREdit;
        private System.Windows.Forms.Button fileRClear;
        private System.Windows.Forms.Label fileRL;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox colorList;
    }
}

