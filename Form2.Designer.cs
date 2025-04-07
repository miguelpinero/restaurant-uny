namespace restaurant_uny
{
    partial class Form2
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
            this.button13 = new System.Windows.Forms.Button();
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalUsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Highlight;
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(591, 404);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(197, 34);
            this.button13.TabIndex = 14;
            this.button13.Text = "Cerrar";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // dataGridVentas
            // 
            this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.address,
            this.phoneNumber,
            this.itemsNumber,
            this.totalUsd,
            this.totalVes});
            this.dataGridVentas.Location = new System.Drawing.Point(12, 12);
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.Size = new System.Drawing.Size(776, 386);
            this.dataGridVentas.TabIndex = 15;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre y Apellido";
            this.name.Name = "name";
            // 
            // address
            // 
            this.address.HeaderText = "Direccion";
            this.address.Name = "address";
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Telefono";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // itemsNumber
            // 
            this.itemsNumber.HeaderText = "Cantidad de Articulos";
            this.itemsNumber.Name = "itemsNumber";
            // 
            // totalUsd
            // 
            this.totalUsd.HeaderText = "Total en USD";
            this.totalUsd.Name = "totalUsd";
            // 
            // totalVes
            // 
            this.totalVes.HeaderText = "Total en Bs";
            this.totalVes.Name = "totalVes";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridVentas);
            this.Controls.Add(this.button13);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Ventas del dia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalUsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVes;
    }
}