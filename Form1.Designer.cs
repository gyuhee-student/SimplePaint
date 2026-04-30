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
            lblAppName = new Label();
            gbxShape = new GroupBox();
            gbxColor = new GroupBox();
            gbxdukke = new GroupBox();
            cmbColor = new ComboBox();
            button1 = new Button();
            gbxColor.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Constantia", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.FromArgb(255, 128, 0);
            lblAppName.Location = new Point(35, 34);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(386, 72);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Simple Paint";
            // 
            // gbxShape
            // 
            gbxShape.Font = new Font("휴먼둥근헤드라인", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            gbxShape.ForeColor = Color.Blue;
            gbxShape.Location = new Point(35, 160);
            gbxShape.Name = "gbxShape";
            gbxShape.Size = new Size(406, 224);
            gbxShape.TabIndex = 1;
            gbxShape.TabStop = false;
            gbxShape.Text = "도형 선택";
            // 
            // gbxColor
            // 
            gbxColor.Controls.Add(cmbColor);
            gbxColor.Font = new Font("휴먼둥근헤드라인", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            gbxColor.ForeColor = Color.Blue;
            gbxColor.Location = new Point(473, 160);
            gbxColor.Name = "gbxColor";
            gbxColor.Size = new Size(259, 224);
            gbxColor.TabIndex = 2;
            gbxColor.TabStop = false;
            gbxColor.Text = "색 선택";
            // 
            // gbxdukke
            // 
            gbxdukke.Font = new Font("휴먼둥근헤드라인", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            gbxdukke.ForeColor = Color.Blue;
            gbxdukke.Location = new Point(760, 160);
            gbxdukke.Name = "gbxdukke";
            gbxdukke.Size = new Size(331, 224);
            gbxdukke.TabIndex = 3;
            gbxdukke.TabStop = false;
            gbxdukke.Text = "색 선택";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Location = new Point(6, 98);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(242, 47);
            cmbColor.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Font = new Font("한컴 고딕", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(1109, 215);
            button1.Name = "button1";
            button1.Size = new Size(150, 137);
            button1.TabIndex = 4;
            button1.Text = "열기";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 1113);
            Controls.Add(button1);
            Controls.Add(gbxdukke);
            Controls.Add(gbxColor);
            Controls.Add(gbxShape);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbxColor.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private GroupBox gbxShape;
        private GroupBox gbxColor;
        private ComboBox cmbColor;
        private GroupBox gbxdukke;
        private Button button1;
    }
}
