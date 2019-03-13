using System;

namespace WindowsFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPizza = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBxPizzaQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBxOnions = new System.Windows.Forms.CheckBox();
            this.chkBxJal = new System.Windows.Forms.CheckBox();
            this.chkBxMush = new System.Windows.Forms.CheckBox();
            this.chkBxOlives = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBxSize = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddOns = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBxSoda = new System.Windows.Forms.TextBox();
            this.txtBxWater = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstBxSpecialityItems = new System.Windows.Forms.ListBox();
            this.tbFinal = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBxTotal = new System.Windows.Forms.ListBox();
            this.lstBxOrderReceipt = new System.Windows.Forms.ListBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbPizza.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbAddOns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tbFinal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbPizza);
            this.tabControl1.Controls.Add(this.tbAddOns);
            this.tabControl1.Controls.Add(this.tbFinal);
            this.tabControl1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPizza
            // 
            this.tbPizza.BackColor = System.Drawing.Color.Transparent;
            this.tbPizza.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.tracks;
            this.tbPizza.Controls.Add(this.label13);
            this.tbPizza.Controls.Add(this.label12);
            this.tbPizza.Controls.Add(this.label1);
            this.tbPizza.Controls.Add(this.panel1);
            this.tbPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPizza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbPizza.Location = new System.Drawing.Point(4, 32);
            this.tbPizza.Name = "tbPizza";
            this.tbPizza.Padding = new System.Windows.Forms.Padding(3);
            this.tbPizza.Size = new System.Drawing.Size(768, 364);
            this.tbPizza.TabIndex = 0;
            this.tbPizza.Text = "Select Pizza";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(100, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 23);
            this.label13.TabIndex = 2;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Welcome !";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(267, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAKE MY PIZZA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtBxPizzaQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 284);
            this.panel1.TabIndex = 0;
            // 
            // txtBxPizzaQty
            // 
            this.txtBxPizzaQty.Location = new System.Drawing.Point(137, 228);
            this.txtBxPizzaQty.Name = "txtBxPizzaQty";
            this.txtBxPizzaQty.Size = new System.Drawing.Size(54, 22);
            this.txtBxPizzaQty.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(42, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkBxOnions);
            this.groupBox3.Controls.Add(this.chkBxJal);
            this.groupBox3.Controls.Add(this.chkBxMush);
            this.groupBox3.Controls.Add(this.chkBxOlives);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(486, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 201);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppinggs @ $1.5 ea";
            // 
            // chkBxOnions
            // 
            this.chkBxOnions.AutoSize = true;
            this.chkBxOnions.Location = new System.Drawing.Point(24, 122);
            this.chkBxOnions.Name = "chkBxOnions";
            this.chkBxOnions.Size = new System.Drawing.Size(83, 27);
            this.chkBxOnions.TabIndex = 0;
            this.chkBxOnions.Text = "Onions";
            this.chkBxOnions.UseVisualStyleBackColor = true;
            // 
            // chkBxJal
            // 
            this.chkBxJal.AutoSize = true;
            this.chkBxJal.Location = new System.Drawing.Point(24, 94);
            this.chkBxJal.Name = "chkBxJal";
            this.chkBxJal.Size = new System.Drawing.Size(119, 27);
            this.chkBxJal.TabIndex = 0;
            this.chkBxJal.Text = "Jalapenoes";
            this.chkBxJal.UseVisualStyleBackColor = true;
            // 
            // chkBxMush
            // 
            this.chkBxMush.AutoSize = true;
            this.chkBxMush.Location = new System.Drawing.Point(24, 70);
            this.chkBxMush.Name = "chkBxMush";
            this.chkBxMush.Size = new System.Drawing.Size(123, 27);
            this.chkBxMush.TabIndex = 0;
            this.chkBxMush.Text = "Mushrooms";
            this.chkBxMush.UseVisualStyleBackColor = true;
            // 
            // chkBxOlives
            // 
            this.chkBxOlives.AutoSize = true;
            this.chkBxOlives.Location = new System.Drawing.Point(24, 42);
            this.chkBxOlives.Name = "chkBxOlives";
            this.chkBxOlives.Size = new System.Drawing.Size(75, 27);
            this.chkBxOlives.TabIndex = 0;
            this.chkBxOlives.Text = "Olives";
            this.chkBxOlives.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad3);
            this.groupBox2.Controls.Add(this.rad2);
            this.groupBox2.Controls.Add(this.rad1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(274, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 127);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crust";
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(21, 70);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(134, 27);
            this.rad3.TabIndex = 1;
            this.rad3.TabStop = true;
            this.rad3.Text = "Cheese Crust";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(21, 46);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(108, 27);
            this.rad2.TabIndex = 1;
            this.rad2.TabStop = true;
            this.rad2.Text = "Thin Crust";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(21, 20);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(162, 27);
            this.rad1.TabIndex = 1;
            this.rad1.TabStop = true;
            this.rad1.Text = "Classic Pan Base";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBxSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(30, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base";
            // 
            // lstBxSize
            // 
            this.lstBxSize.FormattingEnabled = true;
            this.lstBxSize.ItemHeight = 23;
            this.lstBxSize.Items.AddRange(new object[] {
            "Small - $9",
            "Medium -$12",
            "Large -$15"});
            this.lstBxSize.Location = new System.Drawing.Point(27, 59);
            this.lstBxSize.Name = "lstBxSize";
            this.lstBxSize.Size = new System.Drawing.Size(134, 27);
            this.lstBxSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Size";
            // 
            // tbAddOns
            // 
            this.tbAddOns.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbAddOns.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.tracks;
            this.tbAddOns.Controls.Add(this.pictureBox1);
            this.tbAddOns.Controls.Add(this.label7);
            this.tbAddOns.Controls.Add(this.label15);
            this.tbAddOns.Controls.Add(this.label14);
            this.tbAddOns.Controls.Add(this.groupBox4);
            this.tbAddOns.Controls.Add(this.label6);
            this.tbAddOns.Controls.Add(this.lstBxSpecialityItems);
            this.tbAddOns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddOns.Location = new System.Drawing.Point(4, 32);
            this.tbAddOns.Name = "tbAddOns";
            this.tbAddOns.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddOns.Size = new System.Drawing.Size(768, 364);
            this.tbAddOns.TabIndex = 1;
            this.tbAddOns.Text = "Add Ons";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(437, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Drink Selections";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(101, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 23);
            this.label15.TabIndex = 4;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 23);
            this.label14.TabIndex = 3;
            this.label14.Text = "Welcome !";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Olive;
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtBxSoda);
            this.groupBox4.Controls.Add(this.txtBxWater);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(304, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 269);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Beverages";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(110, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Quantity";
            // 
            // txtBxSoda
            // 
            this.txtBxSoda.Location = new System.Drawing.Point(124, 104);
            this.txtBxSoda.Name = "txtBxSoda";
            this.txtBxSoda.Size = new System.Drawing.Size(44, 31);
            this.txtBxSoda.TabIndex = 1;
            // 
            // txtBxWater
            // 
            this.txtBxWater.Location = new System.Drawing.Point(124, 58);
            this.txtBxWater.Name = "txtBxWater";
            this.txtBxWater.Size = new System.Drawing.Size(44, 31);
            this.txtBxWater.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(41, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Water";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Soda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "*Soda Cost-$ 1.75 - Water-Free";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(68, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Speciality Items";
            // 
            // lstBxSpecialityItems
            // 
            this.lstBxSpecialityItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxSpecialityItems.FormattingEnabled = true;
            this.lstBxSpecialityItems.ItemHeight = 20;
            this.lstBxSpecialityItems.Items.AddRange(new object[] {
            "Chicken Wings - $ 4.5",
            "Potato Wedges - $ 3.5"});
            this.lstBxSpecialityItems.Location = new System.Drawing.Point(53, 127);
            this.lstBxSpecialityItems.Name = "lstBxSpecialityItems";
            this.lstBxSpecialityItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBxSpecialityItems.Size = new System.Drawing.Size(173, 24);
            this.lstBxSpecialityItems.TabIndex = 0;
            // 
            // tbFinal
            // 
            this.tbFinal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbFinal.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.tracks;
            this.tbFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbFinal.Controls.Add(this.panel2);
            this.tbFinal.Location = new System.Drawing.Point(4, 32);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Padding = new System.Windows.Forms.Padding(3);
            this.tbFinal.Size = new System.Drawing.Size(768, 364);
            this.tbFinal.TabIndex = 2;
            this.tbFinal.Text = "Final Order";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Olive;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lstBxTotal);
            this.panel2.Controls.Add(this.lstBxOrderReceipt);
            this.panel2.Location = new System.Drawing.Point(35, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 353);
            this.panel2.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(99, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 29);
            this.label17.TabIndex = 6;
            this.label17.Text = "label17";
            this.label17.UseCompatibleTextRendering = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(353, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "Welcome !";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Order Details";
            // 
            // lstBxTotal
            // 
            this.lstBxTotal.FormattingEnabled = true;
            this.lstBxTotal.ItemHeight = 20;
            this.lstBxTotal.Location = new System.Drawing.Point(44, 246);
            this.lstBxTotal.Name = "lstBxTotal";
            this.lstBxTotal.Size = new System.Drawing.Size(571, 84);
            this.lstBxTotal.TabIndex = 1;
            // 
            // lstBxOrderReceipt
            // 
            this.lstBxOrderReceipt.FormattingEnabled = true;
            this.lstBxOrderReceipt.ItemHeight = 20;
            this.lstBxOrderReceipt.Location = new System.Drawing.Point(44, 69);
            this.lstBxOrderReceipt.Name = "lstBxOrderReceipt";
            this.lstBxOrderReceipt.Size = new System.Drawing.Size(571, 144);
            this.lstBxOrderReceipt.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnPlaceOrder.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPlaceOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(69, 418);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(152, 29);
            this.btnPlaceOrder.TabIndex = 1;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(649, 416);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 31);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(372, 417);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 31);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MY PIZZA CENTRE";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbPizza.ResumeLayout(false);
            this.tbPizza.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbAddOns.ResumeLayout(false);
            this.tbAddOns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tbFinal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        

       
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPizza;
        private System.Windows.Forms.TabPage tbAddOns;
        private System.Windows.Forms.TabPage tbFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBxPizzaQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkBxOnions;
        private System.Windows.Forms.CheckBox chkBxJal;
        private System.Windows.Forms.CheckBox chkBxMush;
        private System.Windows.Forms.CheckBox chkBxOlives;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBxSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBxSoda;
        private System.Windows.Forms.TextBox txtBxWater;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstBxSpecialityItems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstBxTotal;
        private System.Windows.Forms.ListBox lstBxOrderReceipt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
    }
}
#endregion
