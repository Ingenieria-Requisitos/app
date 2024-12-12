namespace PlytixPIM
{
    partial class Csv
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
            this.bBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listCategorias = new System.Windows.Forms.ListBox();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.bClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 93);
            this.label1.TabIndex = 4;
            this.label1.Text = "GENERATE CSV";
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.Location = new System.Drawing.Point(49, 56);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(98, 30);
            this.bBack.TabIndex = 10;
            this.bBack.Text = "<- BACK";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter by category:";
            // 
            // listCategorias
            // 
            this.listCategorias.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCategorias.FormattingEnabled = true;
            this.listCategorias.ItemHeight = 32;
            this.listCategorias.Location = new System.Drawing.Point(131, 354);
            this.listCategorias.Name = "listCategorias";
            this.listCategorias.Size = new System.Drawing.Size(331, 164);
            this.listCategorias.TabIndex = 12;
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AllowUserToDeleteRows = false;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Location = new System.Drawing.Point(739, 223);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.ReadOnly = true;
            this.tablaProductos.RowHeadersWidth = 51;
            this.tablaProductos.RowTemplate.Height = 24;
            this.tablaProductos.Size = new System.Drawing.Size(692, 374);
            this.tablaProductos.TabIndex = 13;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(239, 553);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(109, 44);
            this.bClear.TabIndex = 14;
            this.bClear.Text = "CLEAR SELECTION";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Csv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.listCategorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.label1);
            this.Name = "Csv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Csv";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Csv_FormClosing);
            this.Load += new System.EventHandler(this.Csv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCategorias;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.Button bClear;
    }
}