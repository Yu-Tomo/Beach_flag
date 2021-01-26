namespace imageClassification
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.fileBottun = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.TextBox();
            this.disp_file_name = new System.Windows.Forms.Label();
            this.flgGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.class_b = new System.Windows.Forms.Button();
            this.pause_b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusInfo = new System.Windows.Forms.TextBox();
            this.save_b = new System.Windows.Forms.Button();
            this.cancel_b = new System.Windows.Forms.Button();
            this.img_reset = new System.Windows.Forms.Button();
            this.all_image_num = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.flgGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgBox
            // 
            this.imgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBox.BackColor = System.Drawing.SystemColors.Menu;
            this.imgBox.Location = new System.Drawing.Point(259, 37);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(653, 420);
            this.imgBox.TabIndex = 0;
            this.imgBox.TabStop = false;
            // 
            // fileBottun
            // 
            this.fileBottun.Location = new System.Drawing.Point(259, 12);
            this.fileBottun.Name = "fileBottun";
            this.fileBottun.Size = new System.Drawing.Size(54, 19);
            this.fileBottun.TabIndex = 1;
            this.fileBottun.Text = "開く";
            this.fileBottun.UseVisualStyleBackColor = true;
            this.fileBottun.Click += new System.EventHandler(this.fileBottun_Click);
            // 
            // filename
            // 
            this.filename.AllowDrop = true;
            this.filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filename.Location = new System.Drawing.Point(319, 12);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(507, 19);
            this.filename.TabIndex = 2;
            this.filename.DragDrop += new System.Windows.Forms.DragEventHandler(this.file_DragDrop);
            this.filename.DragEnter += new System.Windows.Forms.DragEventHandler(this.file_DragEnter);
            // 
            // disp_file_name
            // 
            this.disp_file_name.AutoSize = true;
            this.disp_file_name.Location = new System.Drawing.Point(12, 30);
            this.disp_file_name.Name = "disp_file_name";
            this.disp_file_name.Size = new System.Drawing.Size(191, 12);
            this.disp_file_name.TabIndex = 3;
            this.disp_file_name.Text = "-------------------------------";
            // 
            // flgGroupBox
            // 
            this.flgGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flgGroupBox.Controls.Add(this.textBox5);
            this.flgGroupBox.Controls.Add(this.textBox9);
            this.flgGroupBox.Controls.Add(this.textBox8);
            this.flgGroupBox.Controls.Add(this.radioButton9);
            this.flgGroupBox.Controls.Add(this.radioButton5);
            this.flgGroupBox.Controls.Add(this.textBox7);
            this.flgGroupBox.Controls.Add(this.textBox6);
            this.flgGroupBox.Controls.Add(this.radioButton6);
            this.flgGroupBox.Controls.Add(this.radioButton7);
            this.flgGroupBox.Controls.Add(this.radioButton8);
            this.flgGroupBox.Controls.Add(this.textBox4);
            this.flgGroupBox.Controls.Add(this.textBox3);
            this.flgGroupBox.Controls.Add(this.radioButton4);
            this.flgGroupBox.Controls.Add(this.radioButton3);
            this.flgGroupBox.Controls.Add(this.textBox2);
            this.flgGroupBox.Controls.Add(this.textBox1);
            this.flgGroupBox.Controls.Add(this.textBox0);
            this.flgGroupBox.Controls.Add(this.radioButton2);
            this.flgGroupBox.Controls.Add(this.radioButton1);
            this.flgGroupBox.Controls.Add(this.radioButton0);
            this.flgGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flgGroupBox.Location = new System.Drawing.Point(14, 51);
            this.flgGroupBox.Name = "flgGroupBox";
            this.flgGroupBox.Size = new System.Drawing.Size(228, 141);
            this.flgGroupBox.TabIndex = 4;
            this.flgGroupBox.TabStop = false;
            this.flgGroupBox.Text = "分類選択";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 22);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(82, 19);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "flg5";
            this.textBox5.Enter += new System.EventHandler(this.textBoxEnter);
            this.textBox5.Leave += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(138, 112);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(82, 19);
            this.textBox9.TabIndex = 22;
            this.textBox9.Text = "flg9";
            this.textBox9.Enter += new System.EventHandler(this.textBoxEnter);
            this.textBox9.Leave += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(138, 89);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(82, 19);
            this.textBox8.TabIndex = 21;
            this.textBox8.Text = "flg8";
            this.textBox8.Enter += new System.EventHandler(this.textBoxEnter);
            this.textBox8.Leave += new System.EventHandler(this.textBox_TextChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(119, 115);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(29, 16);
            this.radioButton9.TabIndex = 19;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(119, 26);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(29, 16);
            this.radioButton5.TabIndex = 18;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(138, 67);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(82, 19);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "flg7";
            this.textBox7.Enter += new System.EventHandler(this.textBoxEnter);
            this.textBox7.Leave += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(138, 45);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(82, 19);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "flg6";
            this.textBox6.Enter += new System.EventHandler(this.textBoxEnter);
            this.textBox6.Leave += new System.EventHandler(this.textBox_TextChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(119, 48);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(29, 16);
            this.radioButton6.TabIndex = 14;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(119, 70);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(29, 16);
            this.radioButton7.TabIndex = 13;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "7";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(119, 92);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(29, 16);
            this.radioButton8.TabIndex = 12;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(25, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 19);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "flg4";
            this.textBox4.Enter += new System.EventHandler(this.textBoxEnter);
            this.textBox4.Leave += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(25, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 19);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "flg3";
            this.textBox3.Enter += new System.EventHandler(this.textBoxEnter);
            this.textBox3.Leave += new System.EventHandler(this.textBox_TextChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 115);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(29, 16);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 92);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(29, 16);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 19);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "flg2";
            this.textBox2.Enter += new System.EventHandler(this.textBoxEnter);
            this.textBox2.Leave += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 19);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "flg1";
            this.textBox1.Enter += new System.EventHandler(this.textBoxEnter);
            this.textBox1.Leave += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox0
            // 
            this.textBox0.Enabled = false;
            this.textBox0.Location = new System.Drawing.Point(25, 23);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(82, 19);
            this.textBox0.TabIndex = 3;
            this.textBox0.Text = "分類しない";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(29, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(29, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Location = new System.Drawing.Point(7, 25);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(29, 16);
            this.radioButton0.TabIndex = 0;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = "0";
            this.radioButton0.UseVisualStyleBackColor = true;
            this.radioButton0.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // class_b
            // 
            this.class_b.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.class_b.Location = new System.Drawing.Point(14, 198);
            this.class_b.Name = "class_b";
            this.class_b.Size = new System.Drawing.Size(107, 36);
            this.class_b.TabIndex = 5;
            this.class_b.Text = "連続分類モード";
            this.class_b.UseVisualStyleBackColor = true;
            this.class_b.Click += new System.EventHandler(this.class_b_Click);
            // 
            // pause_b
            // 
            this.pause_b.BackColor = System.Drawing.SystemColors.Control;
            this.pause_b.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pause_b.Location = new System.Drawing.Point(138, 198);
            this.pause_b.Name = "pause_b";
            this.pause_b.Size = new System.Drawing.Size(104, 36);
            this.pause_b.TabIndex = 6;
            this.pause_b.Text = "個別分類モード";
            this.pause_b.UseVisualStyleBackColor = false;
            this.pause_b.Click += new System.EventHandler(this.pause_b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "開いてるファイル";
            // 
            // statusInfo
            // 
            this.statusInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.statusInfo.BackColor = System.Drawing.SystemColors.Info;
            this.statusInfo.Location = new System.Drawing.Point(14, 332);
            this.statusInfo.Multiline = true;
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.ReadOnly = true;
            this.statusInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statusInfo.Size = new System.Drawing.Size(230, 127);
            this.statusInfo.TabIndex = 8;
            // 
            // save_b
            // 
            this.save_b.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.save_b.Location = new System.Drawing.Point(14, 240);
            this.save_b.Name = "save_b";
            this.save_b.Size = new System.Drawing.Size(228, 40);
            this.save_b.TabIndex = 9;
            this.save_b.Text = "分類結果を保存する";
            this.save_b.UseVisualStyleBackColor = true;
            this.save_b.Click += new System.EventHandler(this.save_b_Click);
            // 
            // cancel_b
            // 
            this.cancel_b.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancel_b.Location = new System.Drawing.Point(14, 286);
            this.cancel_b.Name = "cancel_b";
            this.cancel_b.Size = new System.Drawing.Size(228, 40);
            this.cancel_b.TabIndex = 10;
            this.cancel_b.Text = "画像を閉じる";
            this.cancel_b.UseVisualStyleBackColor = true;
            this.cancel_b.Click += new System.EventHandler(this.cancel_b_Click);
            // 
            // img_reset
            // 
            this.img_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.img_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.img_reset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.img_reset.Location = new System.Drawing.Point(848, 7);
            this.img_reset.Name = "img_reset";
            this.img_reset.Size = new System.Drawing.Size(63, 28);
            this.img_reset.TabIndex = 11;
            this.img_reset.Text = "更新";
            this.img_reset.UseVisualStyleBackColor = true;
            this.img_reset.Click += new System.EventHandler(this.img_reset_Click);
            // 
            // all_image_num
            // 
            this.all_image_num.AutoSize = true;
            this.all_image_num.Location = new System.Drawing.Point(150, 12);
            this.all_image_num.Name = "all_image_num";
            this.all_image_num.Size = new System.Drawing.Size(23, 12);
            this.all_image_num.TabIndex = 12;
            this.all_image_num.Text = "0/0";
            this.all_image_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 469);
            this.Controls.Add(this.all_image_num);
            this.Controls.Add(this.img_reset);
            this.Controls.Add(this.cancel_b);
            this.Controls.Add(this.save_b);
            this.Controls.Add(this.statusInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pause_b);
            this.Controls.Add(this.class_b);
            this.Controls.Add(this.flgGroupBox);
            this.Controls.Add(this.disp_file_name);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.fileBottun);
            this.Controls.Add(this.imgBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "mainForm";
            this.Text = "Beach flag";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.file_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.file_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.flgGroupBox.ResumeLayout(false);
            this.flgGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Button fileBottun;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Label disp_file_name;
        private System.Windows.Forms.GroupBox flgGroupBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.Button class_b;
        private System.Windows.Forms.Button pause_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox statusInfo;
        private System.Windows.Forms.Button save_b;
        private System.Windows.Forms.Button cancel_b;
        private System.Windows.Forms.Button img_reset;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label all_image_num;
    }
}

