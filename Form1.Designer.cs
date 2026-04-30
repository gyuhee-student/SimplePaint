namespace SimplePaint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            gbxShape = new GroupBox();
            btnCircle = new Button();
            btnRectangle = new Button();
            btnLine = new Button();
            gbxColor = new GroupBox();
            cmbColor = new ComboBox();
            gbxLineWidth = new GroupBox();
            trbLineWidth = new TrackBar();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            btnZoomOut = new Button();
            lblZoomRate = new Label();
            btnZoomIn = new Button();
            pnlCanvas = new Panel();
            picCanvas = new PictureBox();
            gbxShape.SuspendLayout();
            gbxColor.SuspendLayout();
            gbxLineWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            pnlCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Constantia", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.FromArgb(255, 128, 0);
            lblAppName.Location = new Point(26, 24);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(334, 61);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Simple Paint";
            // 
            // gbxShape
            // 
            gbxShape.Controls.Add(btnCircle);
            gbxShape.Controls.Add(btnRectangle);
            gbxShape.Controls.Add(btnLine);
            gbxShape.Font = new Font("휴먼둥근헤드라인", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            gbxShape.ForeColor = Color.Blue;
            gbxShape.Location = new Point(26, 120);
            gbxShape.Name = "gbxShape";
            gbxShape.Size = new Size(342, 190);
            gbxShape.TabIndex = 1;
            gbxShape.TabStop = false;
            gbxShape.Text = "도형 선택";
            // 
            // btnCircle
            // 
            btnCircle.Font = new Font("함초롬바탕 확장", 10F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCircle.ForeColor = Color.Black;
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.Location = new Point(234, 70);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(103, 91);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            btnRectangle.Font = new Font("함초롬바탕 확장", 10F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnRectangle.ForeColor = Color.Black;
            btnRectangle.Image = (Image)resources.GetObject("btnRectangle.Image");
            btnRectangle.Location = new Point(120, 70);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(103, 91);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            btnLine.Font = new Font("함초롬바탕 확장", 10F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLine.ForeColor = Color.Black;
            btnLine.Image = (Image)resources.GetObject("btnLine.Image");
            btnLine.Location = new Point(6, 70);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(103, 91);
            btnLine.TabIndex = 0;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLine.UseVisualStyleBackColor = true;
            // 
            // gbxColor
            // 
            gbxColor.Controls.Add(cmbColor);
            gbxColor.Font = new Font("휴먼둥근헤드라인", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            gbxColor.ForeColor = Color.Blue;
            gbxColor.Location = new Point(384, 120);
            gbxColor.Name = "gbxColor";
            gbxColor.Size = new Size(216, 190);
            gbxColor.TabIndex = 2;
            gbxColor.TabStop = false;
            gbxColor.Text = "색 선택";
            // 
            // cmbColor
            // 
            cmbColor.Font = new Font("함초롬바탕 확장B", 11F, FontStyle.Regular, GraphicsUnit.Point, 129);
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 녹색" });
            cmbColor.Location = new Point(6, 78);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(204, 46);
            cmbColor.TabIndex = 0;
            // 
            // gbxLineWidth
            // 
            gbxLineWidth.AutoSize = true;
            gbxLineWidth.Controls.Add(trbLineWidth);
            gbxLineWidth.Font = new Font("휴먼둥근헤드라인", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            gbxLineWidth.ForeColor = Color.Blue;
            gbxLineWidth.Location = new Point(618, 120);
            gbxLineWidth.Name = "gbxLineWidth";
            gbxLineWidth.Size = new Size(288, 190);
            gbxLineWidth.TabIndex = 3;
            gbxLineWidth.TabStop = false;
            gbxLineWidth.Text = "선 두께";
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(6, 78);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(276, 69);
            trbLineWidth.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.FromArgb(192, 255, 255);
            btnOpenFile.Font = new Font("한컴 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOpenFile.Location = new Point(924, 162);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(126, 108);
            btnOpenFile.TabIndex = 4;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.FromArgb(128, 255, 128);
            btnSaveFile.Font = new Font("한컴 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSaveFile.Location = new Point(1062, 162);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(126, 108);
            btnSaveFile.TabIndex = 5;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Font = new Font("한컴 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnZoomOut.Location = new Point(924, 282);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(80, 42);
            btnZoomOut.TabIndex = 7;
            btnZoomOut.Text = "-";
            btnZoomOut.UseVisualStyleBackColor = true;
            // 
            // lblZoomRate
            // 
            lblZoomRate.Font = new Font("한컴 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblZoomRate.Location = new Point(1010, 282);
            lblZoomRate.Name = "lblZoomRate";
            lblZoomRate.Size = new Size(92, 42);
            lblZoomRate.TabIndex = 8;
            lblZoomRate.Text = "100%";
            lblZoomRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Font = new Font("한컴 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnZoomIn.Location = new Point(1108, 282);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(80, 42);
            btnZoomIn.TabIndex = 9;
            btnZoomIn.Text = "+";
            btnZoomIn.UseVisualStyleBackColor = true;
            // 
            // pnlCanvas
            // 
            pnlCanvas.AutoScroll = true;
            pnlCanvas.BorderStyle = BorderStyle.FixedSingle;
            pnlCanvas.Controls.Add(picCanvas);
            pnlCanvas.Location = new Point(14, 324);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(1174, 540);
            pnlCanvas.TabIndex = 10;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.BorderStyle = BorderStyle.FixedSingle;
            picCanvas.Location = new Point(0, 0);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1174, 540);
            picCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
            picCanvas.TabIndex = 6;
            picCanvas.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 878);
            Controls.Add(pnlCanvas);
            Controls.Add(btnZoomIn);
            Controls.Add(lblZoomRate);
            Controls.Add(btnZoomOut);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(gbxLineWidth);
            Controls.Add(gbxColor);
            Controls.Add(gbxShape);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbxShape.ResumeLayout(false);
            gbxColor.ResumeLayout(false);
            gbxLineWidth.ResumeLayout(false);
            gbxLineWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            pnlCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private GroupBox gbxShape;
        private GroupBox gbxColor;
        private ComboBox cmbColor;
        private GroupBox gbxLineWidth;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private PictureBox picCanvas;
        private TrackBar trbLineWidth;
        private Button btnLine;
        private Button btnCircle;
        private Button btnRectangle;
        private Button btnZoomOut;
        private Label lblZoomRate;
        private Button btnZoomIn;
        private Panel pnlCanvas;
    }
}
