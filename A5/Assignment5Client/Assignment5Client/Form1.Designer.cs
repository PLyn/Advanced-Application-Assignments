namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.client1_btn = new System.Windows.Forms.Button();
            this.client2_btn = new System.Windows.Forms.Button();
            this.client3_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // client1_btn
            // 
            this.client1_btn.BackColor = System.Drawing.Color.Green;
            this.client1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.client1_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.client1_btn.Location = new System.Drawing.Point(66, 92);
            this.client1_btn.Name = "client1_btn";
            this.client1_btn.Size = new System.Drawing.Size(280, 43);
            this.client1_btn.TabIndex = 0;
            this.client1_btn.Text = "Start Client #1";
            this.client1_btn.UseVisualStyleBackColor = false;
            this.client1_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // client2_btn
            // 
            this.client2_btn.BackColor = System.Drawing.Color.Blue;
            this.client2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.client2_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.client2_btn.Location = new System.Drawing.Point(66, 161);
            this.client2_btn.Name = "client2_btn";
            this.client2_btn.Size = new System.Drawing.Size(280, 43);
            this.client2_btn.TabIndex = 1;
            this.client2_btn.Text = "Start Client #2";
            this.client2_btn.UseVisualStyleBackColor = false;
            this.client2_btn.Click += new System.EventHandler(this.client2_btn_Click_1);
            // 
            // client3_btn
            // 
            this.client3_btn.BackColor = System.Drawing.Color.Magenta;
            this.client3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.client3_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.client3_btn.Location = new System.Drawing.Point(66, 229);
            this.client3_btn.Name = "client3_btn";
            this.client3_btn.Size = new System.Drawing.Size(280, 43);
            this.client3_btn.TabIndex = 2;
            this.client3_btn.Text = "Start Client #3";
            this.client3_btn.UseVisualStyleBackColor = false;
            this.client3_btn.Click += new System.EventHandler(this.client3_btn_Click_1);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Crimson;
            this.exit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_btn.Location = new System.Drawing.Point(75, 322);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(250, 36);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(70, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "MAIN MENU FOR CLIENTS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.client3_btn);
            this.Controls.Add(this.client2_btn);
            this.Controls.Add(this.client1_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button client1_btn;
        private System.Windows.Forms.Button client2_btn;
        private System.Windows.Forms.Button client3_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label1;
    }
}

