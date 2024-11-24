namespace PlytixPIM
{
    partial class LeerCategoria
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
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNum = new System.Windows.Forms.TextBox();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCategoria
            // 
            this.textCategoria.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCategoria.Location = new System.Drawing.Point(379, 68);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.ReadOnly = true;
            this.textCategoria.Size = new System.Drawing.Size(773, 120);
            this.textCategoria.TabIndex = 0;
            this.textCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Productos asociados";
            // 
            // textNum
            // 
            this.textNum.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNum.Location = new System.Drawing.Point(815, 384);
            this.textNum.Name = "textNum";
            this.textNum.ReadOnly = true;
            this.textNum.Size = new System.Drawing.Size(290, 38);
            this.textNum.TabIndex = 2;
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.Location = new System.Drawing.Point(39, 36);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(106, 35);
            this.bBack.TabIndex = 3;
            this.bBack.Text = "<- BACK";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // LeerCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCategoria);
            this.Name = "LeerCategoria";
            this.Text = "LeerCategoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LeerCategoria_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Button bBack;
    }
}