namespace Builder_s_Project
{
    partial class malzemeler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vericekBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firmaCmb = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fiyatTxt = new System.Windows.Forms.TextBox();
            this.türTxt = new System.Windows.Forms.TextBox();
            this.isimTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gizleBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vericekBtn
            // 
            this.vericekBtn.BackgroundImage = global::Builder_s_Project.Properties.Resources.button;
            this.vericekBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vericekBtn.Location = new System.Drawing.Point(31, 12);
            this.vericekBtn.Name = "vericekBtn";
            this.vericekBtn.Size = new System.Drawing.Size(120, 46);
            this.vericekBtn.TabIndex = 1;
            this.vericekBtn.Text = "Veri Çek";
            this.vericekBtn.UseVisualStyleBackColor = true;
            this.vericekBtn.Click += new System.EventHandler(this.vericekBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = global::Builder_s_Project.Properties.Resources.button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(531, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Malzeme ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Builder_s_Project.Properties.Resources.background2;
            this.panel1.Controls.Add(this.firmaCmb);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fiyatTxt);
            this.panel1.Controls.Add(this.türTxt);
            this.panel1.Controls.Add(this.isimTxt);
            this.panel1.Location = new System.Drawing.Point(237, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 159);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // firmaCmb
            // 
            this.firmaCmb.FormattingEnabled = true;
            this.firmaCmb.Location = new System.Drawing.Point(142, 107);
            this.firmaCmb.Name = "firmaCmb";
            this.firmaCmb.Size = new System.Drawing.Size(121, 21);
            this.firmaCmb.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Gizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Firma ismi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birim fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tür/Birim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Malzeme ismi";
            // 
            // fiyatTxt
            // 
            this.fiyatTxt.Location = new System.Drawing.Point(142, 81);
            this.fiyatTxt.Name = "fiyatTxt";
            this.fiyatTxt.Size = new System.Drawing.Size(100, 20);
            this.fiyatTxt.TabIndex = 2;
            // 
            // türTxt
            // 
            this.türTxt.Location = new System.Drawing.Point(142, 55);
            this.türTxt.Name = "türTxt";
            this.türTxt.Size = new System.Drawing.Size(100, 20);
            this.türTxt.TabIndex = 1;
            // 
            // isimTxt
            // 
            this.isimTxt.Location = new System.Drawing.Point(142, 29);
            this.isimTxt.Name = "isimTxt";
            this.isimTxt.Size = new System.Drawing.Size(100, 20);
            this.isimTxt.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Builder_s_Project.Properties.Resources.background2;
            this.panel2.Controls.Add(this.gizleBtn);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(31, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // gizleBtn
            // 
            this.gizleBtn.Location = new System.Drawing.Point(0, 75);
            this.gizleBtn.Name = "gizleBtn";
            this.gizleBtn.Size = new System.Drawing.Size(56, 23);
            this.gizleBtn.TabIndex = 3;
            this.gizleBtn.Text = "Gizle";
            this.gizleBtn.UseVisualStyleBackColor = true;
            this.gizleBtn.Click += new System.EventHandler(this.gizleBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(107, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Veriyi sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme id";
            // 
            // SilBtn
            // 
            this.SilBtn.BackgroundImage = global::Builder_s_Project.Properties.Resources.button;
            this.SilBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilBtn.Location = new System.Drawing.Point(352, 12);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(148, 46);
            this.SilBtn.TabIndex = 5;
            this.SilBtn.Text = "Malzeme Sil";
            this.SilBtn.UseVisualStyleBackColor = true;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // malzemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Builder_s_Project.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 352);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vericekBtn);
            this.Name = "malzemeler";
            this.Text = "malzemeler";
            this.Load += new System.EventHandler(this.malzemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button vericekBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fiyatTxt;
        private System.Windows.Forms.TextBox türTxt;
        private System.Windows.Forms.TextBox isimTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button gizleBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.ComboBox firmaCmb;
    }
}