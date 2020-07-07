namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbkiroku = new System.Windows.Forms.ComboBox();
            this.cbcar = new System.Windows.Forms.ComboBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.bthiraku = new System.Windows.Forms.Button();
            this.btsakuzyo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bttuika = new System.Windows.Forms.Button();
            this.btsyuusei = new System.Windows.Forms.Button();
            this.btclr = new System.Windows.Forms.Button();
            this.btopen = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbrepot = new System.Windows.Forms.TextBox();
            this.dgvCarDate = new System.Windows.Forms.DataGridView();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btexit = new System.Windows.Forms.Button();
            this.rdtoyota = new System.Windows.Forms.RadioButton();
            this.rdnissann = new System.Windows.Forms.RadioButton();
            this.rdhonnda = new System.Windows.Forms.RadioButton();
            this.rdsubaru = new System.Windows.Forms.RadioButton();
            this.rdgaisya = new System.Windows.Forms.RadioButton();
            this.rdsonota = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openImag = new System.Windows.Forms.OpenFileDialog();
            this.ofdtext = new System.Windows.Forms.OpenFileDialog();
            this.sfdtext = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(3, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "レポート：";
            // 
            // cbkiroku
            // 
            this.cbkiroku.FormattingEnabled = true;
            this.cbkiroku.Location = new System.Drawing.Point(73, 40);
            this.cbkiroku.Name = "cbkiroku";
            this.cbkiroku.Size = new System.Drawing.Size(121, 20);
            this.cbkiroku.TabIndex = 4;
            // 
            // cbcar
            // 
            this.cbcar.FormattingEnabled = true;
            this.cbcar.Location = new System.Drawing.Point(73, 75);
            this.cbcar.Name = "cbcar";
            this.cbcar.Size = new System.Drawing.Size(121, 20);
            this.cbcar.TabIndex = 5;
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(73, 8);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(200, 19);
            this.dtpdate.TabIndex = 6;
            // 
            // bthiraku
            // 
            this.bthiraku.Location = new System.Drawing.Point(575, 40);
            this.bthiraku.Name = "bthiraku";
            this.bthiraku.Size = new System.Drawing.Size(75, 23);
            this.bthiraku.TabIndex = 7;
            this.bthiraku.Text = "開く";
            this.bthiraku.UseVisualStyleBackColor = true;
            this.bthiraku.Click += new System.EventHandler(this.bthiraku_Click);
            // 
            // btsakuzyo
            // 
            this.btsakuzyo.Location = new System.Drawing.Point(672, 40);
            this.btsakuzyo.Name = "btsakuzyo";
            this.btsakuzyo.Size = new System.Drawing.Size(75, 23);
            this.btsakuzyo.TabIndex = 8;
            this.btsakuzyo.Text = "削除";
            this.btsakuzyo.UseVisualStyleBackColor = true;
            this.btsakuzyo.Click += new System.EventHandler(this.btsakuzyo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(500, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "画像：";
            // 
            // bttuika
            // 
            this.bttuika.Location = new System.Drawing.Point(503, 257);
            this.bttuika.Name = "bttuika";
            this.bttuika.Size = new System.Drawing.Size(75, 23);
            this.bttuika.TabIndex = 9;
            this.bttuika.Text = "追加";
            this.bttuika.UseVisualStyleBackColor = true;
            this.bttuika.Click += new System.EventHandler(this.bttuika_Click);
            // 
            // btsyuusei
            // 
            this.btsyuusei.Location = new System.Drawing.Point(586, 257);
            this.btsyuusei.Name = "btsyuusei";
            this.btsyuusei.Size = new System.Drawing.Size(75, 23);
            this.btsyuusei.TabIndex = 10;
            this.btsyuusei.Text = "修正";
            this.btsyuusei.UseVisualStyleBackColor = true;
            this.btsyuusei.Click += new System.EventHandler(this.btsyuusei_Click);
            // 
            // btclr
            // 
            this.btclr.Location = new System.Drawing.Point(667, 257);
            this.btclr.Name = "btclr";
            this.btclr.Size = new System.Drawing.Size(75, 23);
            this.btclr.TabIndex = 11;
            this.btclr.Text = "削除";
            this.btclr.UseVisualStyleBackColor = true;
            this.btclr.Click += new System.EventHandler(this.btclr_Click);
            // 
            // btopen
            // 
            this.btopen.Location = new System.Drawing.Point(18, 349);
            this.btopen.Name = "btopen";
            this.btopen.Size = new System.Drawing.Size(75, 23);
            this.btopen.TabIndex = 12;
            this.btopen.Text = "開く";
            this.btopen.UseVisualStyleBackColor = true;
            this.btopen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(18, 378);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(75, 23);
            this.btsave.TabIndex = 13;
            this.btsave.Text = "保存";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(12, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "記事一覧：";
            // 
            // tbrepot
            // 
            this.tbrepot.Location = new System.Drawing.Point(99, 160);
            this.tbrepot.Multiline = true;
            this.tbrepot.Name = "tbrepot";
            this.tbrepot.Size = new System.Drawing.Size(398, 129);
            this.tbrepot.TabIndex = 14;
            // 
            // dgvCarDate
            // 
            this.dgvCarDate.AllowUserToAddRows = false;
            this.dgvCarDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarDate.Location = new System.Drawing.Point(99, 308);
            this.dgvCarDate.MultiSelect = false;
            this.dgvCarDate.Name = "dgvCarDate";
            this.dgvCarDate.ReadOnly = true;
            this.dgvCarDate.RowTemplate.Height = 21;
            this.dgvCarDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarDate.Size = new System.Drawing.Size(652, 150);
            this.dgvCarDate.TabIndex = 15;
            this.dgvCarDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarDate_Click);
            this.dgvCarDate.Click += new System.EventHandler(this.dgvCarDate_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(503, 69);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(244, 182);
            this.pbImage.TabIndex = 16;
            this.pbImage.TabStop = false;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(687, 478);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 17;
            this.btexit.Text = "終了";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // rdtoyota
            // 
            this.rdtoyota.AutoSize = true;
            this.rdtoyota.Location = new System.Drawing.Point(15, 18);
            this.rdtoyota.Name = "rdtoyota";
            this.rdtoyota.Size = new System.Drawing.Size(47, 16);
            this.rdtoyota.TabIndex = 18;
            this.rdtoyota.Text = "トヨタ";
            this.rdtoyota.UseVisualStyleBackColor = true;
            // 
            // rdnissann
            // 
            this.rdnissann.AutoSize = true;
            this.rdnissann.Location = new System.Drawing.Point(68, 18);
            this.rdnissann.Name = "rdnissann";
            this.rdnissann.Size = new System.Drawing.Size(47, 16);
            this.rdnissann.TabIndex = 19;
            this.rdnissann.Text = "日産";
            this.rdnissann.UseVisualStyleBackColor = true;
            // 
            // rdhonnda
            // 
            this.rdhonnda.AutoSize = true;
            this.rdhonnda.Location = new System.Drawing.Point(121, 18);
            this.rdhonnda.Name = "rdhonnda";
            this.rdhonnda.Size = new System.Drawing.Size(51, 16);
            this.rdhonnda.TabIndex = 20;
            this.rdhonnda.Text = "ホンダ";
            this.rdhonnda.UseVisualStyleBackColor = true;
            // 
            // rdsubaru
            // 
            this.rdsubaru.AutoSize = true;
            this.rdsubaru.Location = new System.Drawing.Point(178, 18);
            this.rdsubaru.Name = "rdsubaru";
            this.rdsubaru.Size = new System.Drawing.Size(52, 16);
            this.rdsubaru.TabIndex = 21;
            this.rdsubaru.Text = "スバル";
            this.rdsubaru.UseVisualStyleBackColor = true;
            // 
            // rdgaisya
            // 
            this.rdgaisya.AutoSize = true;
            this.rdgaisya.Location = new System.Drawing.Point(236, 18);
            this.rdgaisya.Name = "rdgaisya";
            this.rdgaisya.Size = new System.Drawing.Size(47, 16);
            this.rdgaisya.TabIndex = 22;
            this.rdgaisya.Text = "外車";
            this.rdgaisya.UseVisualStyleBackColor = true;
            // 
            // rdsonota
            // 
            this.rdsonota.AutoSize = true;
            this.rdsonota.Location = new System.Drawing.Point(289, 18);
            this.rdsonota.Name = "rdsonota";
            this.rdsonota.Size = new System.Drawing.Size(54, 16);
            this.rdsonota.TabIndex = 23;
            this.rdsonota.Text = "その他";
            this.rdsonota.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdtoyota);
            this.groupBox1.Controls.Add(this.rdsonota);
            this.groupBox1.Controls.Add(this.rdnissann);
            this.groupBox1.Controls.Add(this.rdgaisya);
            this.groupBox1.Controls.Add(this.rdhonnda);
            this.groupBox1.Controls.Add(this.rdsubaru);
            this.groupBox1.Location = new System.Drawing.Point(73, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 43);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // openImag
            // 
            this.openImag.FileName = "openFileDialog1";
            // 
            // ofdtext
            // 
            this.ofdtext.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.dgvCarDate);
            this.Controls.Add(this.tbrepot);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.btopen);
            this.Controls.Add(this.btclr);
            this.Controls.Add(this.btsyuusei);
            this.Controls.Add(this.bttuika);
            this.Controls.Add(this.btsakuzyo);
            this.Controls.Add(this.bthiraku);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.cbcar);
            this.Controls.Add(this.cbkiroku);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbkiroku;
        private System.Windows.Forms.ComboBox cbcar;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Button bthiraku;
        private System.Windows.Forms.Button btsakuzyo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttuika;
        private System.Windows.Forms.Button btsyuusei;
        private System.Windows.Forms.Button btclr;
        private System.Windows.Forms.Button btopen;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbrepot;
        private System.Windows.Forms.DataGridView dgvCarDate;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.RadioButton rdtoyota;
        private System.Windows.Forms.RadioButton rdnissann;
        private System.Windows.Forms.RadioButton rdhonnda;
        private System.Windows.Forms.RadioButton rdsubaru;
        private System.Windows.Forms.RadioButton rdgaisya;
        private System.Windows.Forms.RadioButton rdsonota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openImag;
        private System.Windows.Forms.OpenFileDialog ofdtext;
        private System.Windows.Forms.SaveFileDialog sfdtext;
    }
}

