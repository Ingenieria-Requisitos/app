namespace PlytixPIM
{
    partial class Inicio
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
            this.bSeeProducts = new System.Windows.Forms.Button();
            this.bSeeCategories = new System.Windows.Forms.Button();
            this.bSeeAtributes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(883, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO PLYTIX";
            // 
            // bSeeProducts
            // 
            this.bSeeProducts.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeeProducts.Location = new System.Drawing.Point(31, 345);
            this.bSeeProducts.Name = "bSeeProducts";
            this.bSeeProducts.Size = new System.Drawing.Size(413, 220);
            this.bSeeProducts.TabIndex = 1;
            this.bSeeProducts.Text = "SEE PRODUCTS";
            this.bSeeProducts.UseVisualStyleBackColor = true;
            this.bSeeProducts.Click += new System.EventHandler(this.bSeeProducts_Click);
            // 
            // bSeeCategories
            // 
            this.bSeeCategories.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeeCategories.Location = new System.Drawing.Point(525, 345);
            this.bSeeCategories.Name = "bSeeCategories";
            this.bSeeCategories.Size = new System.Drawing.Size(413, 220);
            this.bSeeCategories.TabIndex = 2;
            this.bSeeCategories.Text = "SEE CATEGORIES";
            this.bSeeCategories.UseVisualStyleBackColor = true;
            this.bSeeCategories.Click += new System.EventHandler(this.bSeeCategories_Click);
            // 
            // bSeeAtributes
            // 
            this.bSeeAtributes.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeeAtributes.Location = new System.Drawing.Point(1028, 345);
            this.bSeeAtributes.Name = "bSeeAtributes";
            this.bSeeAtributes.Size = new System.Drawing.Size(413, 220);
            this.bSeeAtributes.TabIndex = 3;
            this.bSeeAtributes.Text = "SEE ATRIBUTES";
            this.bSeeAtributes.UseVisualStyleBackColor = true;
            this.bSeeAtributes.Click += new System.EventHandler(this.bSeeAtributes_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.bSeeAtributes);
            this.Controls.Add(this.bSeeCategories);
            this.Controls.Add(this.bSeeProducts);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSeeProducts;
        private System.Windows.Forms.Button bSeeCategories;
        private System.Windows.Forms.Button bSeeAtributes;
    }
}