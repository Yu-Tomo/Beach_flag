namespace imageClassification
{
    partial class Select_dir_form
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
            this.folderPath = new System.Windows.Forms.TextBox();
            this.miss_f = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.end_button = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // miss_t
            // 
            this.folderPath.AllowDrop = true;
            this.folderPath.Location = new System.Drawing.Point(85, 33);
            this.folderPath.Name = "miss_t";
            this.folderPath.Size = new System.Drawing.Size(372, 19);
            this.folderPath.TabIndex = 6;
            this.folderPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.folderDrop);
            this.folderPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.folderDragEntry);
            // 
            // miss_f
            // 
            this.miss_f.Location = new System.Drawing.Point(12, 33);
            this.miss_f.Name = "miss_f";
            this.miss_f.Size = new System.Drawing.Size(54, 19);
            this.miss_f.TabIndex = 5;
            this.miss_f.Text = "開く";
            this.miss_f.UseVisualStyleBackColor = true;
            this.miss_f.Click += new System.EventHandler(this.miss_f_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.folderPath);
            this.groupBox2.Controls.Add(this.miss_f);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 75);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "保存先のディレクトリ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // end_button
            // 
            this.end_button.Location = new System.Drawing.Point(362, 93);
            this.end_button.Name = "end_button";
            this.end_button.Size = new System.Drawing.Size(123, 29);
            this.end_button.TabIndex = 7;
            this.end_button.Text = "保存する";
            this.end_button.UseVisualStyleBackColor = true;
            this.end_button.Click += new System.EventHandler(this.end_button_Click);
            // 
            // Select_dir_form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 132);
            this.Controls.Add(this.end_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Select_dir_form";
            this.Text = "保存先の選択";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.folderDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.folderDragEntry);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button miss_f;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button end_button;
    }
}