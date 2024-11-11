namespace Scanner
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            plControlsContainer = new Panel();
            btnScan = new Button();
            groupBox2 = new GroupBox();
            textBoxPathSave = new TextBox();
            linkLabelChangeSavePath = new LinkLabel();
            linkLabelOpenSavedPath = new LinkLabel();
            groupBox1 = new GroupBox();
            radioButtonNoColor = new RadioButton();
            radioButtonColorized = new RadioButton();
            comboBoxDPI = new NumericUpDown();
            numericUpDownCountOfPaper = new NumericUpDown();
            comboBoxPaperSize = new ComboBox();
            comboBoxDevices = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            picBoxLogo = new PictureBox();
            pictureBoxShowImage = new PictureBox();
            btnSaveImage = new Button();
            toolTip1 = new ToolTip(components);
            pictureBoxLoading = new PictureBox();
            plControlsContainer.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxDPI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountOfPaper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            SuspendLayout();
            // 
            // plControlsContainer
            // 
            plControlsContainer.BackColor = Color.WhiteSmoke;
            plControlsContainer.Controls.Add(btnScan);
            plControlsContainer.Controls.Add(groupBox2);
            plControlsContainer.Controls.Add(groupBox1);
            plControlsContainer.Controls.Add(comboBoxDPI);
            plControlsContainer.Controls.Add(numericUpDownCountOfPaper);
            plControlsContainer.Controls.Add(comboBoxPaperSize);
            plControlsContainer.Controls.Add(comboBoxDevices);
            plControlsContainer.Controls.Add(label4);
            plControlsContainer.Controls.Add(label1);
            plControlsContainer.Controls.Add(label3);
            plControlsContainer.Controls.Add(label2);
            plControlsContainer.Controls.Add(picBoxLogo);
            plControlsContainer.Dock = DockStyle.Left;
            plControlsContainer.Location = new Point(0, 0);
            plControlsContainer.Name = "plControlsContainer";
            plControlsContainer.Padding = new Padding(5);
            plControlsContainer.Size = new Size(323, 753);
            plControlsContainer.TabIndex = 0;
            // 
            // btnScan
            // 
            btnScan.Dock = DockStyle.Bottom;
            btnScan.Font = new Font("Cairo", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScan.ForeColor = Color.FromArgb(48, 48, 74);
            btnScan.Image = Properties.Resources.scan;
            btnScan.ImageAlign = ContentAlignment.MiddleRight;
            btnScan.Location = new Point(5, 702);
            btnScan.Name = "btnScan";
            btnScan.Padding = new Padding(10, 0, 0, 0);
            btnScan.Size = new Size(313, 46);
            btnScan.TabIndex = 0;
            btnScan.Text = "إجراء المسح";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxPathSave);
            groupBox2.Controls.Add(linkLabelChangeSavePath);
            groupBox2.Controls.Add(linkLabelOpenSavedPath);
            groupBox2.Font = new Font("Cairo", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(48, 48, 74);
            groupBox2.Location = new Point(14, 552);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 120);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "مكان الحفظ";
            // 
            // textBoxPathSave
            // 
            textBoxPathSave.Location = new Point(11, 36);
            textBoxPathSave.Name = "textBoxPathSave";
            textBoxPathSave.ReadOnly = true;
            textBoxPathSave.Size = new Size(279, 41);
            textBoxPathSave.TabIndex = 11;
            // 
            // linkLabelChangeSavePath
            // 
            linkLabelChangeSavePath.AutoSize = true;
            linkLabelChangeSavePath.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelChangeSavePath.LinkColor = Color.DarkOliveGreen;
            linkLabelChangeSavePath.Location = new Point(6, 81);
            linkLabelChangeSavePath.Name = "linkLabelChangeSavePath";
            linkLabelChangeSavePath.Size = new Size(121, 29);
            linkLabelChangeSavePath.TabIndex = 10;
            linkLabelChangeSavePath.TabStop = true;
            linkLabelChangeSavePath.Text = "تغير مسار الحفظ";
            linkLabelChangeSavePath.LinkClicked += linkLabelChangeSavePath_LinkClicked;
            // 
            // linkLabelOpenSavedPath
            // 
            linkLabelOpenSavedPath.AutoSize = true;
            linkLabelOpenSavedPath.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelOpenSavedPath.LinkColor = Color.Gray;
            linkLabelOpenSavedPath.Location = new Point(249, 81);
            linkLabelOpenSavedPath.Name = "linkLabelOpenSavedPath";
            linkLabelOpenSavedPath.Size = new Size(38, 29);
            linkLabelOpenSavedPath.TabIndex = 8;
            linkLabelOpenSavedPath.TabStop = true;
            linkLabelOpenSavedPath.Text = "فتح";
            linkLabelOpenSavedPath.LinkClicked += linkLabelOpenSavedPath_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonNoColor);
            groupBox1.Controls.Add(radioButtonColorized);
            groupBox1.ForeColor = Color.FromArgb(48, 48, 74);
            groupBox1.Location = new Point(14, 448);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 90);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "خيارات الالون";
            // 
            // radioButtonNoColor
            // 
            radioButtonNoColor.AutoSize = true;
            radioButtonNoColor.Font = new Font("Cairo", 10.8F, FontStyle.Bold);
            radioButtonNoColor.Location = new Point(25, 38);
            radioButtonNoColor.Name = "radioButtonNoColor";
            radioButtonNoColor.Size = new Size(108, 37);
            radioButtonNoColor.TabIndex = 6;
            radioButtonNoColor.Text = "غير ملون";
            radioButtonNoColor.UseVisualStyleBackColor = true;
            // 
            // radioButtonColorized
            // 
            radioButtonColorized.AutoSize = true;
            radioButtonColorized.Checked = true;
            radioButtonColorized.Font = new Font("Cairo", 10.8F, FontStyle.Bold);
            radioButtonColorized.ForeColor = Color.DarkOrange;
            radioButtonColorized.Location = new Point(210, 38);
            radioButtonColorized.Name = "radioButtonColorized";
            radioButtonColorized.Size = new Size(78, 37);
            radioButtonColorized.TabIndex = 5;
            radioButtonColorized.TabStop = true;
            radioButtonColorized.Text = "ملون";
            radioButtonColorized.UseVisualStyleBackColor = true;
            // 
            // comboBoxDPI
            // 
            comboBoxDPI.Location = new Point(14, 314);
            comboBoxDPI.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            comboBoxDPI.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            comboBoxDPI.Name = "comboBoxDPI";
            comboBoxDPI.Size = new Size(296, 39);
            comboBoxDPI.TabIndex = 2;
            comboBoxDPI.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericUpDownCountOfPaper
            // 
            numericUpDownCountOfPaper.Location = new Point(14, 230);
            numericUpDownCountOfPaper.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownCountOfPaper.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCountOfPaper.Name = "numericUpDownCountOfPaper";
            numericUpDownCountOfPaper.Size = new Size(296, 39);
            numericUpDownCountOfPaper.TabIndex = 2;
            toolTip1.SetToolTip(numericUpDownCountOfPaper, "عدد الاوراق الموجوده داخل الماسح");
            numericUpDownCountOfPaper.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxPaperSize
            // 
            comboBoxPaperSize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPaperSize.FormattingEnabled = true;
            comboBoxPaperSize.Items.AddRange(new object[] { "A4", "A5", "Letter" });
            comboBoxPaperSize.Location = new Point(15, 396);
            comboBoxPaperSize.Name = "comboBoxPaperSize";
            comboBoxPaperSize.Size = new Size(296, 40);
            comboBoxPaperSize.TabIndex = 1;
            // 
            // comboBoxDevices
            // 
            comboBoxDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDevices.FormattingEnabled = true;
            comboBoxDevices.Location = new Point(14, 148);
            comboBoxDevices.Name = "comboBoxDevices";
            comboBoxDevices.Size = new Size(296, 40);
            comboBoxDevices.TabIndex = 1;
            toolTip1.SetToolTip(comboBoxDevices, "أجهزة الماسح المتصلة");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(48, 48, 74);
            label4.Location = new Point(220, 194);
            label4.Name = "label4";
            label4.Size = new Size(95, 33);
            label4.TabIndex = 30;
            label4.Text = "عدد النسخ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(48, 48, 74);
            label1.Location = new Point(189, 360);
            label1.Name = "label1";
            label1.Size = new Size(121, 33);
            label1.TabIndex = 30;
            label1.Text = "مقاس الورقة";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(48, 48, 74);
            label3.Location = new Point(213, 277);
            label3.Name = "label3";
            label3.Size = new Size(102, 33);
            label3.TabIndex = 30;
            label3.Text = "دقة المسح";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(48, 48, 74);
            label2.Location = new Point(251, 115);
            label2.Name = "label2";
            label2.Size = new Size(64, 33);
            label2.TabIndex = 30;
            label2.Text = "الجهاز";
            // 
            // picBoxLogo
            // 
            picBoxLogo.Image = Properties.Resources.ScannerLogo;
            picBoxLogo.Location = new Point(102, 11);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(208, 83);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 0;
            picBoxLogo.TabStop = false;
            // 
            // pictureBoxShowImage
            // 
            pictureBoxShowImage.BackColor = Color.FromArgb(250, 251, 252);
            pictureBoxShowImage.Dock = DockStyle.Fill;
            pictureBoxShowImage.Image = (Image)resources.GetObject("pictureBoxShowImage.Image");
            pictureBoxShowImage.Location = new Point(323, 0);
            pictureBoxShowImage.Name = "pictureBoxShowImage";
            pictureBoxShowImage.Size = new Size(619, 753);
            pictureBoxShowImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShowImage.TabIndex = 1;
            pictureBoxShowImage.TabStop = false;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveImage.Image = Properties.Resources.save_image;
            btnSaveImage.Location = new Point(889, 707);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(41, 39);
            btnSaveImage.TabIndex = 10;
            toolTip1.SetToolTip(btnSaveImage, "حفظ الصورة المعروضة");
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.BackColor = Color.FromArgb(250, 251, 252);
            pictureBoxLoading.Dock = DockStyle.Bottom;
            pictureBoxLoading.Image = (Image)resources.GetObject("pictureBoxLoading.Image");
            pictureBoxLoading.Location = new Point(323, 690);
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.Size = new Size(619, 63);
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLoading.TabIndex = 7;
            pictureBoxLoading.TabStop = false;
            pictureBoxLoading.Visible = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(942, 753);
            Controls.Add(btnSaveImage);
            Controls.Add(pictureBoxLoading);
            Controls.Add(pictureBoxShowImage);
            Controls.Add(plControlsContainer);
            Font = new Font("Cairo SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            Name = "MainPage";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الماسح الضوئى";
            Load += MainPage_Load;
            plControlsContainer.ResumeLayout(false);
            plControlsContainer.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxDPI).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountOfPaper).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plControlsContainer;
        private PictureBox picBoxLogo;
        private PictureBox pictureBoxShowImage;
        private ComboBox comboBoxDevices;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButtonColorized;
        private NumericUpDown numericUpDownCountOfPaper;
        private Label label4;
        private GroupBox groupBox2;
        private LinkLabel linkLabelOpenSavedPath;
        private RadioButton radioButtonNoColor;
        private Button btnScan;
        private Button btnSaveImage;
        private LinkLabel linkLabelChangeSavePath;
        private ToolTip toolTip1;
        private TextBox textBoxPathSave;
        private ComboBox comboBoxPaperSize;
        private Label label1;
        private PictureBox pictureBoxLoading;
        private NumericUpDown comboBoxDPI;
    }
}
