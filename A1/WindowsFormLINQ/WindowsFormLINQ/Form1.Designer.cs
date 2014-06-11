namespace WindowsFormLINQ
{
    partial class baseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baseForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageWelcome = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageCreate = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.TextBoxLocation = new System.Windows.Forms.TextBox();
            this.TextBoxServiceTag = new System.Windows.Forms.TextBox();
            this.TextBoxSerial = new System.Windows.Forms.TextBox();
            this.TextBoxModel = new System.Windows.Forms.TextBox();
            this.TextBoxManufacturer = new System.Windows.Forms.TextBox();
            this.TextBoxQuantity = new System.Windows.Forms.TextBox();
            this.TextBoxItemType = new System.Windows.Forms.TextBox();
            this.TextBoxNCUTag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelItemType = new System.Windows.Forms.Label();
            this.labelNCUTag = new System.Windows.Forms.Label();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.ViewDataGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.labelNCUTagSearch = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxNotesUpdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxStatusUpdate = new System.Windows.Forms.TextBox();
            this.TextBoxLocationUpdate = new System.Windows.Forms.TextBox();
            this.TextBoxServiceTagUpdate = new System.Windows.Forms.TextBox();
            this.TextBoxSerialNumberUpdate = new System.Windows.Forms.TextBox();
            this.TextBoxModelUpdate = new System.Windows.Forms.TextBox();
            this.TextBoxManufacturerUpdate = new System.Windows.Forms.TextBox();
            this.TextBoxQuantityUpdate = new System.Windows.Forms.TextBox();
            this.TextBoxItemTypeUpdate = new System.Windows.Forms.TextBox();
            this.TextBoxNCUTagUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.TextBoxRecordTag = new System.Windows.Forms.TextBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageCreate.SuspendLayout();
            this.tabPageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataGrid)).BeginInit();
            this.tabPageUpdate.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageWelcome);
            this.tabControlMain.Controls.Add(this.tabPageCreate);
            this.tabControlMain.Controls.Add(this.tabPageView);
            this.tabControlMain.Controls.Add(this.tabPageUpdate);
            this.tabControlMain.Controls.Add(this.tabPageDelete);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(861, 576);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageWelcome
            // 
            this.tabPageWelcome.Controls.Add(this.pictureBox1);
            this.tabPageWelcome.Location = new System.Drawing.Point(4, 22);
            this.tabPageWelcome.Name = "tabPageWelcome";
            this.tabPageWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWelcome.Size = new System.Drawing.Size(853, 550);
            this.tabPageWelcome.TabIndex = 0;
            this.tabPageWelcome.Text = "Welcome";
            this.tabPageWelcome.UseVisualStyleBackColor = true;
            this.tabPageWelcome.Click += new System.EventHandler(this.tabPageWelcome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 548);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabPageCreate
            // 
            this.tabPageCreate.BackColor = System.Drawing.Color.Lavender;
            this.tabPageCreate.Controls.Add(this.label2);
            this.tabPageCreate.Controls.Add(this.TextBoxNotes);
            this.tabPageCreate.Controls.Add(this.label1);
            this.tabPageCreate.Controls.Add(this.TextBoxStatus);
            this.tabPageCreate.Controls.Add(this.buttonCreate);
            this.tabPageCreate.Controls.Add(this.TextBoxLocation);
            this.tabPageCreate.Controls.Add(this.TextBoxServiceTag);
            this.tabPageCreate.Controls.Add(this.TextBoxSerial);
            this.tabPageCreate.Controls.Add(this.TextBoxModel);
            this.tabPageCreate.Controls.Add(this.TextBoxManufacturer);
            this.tabPageCreate.Controls.Add(this.TextBoxQuantity);
            this.tabPageCreate.Controls.Add(this.TextBoxItemType);
            this.tabPageCreate.Controls.Add(this.TextBoxNCUTag);
            this.tabPageCreate.Controls.Add(this.label8);
            this.tabPageCreate.Controls.Add(this.label7);
            this.tabPageCreate.Controls.Add(this.label6);
            this.tabPageCreate.Controls.Add(this.label5);
            this.tabPageCreate.Controls.Add(this.label4);
            this.tabPageCreate.Controls.Add(this.labelManufacturer);
            this.tabPageCreate.Controls.Add(this.labelItemType);
            this.tabPageCreate.Controls.Add(this.labelNCUTag);
            this.tabPageCreate.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreate.Name = "tabPageCreate";
            this.tabPageCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreate.Size = new System.Drawing.Size(853, 550);
            this.tabPageCreate.TabIndex = 1;
            this.tabPageCreate.Text = "Create";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Notes:";
            // 
            // TextBoxNotes
            // 
            this.TextBoxNotes.Location = new System.Drawing.Point(390, 449);
            this.TextBoxNotes.Name = "TextBoxNotes";
            this.TextBoxNotes.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNotes.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Status:";
            // 
            // TextBoxStatus
            // 
            this.TextBoxStatus.Location = new System.Drawing.Point(390, 406);
            this.TextBoxStatus.Name = "TextBoxStatus";
            this.TextBoxStatus.Size = new System.Drawing.Size(100, 20);
            this.TextBoxStatus.TabIndex = 17;
            // 
            // buttonCreate
            // 
            this.buttonCreate.AccessibleDescription = "";
            this.buttonCreate.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreate.Image")));
            this.buttonCreate.Location = new System.Drawing.Point(407, 490);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(56, 42);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Tag = "";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.button1_Click);
            this.buttonCreate.MouseHover += new System.EventHandler(this.button1_hover);
            // 
            // TextBoxLocation
            // 
            this.TextBoxLocation.Location = new System.Drawing.Point(390, 357);
            this.TextBoxLocation.Name = "TextBoxLocation";
            this.TextBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLocation.TabIndex = 15;
            // 
            // TextBoxServiceTag
            // 
            this.TextBoxServiceTag.Location = new System.Drawing.Point(390, 311);
            this.TextBoxServiceTag.Name = "TextBoxServiceTag";
            this.TextBoxServiceTag.Size = new System.Drawing.Size(100, 20);
            this.TextBoxServiceTag.TabIndex = 14;
            // 
            // TextBoxSerial
            // 
            this.TextBoxSerial.Location = new System.Drawing.Point(390, 271);
            this.TextBoxSerial.Name = "TextBoxSerial";
            this.TextBoxSerial.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSerial.TabIndex = 13;
            // 
            // TextBoxModel
            // 
            this.TextBoxModel.Location = new System.Drawing.Point(390, 230);
            this.TextBoxModel.Name = "TextBoxModel";
            this.TextBoxModel.Size = new System.Drawing.Size(100, 20);
            this.TextBoxModel.TabIndex = 12;
            // 
            // TextBoxManufacturer
            // 
            this.TextBoxManufacturer.Location = new System.Drawing.Point(390, 185);
            this.TextBoxManufacturer.Name = "TextBoxManufacturer";
            this.TextBoxManufacturer.Size = new System.Drawing.Size(100, 20);
            this.TextBoxManufacturer.TabIndex = 11;
            // 
            // TextBoxQuantity
            // 
            this.TextBoxQuantity.Location = new System.Drawing.Point(390, 143);
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.TextBoxQuantity.TabIndex = 10;
            // 
            // TextBoxItemType
            // 
            this.TextBoxItemType.Location = new System.Drawing.Point(390, 99);
            this.TextBoxItemType.Name = "TextBoxItemType";
            this.TextBoxItemType.Size = new System.Drawing.Size(100, 20);
            this.TextBoxItemType.TabIndex = 9;
            // 
            // TextBoxNCUTag
            // 
            this.TextBoxNCUTag.Location = new System.Drawing.Point(390, 50);
            this.TextBoxNCUTag.Name = "TextBoxNCUTag";
            this.TextBoxNCUTag.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNCUTag.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Location:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Service Tag:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Serial Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manufacturer:";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(308, 143);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(49, 13);
            this.labelManufacturer.TabIndex = 2;
            this.labelManufacturer.Text = "Quantity:";
            this.labelManufacturer.Click += new System.EventHandler(this.labelManufacturer_Click);
            // 
            // labelItemType
            // 
            this.labelItemType.AutoSize = true;
            this.labelItemType.Location = new System.Drawing.Point(308, 102);
            this.labelItemType.Name = "labelItemType";
            this.labelItemType.Size = new System.Drawing.Size(57, 13);
            this.labelItemType.TabIndex = 1;
            this.labelItemType.Text = "Item Type:";
            // 
            // labelNCUTag
            // 
            this.labelNCUTag.AutoSize = true;
            this.labelNCUTag.Location = new System.Drawing.Point(310, 50);
            this.labelNCUTag.Name = "labelNCUTag";
            this.labelNCUTag.Size = new System.Drawing.Size(55, 13);
            this.labelNCUTag.TabIndex = 0;
            this.labelNCUTag.Text = "NCU Tag:";
            // 
            // tabPageView
            // 
            this.tabPageView.BackColor = System.Drawing.Color.MintCream;
            this.tabPageView.Controls.Add(this.ViewDataGrid);
            this.tabPageView.Controls.Add(this.button3);
            this.tabPageView.Controls.Add(this.TextBoxSearch);
            this.tabPageView.Controls.Add(this.labelNCUTagSearch);
            this.tabPageView.Controls.Add(this.button2);
            this.tabPageView.Location = new System.Drawing.Point(4, 22);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Size = new System.Drawing.Size(853, 550);
            this.tabPageView.TabIndex = 2;
            this.tabPageView.Text = "View";
            // 
            // ViewDataGrid
            // 
            this.ViewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDataGrid.Location = new System.Drawing.Point(24, 143);
            this.ViewDataGrid.Name = "ViewDataGrid";
            this.ViewDataGrid.Size = new System.Drawing.Size(799, 373);
            this.ViewDataGrid.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(777, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 28);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.searchHover);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(671, 87);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSearch.TabIndex = 2;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // labelNCUTagSearch
            // 
            this.labelNCUTagSearch.AutoSize = true;
            this.labelNCUTagSearch.Location = new System.Drawing.Point(610, 90);
            this.labelNCUTagSearch.Name = "labelNCUTagSearch";
            this.labelNCUTagSearch.Size = new System.Drawing.Size(55, 13);
            this.labelNCUTagSearch.TabIndex = 1;
            this.labelNCUTagSearch.Text = "NCU Tag:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "List All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.listHover);
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.BackColor = System.Drawing.Color.Azure;
            this.tabPageUpdate.Controls.Add(this.buttonUpdate);
            this.tabPageUpdate.Controls.Add(this.label3);
            this.tabPageUpdate.Controls.Add(this.TextBoxNotesUpdate);
            this.tabPageUpdate.Controls.Add(this.label9);
            this.tabPageUpdate.Controls.Add(this.TextBoxStatusUpdate);
            this.tabPageUpdate.Controls.Add(this.TextBoxLocationUpdate);
            this.tabPageUpdate.Controls.Add(this.TextBoxServiceTagUpdate);
            this.tabPageUpdate.Controls.Add(this.TextBoxSerialNumberUpdate);
            this.tabPageUpdate.Controls.Add(this.TextBoxModelUpdate);
            this.tabPageUpdate.Controls.Add(this.TextBoxManufacturerUpdate);
            this.tabPageUpdate.Controls.Add(this.TextBoxQuantityUpdate);
            this.tabPageUpdate.Controls.Add(this.TextBoxItemTypeUpdate);
            this.tabPageUpdate.Controls.Add(this.TextBoxNCUTagUpdate);
            this.tabPageUpdate.Controls.Add(this.label10);
            this.tabPageUpdate.Controls.Add(this.label11);
            this.tabPageUpdate.Controls.Add(this.label12);
            this.tabPageUpdate.Controls.Add(this.label13);
            this.tabPageUpdate.Controls.Add(this.label14);
            this.tabPageUpdate.Controls.Add(this.label15);
            this.tabPageUpdate.Controls.Add(this.label16);
            this.tabPageUpdate.Controls.Add(this.label17);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Size = new System.Drawing.Size(853, 550);
            this.tabPageUpdate.TabIndex = 3;
            this.tabPageUpdate.Text = "Update";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.Location = new System.Drawing.Point(389, 499);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(56, 39);
            this.buttonUpdate.TabIndex = 41;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            this.buttonUpdate.MouseHover += new System.EventHandler(this.updateHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Notes:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TextBoxNotesUpdate
            // 
            this.TextBoxNotesUpdate.Location = new System.Drawing.Point(372, 454);
            this.TextBoxNotesUpdate.Name = "TextBoxNotesUpdate";
            this.TextBoxNotesUpdate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNotesUpdate.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Status:";
            // 
            // TextBoxStatusUpdate
            // 
            this.TextBoxStatusUpdate.Location = new System.Drawing.Point(374, 408);
            this.TextBoxStatusUpdate.Name = "TextBoxStatusUpdate";
            this.TextBoxStatusUpdate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxStatusUpdate.TabIndex = 37;
            // 
            // TextBoxLocationUpdate
            // 
            this.TextBoxLocationUpdate.Location = new System.Drawing.Point(372, 366);
            this.TextBoxLocationUpdate.Name = "TextBoxLocationUpdate";
            this.TextBoxLocationUpdate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLocationUpdate.TabIndex = 36;
            // 
            // TextBoxServiceTagUpdate
            // 
            this.TextBoxServiceTagUpdate.Location = new System.Drawing.Point(374, 326);
            this.TextBoxServiceTagUpdate.Name = "TextBoxServiceTagUpdate";
            this.TextBoxServiceTagUpdate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxServiceTagUpdate.TabIndex = 35;
            // 
            // TextBoxSerialNumberUpdate
            // 
            this.TextBoxSerialNumberUpdate.Location = new System.Drawing.Point(374, 279);
            this.TextBoxSerialNumberUpdate.Name = "TextBoxSerialNumberUpdate";
            this.TextBoxSerialNumberUpdate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSerialNumberUpdate.TabIndex = 34;
            // 
            // TextBoxModelUpdate
            // 
            this.TextBoxModelUpdate.Location = new System.Drawing.Point(372, 236);
            this.TextBoxModelUpdate.Name = "TextBoxModelUpdate";
            this.TextBoxModelUpdate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxModelUpdate.TabIndex = 33;
            // 
            // TextBoxManufacturerUpdate
            // 
            this.TextBoxManufacturerUpdate.Location = new System.Drawing.Point(374, 186);
            this.TextBoxManufacturerUpdate.Name = "TextBoxManufacturerUpdate";
            this.TextBoxManufacturerUpdate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxManufacturerUpdate.TabIndex = 32;
            // 
            // TextBoxQuantityUpdate
            // 
            this.TextBoxQuantityUpdate.Location = new System.Drawing.Point(372, 142);
            this.TextBoxQuantityUpdate.Name = "TextBoxQuantityUpdate";
            this.TextBoxQuantityUpdate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxQuantityUpdate.TabIndex = 31;
            // 
            // TextBoxItemTypeUpdate
            // 
            this.TextBoxItemTypeUpdate.Location = new System.Drawing.Point(374, 100);
            this.TextBoxItemTypeUpdate.Name = "TextBoxItemTypeUpdate";
            this.TextBoxItemTypeUpdate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxItemTypeUpdate.TabIndex = 30;
            // 
            // TextBoxNCUTagUpdate
            // 
            this.TextBoxNCUTagUpdate.Location = new System.Drawing.Point(374, 61);
            this.TextBoxNCUTagUpdate.Name = "TextBoxNCUTagUpdate";
            this.TextBoxNCUTagUpdate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNCUTagUpdate.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Location:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Service Tag:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(298, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Serial Number:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(298, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Model:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(298, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Manufacturer:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(298, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Quantity:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(297, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Item Type;";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(296, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "NCU Tag:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPageDelete.Controls.Add(this.label18);
            this.tabPageDelete.Controls.Add(this.TextBoxRecordTag);
            this.tabPageDelete.Controls.Add(this.ButtonDelete);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(853, 550);
            this.tabPageDelete.TabIndex = 4;
            this.tabPageDelete.Text = "Delete";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(312, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "NCU Tag:";
            // 
            // TextBoxRecordTag
            // 
            this.TextBoxRecordTag.Location = new System.Drawing.Point(395, 113);
            this.TextBoxRecordTag.Name = "TextBoxRecordTag";
            this.TextBoxRecordTag.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRecordTag.TabIndex = 1;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.Location = new System.Drawing.Point(420, 167);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(40, 33);
            this.ButtonDelete.TabIndex = 0;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            this.ButtonDelete.MouseHover += new System.EventHandler(this.deleteHover);
            // 
            // baseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(885, 600);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "baseForm";
            this.Text = "LINQAssignment";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageCreate.ResumeLayout(false);
            this.tabPageCreate.PerformLayout();
            this.tabPageView.ResumeLayout(false);
            this.tabPageView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataGrid)).EndInit();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageWelcome;
        private System.Windows.Forms.TabPage tabPageCreate;
        private System.Windows.Forms.Label labelNCUTag;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelItemType;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox TextBoxLocation;
        private System.Windows.Forms.TextBox TextBoxServiceTag;
        private System.Windows.Forms.TextBox TextBoxSerial;
        private System.Windows.Forms.TextBox TextBoxModel;
        private System.Windows.Forms.TextBox TextBoxManufacturer;
        private System.Windows.Forms.TextBox TextBoxQuantity;
        private System.Windows.Forms.TextBox TextBoxItemType;
        private System.Windows.Forms.TextBox TextBoxNCUTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxNotes;
        private System.Windows.Forms.DataGridView ViewDataGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label labelNCUTagSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxNotesUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxStatusUpdate;
        private System.Windows.Forms.TextBox TextBoxLocationUpdate;
        private System.Windows.Forms.TextBox TextBoxServiceTagUpdate;
        private System.Windows.Forms.TextBox TextBoxSerialNumberUpdate;
        private System.Windows.Forms.TextBox TextBoxModelUpdate;
        private System.Windows.Forms.TextBox TextBoxManufacturerUpdate;
        private System.Windows.Forms.TextBox TextBoxQuantityUpdate;
        private System.Windows.Forms.TextBox TextBoxItemTypeUpdate;
        private System.Windows.Forms.TextBox TextBoxNCUTagUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TextBoxRecordTag;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

