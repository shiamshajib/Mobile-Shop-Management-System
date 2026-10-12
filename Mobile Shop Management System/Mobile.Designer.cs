
namespace MshopM
{
    partial class Mobile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.brand = new System.Windows.Forms.TextBox();
            this.ram = new System.Windows.Forms.ComboBox();
            this.rom = new System.Windows.Forms.ComboBox();
            this.mp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MobileDGV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MobileDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "   ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "BRAND";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "MODEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(840, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "PRICE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(840, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "STOCK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "RAM in GB";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "ROM in GB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(481, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Camera in Mp";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // id
            // 
            this.id.AccessibleName = "id";
            this.id.Location = new System.Drawing.Point(193, 104);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(122, 22);
            this.id.TabIndex = 9;
            // 
            // stock
            // 
            this.stock.AccessibleName = "stock";
            this.stock.Location = new System.Drawing.Point(928, 176);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(122, 22);
            this.stock.TabIndex = 10;
            // 
            // price
            // 
            this.price.AccessibleName = "price";
            this.price.Location = new System.Drawing.Point(928, 133);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(122, 22);
            this.price.TabIndex = 11;
            // 
            // model
            // 
            this.model.AccessibleName = "model";
            this.model.Location = new System.Drawing.Point(193, 211);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(122, 22);
            this.model.TabIndex = 12;
            // 
            // brand
            // 
            this.brand.AccessibleName = "brand";
            this.brand.Location = new System.Drawing.Point(193, 161);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(122, 22);
            this.brand.TabIndex = 13;
            // 
            // ram
            // 
            this.ram.AccessibleName = "ram";
            this.ram.BackColor = System.Drawing.Color.White;
            this.ram.FormattingEnabled = true;
            this.ram.Items.AddRange(new object[] {
            "2",
            "8",
            "64",
            "128"});
            this.ram.Location = new System.Drawing.Point(615, 119);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(121, 24);
            this.ram.TabIndex = 14;
            // 
            // rom
            // 
            this.rom.AccessibleName = "rom";
            this.rom.FormattingEnabled = true;
            this.rom.Items.AddRange(new object[] {
            "8",
            "16",
            "64",
            "128"});
            this.rom.Location = new System.Drawing.Point(615, 161);
            this.rom.Name = "rom";
            this.rom.Size = new System.Drawing.Size(121, 24);
            this.rom.TabIndex = 15;
            // 
            // mp
            // 
            this.mp.AccessibleName = "mp";
            this.mp.Location = new System.Drawing.Point(615, 211);
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(121, 22);
            this.mp.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(354, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 41);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mobile Management System";
            // 
            // ADD
            // 
            this.ADD.AccessibleName = "ADD";
            this.ADD.BackColor = System.Drawing.Color.BurlyWood;
            this.ADD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.Location = new System.Drawing.Point(80, 419);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(90, 59);
            this.ADD.TabIndex = 18;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(615, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 58);
            this.button2.TabIndex = 19;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BurlyWood;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(437, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 56);
            this.button3.TabIndex = 20;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BurlyWood;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(262, 419);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 59);
            this.button4.TabIndex = 21;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MobileDGV
            // 
            this.MobileDGV.BackgroundColor = System.Drawing.Color.LightYellow;
            this.MobileDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MobileDGV.Location = new System.Drawing.Point(4, 550);
            this.MobileDGV.Name = "MobileDGV";
            this.MobileDGV.RowHeadersWidth = 51;
            this.MobileDGV.RowTemplate.Height = 24;
            this.MobileDGV.Size = new System.Drawing.Size(1046, 191);
            this.MobileDGV.TabIndex = 22;
            this.MobileDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MobileDGV_CellContentClick);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(1008, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = " X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Linen;
            this.progressBar1.Location = new System.Drawing.Point(4, 498);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1066, 46);
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(443, 510);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 34);
            this.label11.TabIndex = 25;
            this.label11.Text = "MOBILE IN STOCK";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(783, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 55);
            this.button1.TabIndex = 26;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(406, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(258, 32);
            this.label12.TabIndex = 27;
            this.label12.Text = "MOBILE DETAILS";
            // 
            // Mobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1062, 753);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MobileDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mp);
            this.Controls.Add(this.rom);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.model);
            this.Controls.Add(this.price);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mobile";
            this.Text = "Mobile";
            this.Load += new System.EventHandler(this.Mobile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MobileDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.ComboBox ram;
        private System.Windows.Forms.ComboBox rom;
        private System.Windows.Forms.TextBox mp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView MobileDGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
    }
}