namespace WindowsFormsApplication2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ouput_txtBox = new System.Windows.Forms.RichTextBox();
            this.connStatus_lble = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "ADD",
            "MINUS",
            "MULTIPLY"});
            this.comboBox.Location = new System.Drawing.Point(279, 275);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 0;
            this.comboBox.Text = "Select Data To Set";
            // 
            // ouput_txtBox
            // 
            this.ouput_txtBox.Location = new System.Drawing.Point(12, 56);
            this.ouput_txtBox.Name = "ouput_txtBox";
            this.ouput_txtBox.Size = new System.Drawing.Size(411, 193);
            this.ouput_txtBox.TabIndex = 1;
            this.ouput_txtBox.Text = "";
            // 
            // connStatus_lble
            // 
            this.connStatus_lble.AutoSize = true;
            this.connStatus_lble.Location = new System.Drawing.Point(43, 29);
            this.connStatus_lble.Name = "connStatus_lble";
            this.connStatus_lble.Size = new System.Drawing.Size(0, 13);
            this.connStatus_lble.TabIndex = 2;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(279, 326);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(121, 23);
            this.send_btn.TabIndex = 3;
            this.send_btn.Text = "Sned Data";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 361);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.connStatus_lble);
            this.Controls.Add(this.ouput_txtBox);
            this.Controls.Add(this.comboBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox ouput_txtBox;
        private System.Windows.Forms.Label connStatus_lble;
        private System.Windows.Forms.Button send_btn;
    }
}