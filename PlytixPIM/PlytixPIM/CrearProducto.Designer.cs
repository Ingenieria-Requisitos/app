namespace PlytixPIM
{
    partial class CrearProducto
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
            this.bSubmit = new System.Windows.Forms.Button();
            this.skuBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCategories = new System.Windows.Forms.Label();
            this.gtinBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSubmit
            // 
            this.bSubmit.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.Location = new System.Drawing.Point(308, 587);
            this.bSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(139, 71);
            this.bSubmit.TabIndex = 8;
            this.bSubmit.Text = "Add";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // skuBox
            // 
            this.skuBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skuBox.Location = new System.Drawing.Point(308, 348);
            this.skuBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skuBox.Name = "skuBox";
            this.skuBox.Size = new System.Drawing.Size(471, 38);
            this.skuBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "SKU";
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategories.Location = new System.Drawing.Point(436, 89);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(644, 93);
            this.labelCategories.TabIndex = 5;
            this.labelCategories.Text = "NEW PRODUCT";
            // 
            // gtinBox
            // 
            this.gtinBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtinBox.Location = new System.Drawing.Point(308, 423);
            this.gtinBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gtinBox.Name = "gtinBox";
            this.gtinBox.Size = new System.Drawing.Size(471, 38);
            this.gtinBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "GTIN";
            // 
            // labelBox
            // 
            this.labelBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBox.Location = new System.Drawing.Point(308, 281);
            this.labelBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(471, 38);
            this.labelBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Label";
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(64, 145);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 13;
            this.bBack.Text = "<- BACK";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click_1);
            // 
            // CrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 753);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.labelBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gtinBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.skuBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCategories);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrearProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearProducto";
            this.Load += new System.EventHandler(this.CrearProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.TextBox skuBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.TextBox gtinBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox labelBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bBack;
    }
}