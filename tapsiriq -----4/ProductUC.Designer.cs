namespace tapsiriq______4
{
    partial class ProductUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_name = new System.Windows.Forms.Button();
            this.label_qiymet = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_name
            // 
            this.button_name.Location = new System.Drawing.Point(14, 179);
            this.button_name.Name = "button_name";
            this.button_name.Size = new System.Drawing.Size(151, 60);
            this.button_name.TabIndex = 1;
            this.button_name.Text = "button1";
            this.button_name.UseVisualStyleBackColor = true;
            this.button_name.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_qiymet
            // 
            this.label_qiymet.AutoSize = true;
            this.label_qiymet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_qiymet.Location = new System.Drawing.Point(64, 242);
            this.label_qiymet.Name = "label_qiymet";
            this.label_qiymet.Size = new System.Drawing.Size(52, 31);
            this.label_qiymet.TabIndex = 2;
            this.label_qiymet.Text = "1.1";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_count.Location = new System.Drawing.Point(64, 291);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(44, 31);
            this.label_count.TabIndex = 3;
            this.label_count.Text = "10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 173);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_qiymet);
            this.Controls.Add(this.button_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(180, 322);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button button_name;
        public System.Windows.Forms.Label label_qiymet;
        public System.Windows.Forms.Label label_count;
    }
}
