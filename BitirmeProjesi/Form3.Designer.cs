namespace BitirmeProjesi
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmmenu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmptsize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmdrink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmdrinksize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmsnack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmbalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chck_pesto = new System.Windows.Forms.CheckBox();
            this.chck_aci = new System.Windows.Forms.CheckBox();
            this.chck_hardal = new System.Windows.Forms.CheckBox();
            this.chck_sarimsak = new System.Windows.Forms.CheckBox();
            this.chck_bbq = new System.Windows.Forms.CheckBox();
            this.chck_ranch = new System.Windows.Forms.CheckBox();
            this.cmb_snack = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_drink_size = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_drinks = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_potato_size = new System.Windows.Forms.ComboBox();
            this.cmb_menu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_order);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmb_snack);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_drink_size);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_drinks);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_potato_size);
            this.groupBox1.Controls.Add(this.cmb_menu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmmenu,
            this.clmptsize,
            this.clmdrink,
            this.clmdrinksize,
            this.clmsnack,
            this.clmbalance});
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 173);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(545, 154);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // clmmenu
            // 
            this.clmmenu.Text = "Menu";
            // 
            // clmptsize
            // 
            this.clmptsize.Text = "Patates Boyutu";
            this.clmptsize.Width = 89;
            // 
            // clmdrink
            // 
            this.clmdrink.Text = "İçecek";
            // 
            // clmdrinksize
            // 
            this.clmdrinksize.Text = "İçecek Boyutu";
            this.clmdrinksize.Width = 83;
            // 
            // clmsnack
            // 
            this.clmsnack.Text = "Atıştırmalık";
            // 
            // clmbalance
            // 
            this.clmbalance.Text = "Tutar";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(289, 333);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 40);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "İptal";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(386, 333);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(91, 40);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(483, 333);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(91, 40);
            this.btn_order.TabIndex = 12;
            this.btn_order.Text = "Sipariş Oluştur";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chck_pesto);
            this.groupBox2.Controls.Add(this.chck_aci);
            this.groupBox2.Controls.Add(this.chck_hardal);
            this.groupBox2.Controls.Add(this.chck_sarimsak);
            this.groupBox2.Controls.Add(this.chck_bbq);
            this.groupBox2.Controls.Add(this.chck_ranch);
            this.groupBox2.Location = new System.Drawing.Point(376, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 132);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekstra Soslar";
            // 
            // chck_pesto
            // 
            this.chck_pesto.AutoSize = true;
            this.chck_pesto.Location = new System.Drawing.Point(107, 84);
            this.chck_pesto.Name = "chck_pesto";
            this.chck_pesto.Size = new System.Drawing.Size(74, 17);
            this.chck_pesto.TabIndex = 5;
            this.chck_pesto.Text = "Pesto Sos";
            this.chck_pesto.UseVisualStyleBackColor = true;
            // 
            // chck_aci
            // 
            this.chck_aci.AutoSize = true;
            this.chck_aci.Location = new System.Drawing.Point(107, 61);
            this.chck_aci.Name = "chck_aci";
            this.chck_aci.Size = new System.Drawing.Size(62, 17);
            this.chck_aci.TabIndex = 4;
            this.chck_aci.Text = "Acı Sos";
            this.chck_aci.UseVisualStyleBackColor = true;
            // 
            // chck_hardal
            // 
            this.chck_hardal.AutoSize = true;
            this.chck_hardal.Location = new System.Drawing.Point(107, 39);
            this.chck_hardal.Name = "chck_hardal";
            this.chck_hardal.Size = new System.Drawing.Size(57, 17);
            this.chck_hardal.TabIndex = 3;
            this.chck_hardal.Text = "Hardal";
            this.chck_hardal.UseVisualStyleBackColor = true;
            // 
            // chck_sarimsak
            // 
            this.chck_sarimsak.AutoSize = true;
            this.chck_sarimsak.Location = new System.Drawing.Point(21, 84);
            this.chck_sarimsak.Name = "chck_sarimsak";
            this.chck_sarimsak.Size = new System.Drawing.Size(90, 17);
            this.chck_sarimsak.TabIndex = 2;
            this.chck_sarimsak.Text = "Sarımsak Sos";
            this.chck_sarimsak.UseVisualStyleBackColor = true;
            // 
            // chck_bbq
            // 
            this.chck_bbq.AutoSize = true;
            this.chck_bbq.Location = new System.Drawing.Point(21, 61);
            this.chck_bbq.Name = "chck_bbq";
            this.chck_bbq.Size = new System.Drawing.Size(69, 17);
            this.chck_bbq.TabIndex = 1;
            this.chck_bbq.Text = "BBQ Sos";
            this.chck_bbq.UseVisualStyleBackColor = true;
            // 
            // chck_ranch
            // 
            this.chck_ranch.AutoSize = true;
            this.chck_ranch.Location = new System.Drawing.Point(21, 38);
            this.chck_ranch.Name = "chck_ranch";
            this.chck_ranch.Size = new System.Drawing.Size(79, 17);
            this.chck_ranch.TabIndex = 0;
            this.chck_ranch.Text = "Ranch Sos";
            this.chck_ranch.UseVisualStyleBackColor = true;
            // 
            // cmb_snack
            // 
            this.cmb_snack.FormattingEnabled = true;
            this.cmb_snack.Location = new System.Drawing.Point(170, 137);
            this.cmb_snack.Name = "cmb_snack";
            this.cmb_snack.Size = new System.Drawing.Size(121, 21);
            this.cmb_snack.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ekstra Atıştırmalık:";
            // 
            // cmb_drink_size
            // 
            this.cmb_drink_size.FormattingEnabled = true;
            this.cmb_drink_size.Location = new System.Drawing.Point(170, 110);
            this.cmb_drink_size.Name = "cmb_drink_size";
            this.cmb_drink_size.Size = new System.Drawing.Size(121, 21);
            this.cmb_drink_size.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "İçecek Boyutu:";
            // 
            // cmb_drinks
            // 
            this.cmb_drinks.FormattingEnabled = true;
            this.cmb_drinks.Location = new System.Drawing.Point(170, 83);
            this.cmb_drinks.Name = "cmb_drinks";
            this.cmb_drinks.Size = new System.Drawing.Size(121, 21);
            this.cmb_drinks.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "İçecek:";
            // 
            // cmb_potato_size
            // 
            this.cmb_potato_size.FormattingEnabled = true;
            this.cmb_potato_size.Location = new System.Drawing.Point(170, 53);
            this.cmb_potato_size.Name = "cmb_potato_size";
            this.cmb_potato_size.Size = new System.Drawing.Size(121, 21);
            this.cmb_potato_size.TabIndex = 3;
            // 
            // cmb_menu
            // 
            this.cmb_menu.FormattingEnabled = true;
            this.cmb_menu.Location = new System.Drawing.Point(170, 26);
            this.cmb_menu.Name = "cmb_menu";
            this.cmb_menu.Size = new System.Drawing.Size(121, 21);
            this.cmb_menu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patates Boyutu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menünüzü Seçiniz:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Sipariş Sayfası";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_potato_size;
        private System.Windows.Forms.ComboBox cmb_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_drinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chck_pesto;
        private System.Windows.Forms.CheckBox chck_aci;
        private System.Windows.Forms.CheckBox chck_hardal;
        private System.Windows.Forms.CheckBox chck_sarimsak;
        private System.Windows.Forms.CheckBox chck_bbq;
        private System.Windows.Forms.CheckBox chck_ranch;
        private System.Windows.Forms.ComboBox cmb_snack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_drink_size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmmenu;
        private System.Windows.Forms.ColumnHeader clmptsize;
        private System.Windows.Forms.ColumnHeader clmdrink;
        private System.Windows.Forms.ColumnHeader clmdrinksize;
        private System.Windows.Forms.ColumnHeader clmsnack;
        private System.Windows.Forms.ColumnHeader clmbalance;
    }
}