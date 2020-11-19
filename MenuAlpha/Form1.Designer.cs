namespace MenuAlpha
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSet1 = new MenuAlpha.DataSet1();
            this.markaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.markaTableAdapter = new MenuAlpha.DataSet1TableAdapters.MarkaTableAdapter();
            this.tableAdapterManager = new MenuAlpha.DataSet1TableAdapters.TableAdapterManager();
            this.modelTableAdapter = new MenuAlpha.DataSet1TableAdapters.ModelTableAdapter();
            this.markaBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.markaBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btndodaj = new System.Windows.Forms.Button();
            this.database1DataSet = new MenuAlpha.Database1DataSet();
            this.markaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.markaTableAdapter1 = new MenuAlpha.Database1DataSetTableAdapters.MarkaTableAdapter();
            this.tableAdapterManager1 = new MenuAlpha.Database1DataSetTableAdapters.TableAdapterManager();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnzapisz = new System.Windows.Forms.Button();
            this.tytul = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.anuluj = new System.Windows.Forms.Button();
            this.btnNTR = new System.Windows.Forms.Button();
            this.btnNM = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tytul2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource1BindingNavigator)).BeginInit();
            this.markaBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Orange;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(57, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Typ robota";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markaBindingSource1
            // 
            this.markaBindingSource1.DataMember = "Marka";
            this.markaBindingSource1.DataSource = this.dataSet1;
            // 
            // markaTableAdapter
            // 
            this.markaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MarkaTableAdapter = this.markaTableAdapter;
            this.tableAdapterManager.ModelTableAdapter = this.modelTableAdapter;
            this.tableAdapterManager.TypTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MenuAlpha.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // markaBindingSource1BindingNavigator
            // 
            this.markaBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.markaBindingSource1BindingNavigator.BindingSource = this.markaBindingSource1;
            this.markaBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.markaBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.markaBindingSource1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.markaBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.markaBindingSource1BindingNavigatorSaveItem});
            this.markaBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.markaBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.markaBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.markaBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.markaBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.markaBindingSource1BindingNavigator.Name = "markaBindingSource1BindingNavigator";
            this.markaBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.markaBindingSource1BindingNavigator.Size = new System.Drawing.Size(626, 25);
            this.markaBindingSource1BindingNavigator.TabIndex = 12;
            this.markaBindingSource1BindingNavigator.Text = "bindingNavigator1";
            this.markaBindingSource1BindingNavigator.Visible = false;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton6.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // markaBindingSource1BindingNavigatorSaveItem
            // 
            this.markaBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.markaBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("markaBindingSource1BindingNavigatorSaveItem.Image")));
            this.markaBindingSource1BindingNavigatorSaveItem.Name = "markaBindingSource1BindingNavigatorSaveItem";
            this.markaBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 22);
            this.markaBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.markaBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.markaBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.dataSet1;
            // 
            // btndodaj
            // 
            this.btndodaj.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndodaj.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndodaj.ForeColor = System.Drawing.Color.DarkOrange;
            this.btndodaj.Location = new System.Drawing.Point(428, 299);
            this.btndodaj.Margin = new System.Windows.Forms.Padding(0);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(164, 38);
            this.btndodaj.TabIndex = 14;
            this.btndodaj.Text = "Dodaj robota";
            this.btndodaj.UseVisualStyleBackColor = false;
            this.btndodaj.Click += new System.EventHandler(this.btndodaj_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markaBindingSource2
            // 
            this.markaBindingSource2.DataMember = "Marka";
            this.markaBindingSource2.DataSource = this.database1DataSet;
            // 
            // markaTableAdapter1
            // 
            this.markaTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.MarkaAllTableAdapter = null;
            this.tableAdapterManager1.MarkaTableAdapter = this.markaTableAdapter1;
            this.tableAdapterManager1.ModelTableAdapter = null;
            this.tableAdapterManager1.TypAllTableAdapter = null;
            this.tableAdapterManager1.TypTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = MenuAlpha.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Orange;
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(232, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 24);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.Orange;
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(428, 147);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(164, 24);
            this.comboBox3.TabIndex = 16;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.Orange;
            this.comboBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox4.ForeColor = System.Drawing.Color.Black;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(34, 147);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(164, 24);
            this.comboBox4.TabIndex = 17;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.Orange;
            this.comboBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox5.ForeColor = System.Drawing.Color.Black;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(232, 147);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(164, 24);
            this.comboBox5.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(428, 147);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 24);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(282, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(481, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Model";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(232, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Wybierz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnzapisz
            // 
            this.btnzapisz.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnzapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnzapisz.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzapisz.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnzapisz.Location = new System.Drawing.Point(125, 194);
            this.btnzapisz.Margin = new System.Windows.Forms.Padding(0);
            this.btnzapisz.Name = "btnzapisz";
            this.btnzapisz.Size = new System.Drawing.Size(164, 38);
            this.btnzapisz.TabIndex = 24;
            this.btnzapisz.Text = "Zapisz";
            this.btnzapisz.UseVisualStyleBackColor = false;
            this.btnzapisz.Click += new System.EventHandler(this.btnzapisz_Click_1);
            // 
            // tytul
            // 
            this.tytul.BackColor = System.Drawing.Color.Black;
            this.tytul.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul.ForeColor = System.Drawing.Color.DarkOrange;
            this.tytul.Location = new System.Drawing.Point(125, 53);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(385, 35);
            this.tytul.TabIndex = 25;
            this.tytul.Text = "Wybierz robota";
            this.tytul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Black;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.ForeColor = System.Drawing.Color.Orange;
            this.close.Location = new System.Drawing.Point(586, 0);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 35);
            this.close.TabIndex = 26;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Black;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimize.ForeColor = System.Drawing.Color.Orange;
            this.minimize.Location = new System.Drawing.Point(546, 0);
            this.minimize.Margin = new System.Windows.Forms.Padding(0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(40, 35);
            this.minimize.TabIndex = 27;
            this.minimize.Text = "-";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // anuluj
            // 
            this.anuluj.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.anuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anuluj.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anuluj.ForeColor = System.Drawing.Color.DarkOrange;
            this.anuluj.Location = new System.Drawing.Point(346, 194);
            this.anuluj.Margin = new System.Windows.Forms.Padding(0);
            this.anuluj.Name = "anuluj";
            this.anuluj.Size = new System.Drawing.Size(164, 38);
            this.anuluj.TabIndex = 28;
            this.anuluj.Text = "Anuluj";
            this.anuluj.UseVisualStyleBackColor = false;
            this.anuluj.Click += new System.EventHandler(this.anuluj_Click);
            // 
            // btnNTR
            // 
            this.btnNTR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNTR.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNTR.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnNTR.Location = new System.Drawing.Point(304, 288);
            this.btnNTR.Margin = new System.Windows.Forms.Padding(0);
            this.btnNTR.Name = "btnNTR";
            this.btnNTR.Size = new System.Drawing.Size(124, 61);
            this.btnNTR.TabIndex = 29;
            this.btnNTR.Text = "Nowy typ robota";
            this.btnNTR.UseVisualStyleBackColor = false;
            this.btnNTR.Click += new System.EventHandler(this.btnNTR_Click);
            // 
            // btnNM
            // 
            this.btnNM.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNM.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNM.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnNM.Location = new System.Drawing.Point(468, 288);
            this.btnNM.Margin = new System.Windows.Forms.Padding(0);
            this.btnNM.Name = "btnNM";
            this.btnNM.Size = new System.Drawing.Size(124, 61);
            this.btnNM.TabIndex = 30;
            this.btnNM.Text = "nowa marka";
            this.btnNM.UseVisualStyleBackColor = false;
            this.btnNM.Click += new System.EventHandler(this.btnNM_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(232, 147);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 24);
            this.textBox2.TabIndex = 31;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tytul2
            // 
            this.tytul2.BackColor = System.Drawing.Color.Black;
            this.tytul2.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul2.ForeColor = System.Drawing.Color.DarkOrange;
            this.tytul2.Location = new System.Drawing.Point(125, 53);
            this.tytul2.Name = "tytul2";
            this.tytul2.Size = new System.Drawing.Size(385, 35);
            this.tytul2.TabIndex = 32;
            this.tytul2.Text = "Nowa marka robota";
            this.tytul2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 356);
            this.Controls.Add(this.tytul2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnNM);
            this.Controls.Add(this.btnNTR);
            this.Controls.Add(this.anuluj);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.btnzapisz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.markaBindingSource1BindingNavigator);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RobotMenu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource1BindingNavigator)).EndInit();
            this.markaBindingSource1BindingNavigator.ResumeLayout(false);
            this.markaBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label label3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource markaBindingSource1;
        private DataSet1TableAdapters.MarkaTableAdapter markaTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator markaBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton markaBindingSource1BindingNavigatorSaveItem;
        private DataSet1TableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.Button btndodaj;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource markaBindingSource2;
        private Database1DataSetTableAdapters.MarkaTableAdapter markaTableAdapter1;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnzapisz;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button anuluj;
        private System.Windows.Forms.Button btnNTR;
        private System.Windows.Forms.Button btnNM;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label tytul2;
    }
}

