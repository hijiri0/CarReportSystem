﻿namespace CarReportSystem
{
    partial class Form1
    {
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
            this.rbtoyota = new System.Windows.Forms.RadioButton();
            this.dtDay = new System.Windows.Forms.DateTimePicker();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btImageopen = new System.Windows.Forms.Button();
            this.btImageclear = new System.Windows.Forms.Button();
            this.pbimge = new System.Windows.Forms.PictureBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btcChange = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.dgvCarData = new System.Windows.Forms.DataGridView();
            this.rbsonota = new System.Windows.Forms.RadioButton();
            this.rbsubaru = new System.Windows.Forms.RadioButton();
            this.rbnisan = new System.Windows.Forms.RadioButton();
            this.rbhonda = new System.Windows.Forms.RadioButton();
            this.rbgaisya = new System.Windows.Forms.RadioButton();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.btFinish = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbimge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).BeginInit();
            this.gbMaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "記事一覧：";
            // 
            // rbtoyota
            // 
            this.rbtoyota.AutoSize = true;
            this.rbtoyota.Location = new System.Drawing.Point(8, 7);
            this.rbtoyota.Name = "rbtoyota";
            this.rbtoyota.Size = new System.Drawing.Size(47, 16);
            this.rbtoyota.TabIndex = 5;
            this.rbtoyota.TabStop = true;
            this.rbtoyota.Text = "トヨタ";
            this.rbtoyota.UseVisualStyleBackColor = true;
            // 
            // dtDay
            // 
            this.dtDay.Location = new System.Drawing.Point(100, 21);
            this.dtDay.Name = "dtDay";
            this.dtDay.Size = new System.Drawing.Size(200, 19);
            this.dtDay.TabIndex = 6;
            this.dtDay.Value = new System.DateTime(2020, 7, 9, 0, 0, 0, 0);
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(100, 64);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(121, 20);
            this.cbAuthor.TabIndex = 7;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(100, 143);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 20);
            this.cbName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "レポート：";
            // 
            // tbMemo
            // 
            this.tbMemo.Location = new System.Drawing.Point(100, 184);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(400, 95);
            this.tbMemo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "画像：";
            // 
            // btImageopen
            // 
            this.btImageopen.Location = new System.Drawing.Point(571, 28);
            this.btImageopen.Name = "btImageopen";
            this.btImageopen.Size = new System.Drawing.Size(75, 23);
            this.btImageopen.TabIndex = 12;
            this.btImageopen.Text = "開く";
            this.btImageopen.UseVisualStyleBackColor = true;
            this.btImageopen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btImageclear
            // 
            this.btImageclear.Location = new System.Drawing.Point(677, 28);
            this.btImageclear.Name = "btImageclear";
            this.btImageclear.Size = new System.Drawing.Size(75, 23);
            this.btImageclear.TabIndex = 13;
            this.btImageclear.Text = "削除";
            this.btImageclear.UseVisualStyleBackColor = true;
            this.btImageclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbimge
            // 
            this.pbimge.BackColor = System.Drawing.Color.Transparent;
            this.pbimge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbimge.Location = new System.Drawing.Point(506, 77);
            this.pbimge.Name = "pbimge";
            this.pbimge.Size = new System.Drawing.Size(282, 151);
            this.pbimge.TabIndex = 14;
            this.pbimge.TabStop = false;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(506, 259);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 15;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btcChange
            // 
            this.btcChange.Location = new System.Drawing.Point(606, 259);
            this.btcChange.Name = "btcChange";
            this.btcChange.Size = new System.Drawing.Size(75, 23);
            this.btcChange.TabIndex = 16;
            this.btcChange.Text = "修正";
            this.btcChange.UseVisualStyleBackColor = true;
            this.btcChange.Click += new System.EventHandler(this.btcChange_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(713, 259);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 17;
            this.btClear.Text = "削除";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.button5_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(25, 432);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 19;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.button7_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(25, 363);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 20;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // dgvCarData
            // 
            this.dgvCarData.AllowUserToAddRows = false;
            this.dgvCarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarData.Location = new System.Drawing.Point(108, 320);
            this.dgvCarData.Name = "dgvCarData";
            this.dgvCarData.RowTemplate.Height = 21;
            this.dgvCarData.RowTemplate.ReadOnly = true;
            this.dgvCarData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarData.Size = new System.Drawing.Size(680, 160);
            this.dgvCarData.TabIndex = 21;
            this.dgvCarData.Click += new System.EventHandler(this.dgvCarData_Click);
            // 
            // rbsonota
            // 
            this.rbsonota.AutoSize = true;
            this.rbsonota.Location = new System.Drawing.Point(216, 7);
            this.rbsonota.Name = "rbsonota";
            this.rbsonota.Size = new System.Drawing.Size(54, 16);
            this.rbsonota.TabIndex = 22;
            this.rbsonota.TabStop = true;
            this.rbsonota.Text = "その他";
            this.rbsonota.UseVisualStyleBackColor = true;
            // 
            // rbsubaru
            // 
            this.rbsubaru.AutoSize = true;
            this.rbsubaru.Location = new System.Drawing.Point(169, 7);
            this.rbsubaru.Name = "rbsubaru";
            this.rbsubaru.Size = new System.Drawing.Size(52, 16);
            this.rbsubaru.TabIndex = 23;
            this.rbsubaru.TabStop = true;
            this.rbsubaru.Text = "スバル";
            this.rbsubaru.UseVisualStyleBackColor = true;
            // 
            // rbnisan
            // 
            this.rbnisan.AutoSize = true;
            this.rbnisan.Location = new System.Drawing.Point(59, 7);
            this.rbnisan.Name = "rbnisan";
            this.rbnisan.Size = new System.Drawing.Size(47, 16);
            this.rbnisan.TabIndex = 24;
            this.rbnisan.TabStop = true;
            this.rbnisan.Text = "日産";
            this.rbnisan.UseVisualStyleBackColor = true;
            // 
            // rbhonda
            // 
            this.rbhonda.AutoSize = true;
            this.rbhonda.Location = new System.Drawing.Point(112, 7);
            this.rbhonda.Name = "rbhonda";
            this.rbhonda.Size = new System.Drawing.Size(51, 16);
            this.rbhonda.TabIndex = 25;
            this.rbhonda.TabStop = true;
            this.rbhonda.Text = "ホンダ";
            this.rbhonda.UseVisualStyleBackColor = true;
            // 
            // rbgaisya
            // 
            this.rbgaisya.AutoSize = true;
            this.rbgaisya.Location = new System.Drawing.Point(276, 7);
            this.rbgaisya.Name = "rbgaisya";
            this.rbgaisya.Size = new System.Drawing.Size(47, 16);
            this.rbgaisya.TabIndex = 26;
            this.rbgaisya.TabStop = true;
            this.rbgaisya.Text = "外車";
            this.rbgaisya.UseVisualStyleBackColor = true;
            // 
            // gbMaker
            // 
            this.gbMaker.Controls.Add(this.rbtoyota);
            this.gbMaker.Controls.Add(this.rbgaisya);
            this.gbMaker.Controls.Add(this.rbnisan);
            this.gbMaker.Controls.Add(this.rbsonota);
            this.gbMaker.Controls.Add(this.rbsubaru);
            this.gbMaker.Controls.Add(this.rbhonda);
            this.gbMaker.Location = new System.Drawing.Point(100, 106);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Size = new System.Drawing.Size(340, 28);
            this.gbMaker.TabIndex = 27;
            this.gbMaker.TabStop = false;
            this.gbMaker.Text = "groupBox1";
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // btFinish
            // 
            this.btFinish.Location = new System.Drawing.Point(713, 495);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(75, 23);
            this.btFinish.TabIndex = 28;
            this.btFinish.Text = "終了";
            this.btFinish.UseVisualStyleBackColor = true;
            this.btFinish.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.btFinish);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(this.dgvCarData);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btcChange);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.pbimge);
            this.Controls.Add(this.btImageclear);
            this.Controls.Add(this.btImageopen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dtDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbimge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).EndInit();
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtoyota;
        private System.Windows.Forms.DateTimePicker dtDay;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btImageopen;
        private System.Windows.Forms.Button btImageclear;
        private System.Windows.Forms.PictureBox pbimge;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btcChange;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.DataGridView dgvCarData;
        private System.Windows.Forms.RadioButton rbsonota;
        private System.Windows.Forms.RadioButton rbsubaru;
        private System.Windows.Forms.RadioButton rbnisan;
        private System.Windows.Forms.RadioButton rbhonda;
        private System.Windows.Forms.RadioButton rbgaisya;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.Button btFinish;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

