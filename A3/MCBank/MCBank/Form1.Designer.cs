namespace MCBank
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboAddAccount = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddBalance = new System.Windows.Forms.TextBox();
            this.txtAddBranch = new System.Windows.Forms.TextBox();
            this.txtAddlName = new System.Windows.Forms.TextBox();
            this.txtAddfName = new System.Windows.Forms.TextBox();
            this.txtAddTRN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvGet = new System.Windows.Forms.DataGridView();
            this.btnSingleSearch = new System.Windows.Forms.Button();
            this.txtGetTRN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDelete = new System.Windows.Forms.DataGridView();
            this.btnSearchDelete = new System.Windows.Forms.Button();
            this.txtDeleteTRN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboAddAccount);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtAddBalance);
            this.tabPage1.Controls.Add(this.txtAddBranch);
            this.tabPage1.Controls.Add(this.txtAddlName);
            this.tabPage1.Controls.Add(this.txtAddfName);
            this.tabPage1.Controls.Add(this.txtAddTRN);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Client";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboAddAccount
            // 
            this.comboAddAccount.FormattingEnabled = true;
            this.comboAddAccount.Items.AddRange(new object[] {
            "Savings",
            "Chequing"});
            this.comboAddAccount.Location = new System.Drawing.Point(145, 287);
            this.comboAddAccount.Name = "comboAddAccount";
            this.comboAddAccount.Size = new System.Drawing.Size(152, 21);
            this.comboAddAccount.TabIndex = 13;
            this.comboAddAccount.Text = "Select Account Type";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(145, 398);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Balance :";
            // 
            // txtAddBalance
            // 
            this.txtAddBalance.Location = new System.Drawing.Point(145, 342);
            this.txtAddBalance.Name = "txtAddBalance";
            this.txtAddBalance.Size = new System.Drawing.Size(152, 20);
            this.txtAddBalance.TabIndex = 10;
            // 
            // txtAddBranch
            // 
            this.txtAddBranch.Location = new System.Drawing.Point(145, 224);
            this.txtAddBranch.Name = "txtAddBranch";
            this.txtAddBranch.Size = new System.Drawing.Size(152, 20);
            this.txtAddBranch.TabIndex = 9;
            // 
            // txtAddlName
            // 
            this.txtAddlName.Location = new System.Drawing.Point(145, 164);
            this.txtAddlName.Name = "txtAddlName";
            this.txtAddlName.Size = new System.Drawing.Size(152, 20);
            this.txtAddlName.TabIndex = 8;
            // 
            // txtAddfName
            // 
            this.txtAddfName.Location = new System.Drawing.Point(145, 106);
            this.txtAddfName.Name = "txtAddfName";
            this.txtAddfName.Size = new System.Drawing.Size(152, 20);
            this.txtAddfName.TabIndex = 7;
            // 
            // txtAddTRN
            // 
            this.txtAddTRN.Location = new System.Drawing.Point(145, 52);
            this.txtAddTRN.Name = "txtAddTRN";
            this.txtAddTRN.Size = new System.Drawing.Size(152, 20);
            this.txtAddTRN.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Account : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branch : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TRN # :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Client";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dgvGet);
            this.tabPage2.Controls.Add(this.btnSingleSearch);
            this.tabPage2.Controls.Add(this.txtGetTRN);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Get Single Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(298, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Get Single Client";
            // 
            // dgvGet
            // 
            this.dgvGet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGet.Enabled = false;
            this.dgvGet.Location = new System.Drawing.Point(29, 91);
            this.dgvGet.Name = "dgvGet";
            this.dgvGet.Size = new System.Drawing.Size(655, 215);
            this.dgvGet.TabIndex = 3;
            // 
            // btnSingleSearch
            // 
            this.btnSingleSearch.Location = new System.Drawing.Point(265, 62);
            this.btnSingleSearch.Name = "btnSingleSearch";
            this.btnSingleSearch.Size = new System.Drawing.Size(147, 23);
            this.btnSingleSearch.TabIndex = 2;
            this.btnSingleSearch.Text = "Search";
            this.btnSingleSearch.UseVisualStyleBackColor = true;
            // 
            // txtGetTRN
            // 
            this.txtGetTRN.Location = new System.Drawing.Point(93, 65);
            this.txtGetTRN.Name = "txtGetTRN";
            this.txtGetTRN.Size = new System.Drawing.Size(166, 20);
            this.txtGetTRN.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "TRN # :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.dgvAll);
            this.tabPage3.Controls.Add(this.btnShowAll);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(716, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Get All Clients";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(306, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Get All Clients";
            // 
            // dgvAll
            // 
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Enabled = false;
            this.dgvAll.Location = new System.Drawing.Point(25, 69);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.Size = new System.Drawing.Size(654, 349);
            this.dgvAll.TabIndex = 1;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(25, 40);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(146, 23);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show All Clients";
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvDelete);
            this.tabPage4.Controls.Add(this.btnSearchDelete);
            this.tabPage4.Controls.Add(this.txtDeleteTRN);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(716, 442);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete Client";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvDelete
            // 
            this.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete.Enabled = false;
            this.dgvDelete.Location = new System.Drawing.Point(25, 115);
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.Size = new System.Drawing.Size(655, 190);
            this.dgvDelete.TabIndex = 5;
            // 
            // btnSearchDelete
            // 
            this.btnSearchDelete.Location = new System.Drawing.Point(232, 86);
            this.btnSearchDelete.Name = "btnSearchDelete";
            this.btnSearchDelete.Size = new System.Drawing.Size(115, 23);
            this.btnSearchDelete.TabIndex = 4;
            this.btnSearchDelete.Text = "Search";
            this.btnSearchDelete.UseVisualStyleBackColor = true;
            // 
            // txtDeleteTRN
            // 
            this.txtDeleteTRN.Location = new System.Drawing.Point(74, 86);
            this.txtDeleteTRN.Name = "txtDeleteTRN";
            this.txtDeleteTRN.Size = new System.Drawing.Size(152, 20);
            this.txtDeleteTRN.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "TRN # :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "SELECT CLIENT TO BE DELETED";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(334, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Delete Client";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 485);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Mitchell\'s Commercial Bank";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddBalance;
        private System.Windows.Forms.TextBox txtAddBranch;
        private System.Windows.Forms.TextBox txtAddlName;
        private System.Windows.Forms.TextBox txtAddfName;
        private System.Windows.Forms.TextBox txtAddTRN;
        private System.Windows.Forms.ComboBox comboAddAccount;
        private System.Windows.Forms.DataGridView dgvGet;
        private System.Windows.Forms.Button btnSingleSearch;
        private System.Windows.Forms.TextBox txtGetTRN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearchDelete;
        private System.Windows.Forms.TextBox txtDeleteTRN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvDelete;
    }
}

