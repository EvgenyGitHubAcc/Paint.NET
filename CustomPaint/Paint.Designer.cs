namespace CustomPaint
{
    partial class Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolbar_panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2_Color2 = new System.Windows.Forms.PictureBox();
            this.label2_Color2 = new System.Windows.Forms.Label();
            this.pictureBox1_Color1 = new System.Windows.Forms.PictureBox();
            this.label1_Color1 = new System.Windows.Forms.Label();
            this.rightToolbar_panel = new System.Windows.Forms.Panel();
            this.Size_Line = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1_Text = new System.Windows.Forms.RadioButton();
            this.Eraser_button = new System.Windows.Forms.RadioButton();
            this.button2_Line = new System.Windows.Forms.RadioButton();
            this.button3_Pryamougolnik = new System.Windows.Forms.RadioButton();
            this.button4_Oval = new System.Windows.Forms.RadioButton();
            this.Fill_Button = new System.Windows.Forms.CheckBox();
            this.Paint_panel = new System.Windows.Forms.Panel();
            this.Enter_text_Form = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.leftToolbar_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_Color2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Color1)).BeginInit();
            this.rightToolbar_panel.SuspendLayout();
            this.Size_Line.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Paint_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.unDoToolStripMenuItem,
            this.reDoToolStripMenuItem,
            this.colorMapToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1335, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.printToolStripMenuItem,
            this.toolStripSeparator3,
            this.exportToolStripMenuItem,
            this.toolStripSeparator4,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exportToolStripMenuItem.Text = "Export image...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // unDoToolStripMenuItem
            // 
            this.unDoToolStripMenuItem.Name = "unDoToolStripMenuItem";
            this.unDoToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.unDoToolStripMenuItem.Text = "&UnDo";
            this.unDoToolStripMenuItem.Click += new System.EventHandler(this.unDoToolStripMenuItem_Click);
            // 
            // reDoToolStripMenuItem
            // 
            this.reDoToolStripMenuItem.Name = "reDoToolStripMenuItem";
            this.reDoToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.reDoToolStripMenuItem.Text = "&ReDo";
            this.reDoToolStripMenuItem.Click += new System.EventHandler(this.reDoToolStripMenuItem_Click);
            // 
            // colorMapToolStripMenuItem
            // 
            this.colorMapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorDrawToolStripMenuItem,
            this.colorFillToolStripMenuItem});
            this.colorMapToolStripMenuItem.Name = "colorMapToolStripMenuItem";
            this.colorMapToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.colorMapToolStripMenuItem.Text = "C&olor map";
            // 
            // colorDrawToolStripMenuItem
            // 
            this.colorDrawToolStripMenuItem.Name = "colorDrawToolStripMenuItem";
            this.colorDrawToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.colorDrawToolStripMenuItem.Text = "Color Draw";
            this.colorDrawToolStripMenuItem.Click += new System.EventHandler(this.colorDrawToolStripMenuItem_Click);
            // 
            // colorFillToolStripMenuItem
            // 
            this.colorFillToolStripMenuItem.Name = "colorFillToolStripMenuItem";
            this.colorFillToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.colorFillToolStripMenuItem.Text = "Color Fill";
            this.colorFillToolStripMenuItem.Click += new System.EventHandler(this.colorFillToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // leftToolbar_panel1
            // 
            this.leftToolbar_panel1.Controls.Add(this.pictureBox2_Color2);
            this.leftToolbar_panel1.Controls.Add(this.label2_Color2);
            this.leftToolbar_panel1.Controls.Add(this.pictureBox1_Color1);
            this.leftToolbar_panel1.Controls.Add(this.label1_Color1);
            this.leftToolbar_panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftToolbar_panel1.Location = new System.Drawing.Point(0, 28);
            this.leftToolbar_panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftToolbar_panel1.Name = "leftToolbar_panel1";
            this.leftToolbar_panel1.Size = new System.Drawing.Size(69, 751);
            this.leftToolbar_panel1.TabIndex = 1;
            // 
            // pictureBox2_Color2
            // 
            this.pictureBox2_Color2.Location = new System.Drawing.Point(9, 73);
            this.pictureBox2_Color2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2_Color2.Name = "pictureBox2_Color2";
            this.pictureBox2_Color2.Size = new System.Drawing.Size(31, 25);
            this.pictureBox2_Color2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2_Color2.TabIndex = 3;
            this.pictureBox2_Color2.TabStop = false;
            // 
            // label2_Color2
            // 
            this.label2_Color2.AutoSize = true;
            this.label2_Color2.Location = new System.Drawing.Point(5, 53);
            this.label2_Color2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2_Color2.Name = "label2_Color2";
            this.label2_Color2.Size = new System.Drawing.Size(29, 17);
            this.label2_Color2.TabIndex = 3;
            this.label2_Color2.Text = "F&ill ";
            this.label2_Color2.Click += new System.EventHandler(this.label2_Color2_Click);
            // 
            // pictureBox1_Color1
            // 
            this.pictureBox1_Color1.Location = new System.Drawing.Point(9, 25);
            this.pictureBox1_Color1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1_Color1.Name = "pictureBox1_Color1";
            this.pictureBox1_Color1.Size = new System.Drawing.Size(31, 25);
            this.pictureBox1_Color1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_Color1.TabIndex = 1;
            this.pictureBox1_Color1.TabStop = false;
            // 
            // label1_Color1
            // 
            this.label1_Color1.AutoSize = true;
            this.label1_Color1.Location = new System.Drawing.Point(5, 5);
            this.label1_Color1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_Color1.Name = "label1_Color1";
            this.label1_Color1.Size = new System.Drawing.Size(40, 17);
            this.label1_Color1.TabIndex = 2;
            this.label1_Color1.Text = "&Draw";
            this.label1_Color1.Click += new System.EventHandler(this.label1_Color1_Click);
            // 
            // rightToolbar_panel
            // 
            this.rightToolbar_panel.Controls.Add(this.Size_Line);
            this.rightToolbar_panel.Controls.Add(this.tableLayoutPanel1);
            this.rightToolbar_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightToolbar_panel.Location = new System.Drawing.Point(1226, 28);
            this.rightToolbar_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightToolbar_panel.Name = "rightToolbar_panel";
            this.rightToolbar_panel.Size = new System.Drawing.Size(109, 751);
            this.rightToolbar_panel.TabIndex = 4;
            // 
            // Size_Line
            // 
            this.Size_Line.Controls.Add(this.comboBox1);
            this.Size_Line.Location = new System.Drawing.Point(12, 148);
            this.Size_Line.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Size_Line.Name = "Size_Line";
            this.Size_Line.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Size_Line.Size = new System.Drawing.Size(85, 54);
            this.Size_Line.TabIndex = 12;
            this.Size_Line.TabStop = false;
            this.Size_Line.Text = "&Size Line";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(8, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "2";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1_Text, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Eraser_button, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2_Line, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3_Pryamougolnik, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4_Oval, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Fill_Button, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.40741F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.18518F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(89, 135);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // button1_Text
            // 
            this.button1_Text.Appearance = System.Windows.Forms.Appearance.Button;
            this.button1_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1_Text.Location = new System.Drawing.Point(4, 4);
            this.button1_Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1_Text.Name = "button1_Text";
            this.button1_Text.Size = new System.Drawing.Size(36, 36);
            this.button1_Text.TabIndex = 6;
            this.button1_Text.Text = "&A";
            this.button1_Text.UseVisualStyleBackColor = true;
            this.button1_Text.Click += new System.EventHandler(this.button1_Text_Click);
            // 
            // Eraser_button
            // 
            this.Eraser_button.Appearance = System.Windows.Forms.Appearance.Button;
            this.Eraser_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eraser_button.BackgroundImage")));
            this.Eraser_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Eraser_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eraser_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eraser_button.Location = new System.Drawing.Point(48, 91);
            this.Eraser_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Eraser_button.Name = "Eraser_button";
            this.Eraser_button.Size = new System.Drawing.Size(37, 40);
            this.Eraser_button.TabIndex = 11;
            this.Eraser_button.UseVisualStyleBackColor = true;
            this.Eraser_button.Click += new System.EventHandler(this.Eraser_button_Click);
            // 
            // button2_Line
            // 
            this.button2_Line.Appearance = System.Windows.Forms.Appearance.Button;
            this.button2_Line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2_Line.BackgroundImage")));
            this.button2_Line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2_Line.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2_Line.Location = new System.Drawing.Point(48, 4);
            this.button2_Line.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2_Line.Name = "button2_Line";
            this.button2_Line.Size = new System.Drawing.Size(37, 36);
            this.button2_Line.TabIndex = 7;
            this.button2_Line.UseVisualStyleBackColor = true;
            this.button2_Line.Click += new System.EventHandler(this.button2_Line_Click);
            // 
            // button3_Pryamougolnik
            // 
            this.button3_Pryamougolnik.Appearance = System.Windows.Forms.Appearance.Button;
            this.button3_Pryamougolnik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3_Pryamougolnik.BackgroundImage")));
            this.button3_Pryamougolnik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3_Pryamougolnik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3_Pryamougolnik.Location = new System.Drawing.Point(4, 48);
            this.button3_Pryamougolnik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3_Pryamougolnik.Name = "button3_Pryamougolnik";
            this.button3_Pryamougolnik.Size = new System.Drawing.Size(36, 35);
            this.button3_Pryamougolnik.TabIndex = 8;
            this.button3_Pryamougolnik.UseVisualStyleBackColor = true;
            this.button3_Pryamougolnik.Click += new System.EventHandler(this.button3_Pryamougolnik_Click);
            // 
            // button4_Oval
            // 
            this.button4_Oval.Appearance = System.Windows.Forms.Appearance.Button;
            this.button4_Oval.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4_Oval.BackgroundImage")));
            this.button4_Oval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4_Oval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4_Oval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4_Oval.Location = new System.Drawing.Point(48, 48);
            this.button4_Oval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4_Oval.Name = "button4_Oval";
            this.button4_Oval.Size = new System.Drawing.Size(37, 35);
            this.button4_Oval.TabIndex = 9;
            this.button4_Oval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4_Oval.UseVisualStyleBackColor = true;
            this.button4_Oval.Click += new System.EventHandler(this.button4_Oval_Click);
            // 
            // Fill_Button
            // 
            this.Fill_Button.Appearance = System.Windows.Forms.Appearance.Button;
            this.Fill_Button.AutoSize = true;
            this.Fill_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fill_Button.Location = new System.Drawing.Point(4, 91);
            this.Fill_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fill_Button.Name = "Fill_Button";
            this.Fill_Button.Size = new System.Drawing.Size(36, 40);
            this.Fill_Button.TabIndex = 10;
            this.Fill_Button.Text = "Fill";
            this.Fill_Button.UseVisualStyleBackColor = true;
            // 
            // Paint_panel
            // 
            this.Paint_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Paint_panel.Controls.Add(this.Enter_text_Form);
            this.Paint_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Paint_panel.Location = new System.Drawing.Point(69, 28);
            this.Paint_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Paint_panel.Name = "Paint_panel";
            this.Paint_panel.Size = new System.Drawing.Size(1157, 751);
            this.Paint_panel.TabIndex = 14;
            this.Paint_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_panel_Paint);
            this.Paint_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paint_panel_MouseDown);
            this.Paint_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Paint_panel_MouseMove);
            this.Paint_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paint_panel_MouseUp);
            // 
            // Enter_text_Form
            // 
            this.Enter_text_Form.Location = new System.Drawing.Point(8, 686);
            this.Enter_text_Form.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Enter_text_Form.Name = "Enter_text_Form";
            this.Enter_text_Form.Size = new System.Drawing.Size(481, 22);
            this.Enter_text_Form.TabIndex = 4;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(213, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(213, 6);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 779);
            this.Controls.Add(this.Paint_panel);
            this.Controls.Add(this.rightToolbar_panel);
            this.Controls.Add(this.leftToolbar_panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Paint";
            this.Text = "Paint_Cust";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.leftToolbar_panel1.ResumeLayout(false);
            this.leftToolbar_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_Color2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Color1)).EndInit();
            this.rightToolbar_panel.ResumeLayout(false);
            this.Size_Line.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Paint_panel.ResumeLayout(false);
            this.Paint_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.Panel leftToolbar_panel1;
        private System.Windows.Forms.Panel rightToolbar_panel;
        private System.Windows.Forms.Panel Paint_panel;
        private System.Windows.Forms.PictureBox pictureBox2_Color2;
        private System.Windows.Forms.Label label2_Color2;
        private System.Windows.Forms.PictureBox pictureBox1_Color1;
        private System.Windows.Forms.Label label1_Color1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton button1_Text;
        private System.Windows.Forms.RadioButton button2_Line;
        private System.Windows.Forms.RadioButton button3_Pryamougolnik;
        private System.Windows.Forms.RadioButton button4_Oval;
        private System.Windows.Forms.GroupBox Size_Line;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RadioButton Eraser_button;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem colorDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.CheckBox Fill_Button;
        private System.Windows.Forms.TextBox Enter_text_Form;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

