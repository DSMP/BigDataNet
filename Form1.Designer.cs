namespace BigDataNet
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.catName = new System.Windows.Forms.TextBox();
            this.catDesc = new System.Windows.Forms.TextBox();
            this.AddCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 245);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wczytaj dane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // catName
            // 
            this.catName.Location = new System.Drawing.Point(46, 337);
            this.catName.Name = "catName";
            this.catName.Size = new System.Drawing.Size(100, 20);
            this.catName.TabIndex = 3;
            // 
            // catDesc
            // 
            this.catDesc.Location = new System.Drawing.Point(238, 337);
            this.catDesc.Name = "catDesc";
            this.catDesc.Size = new System.Drawing.Size(100, 20);
            this.catDesc.TabIndex = 4;
            // 
            // AddCat
            // 
            this.AddCat.Location = new System.Drawing.Point(362, 334);
            this.AddCat.Name = "AddCat";
            this.AddCat.Size = new System.Drawing.Size(111, 23);
            this.AddCat.TabIndex = 5;
            this.AddCat.Text = "Add Category";
            this.AddCat.UseVisualStyleBackColor = true;
            this.AddCat.Click += new System.EventHandler(this.AddCat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 412);
            this.Controls.Add(this.AddCat);
            this.Controls.Add(this.catDesc);
            this.Controls.Add(this.catName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox catName;
        private System.Windows.Forms.TextBox catDesc;
        private System.Windows.Forms.Button AddCat;
    }
}