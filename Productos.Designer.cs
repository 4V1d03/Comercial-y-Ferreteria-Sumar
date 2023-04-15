namespace Comercial_y_Ferreteria_Sumar
{
    partial class Productos
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
            this.components = new System.ComponentModel.Container();
            this.btneliminarProd = new System.Windows.Forms.Button();
            this.btnactualizarProd = new System.Windows.Forms.Button();
            this.btnagregarPROD = new System.Windows.Forms.Button();
            this.dgvproductosPROD = new System.Windows.Forms.DataGridView();
            this.cbcategoriaPROD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbproveedorPROD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprecioPROD = new System.Windows.Forms.TextBox();
            this.txtExistenciaPROD = new System.Windows.Forms.TextBox();
            this.txtnombrePROD = new System.Windows.Forms.TextBox();
            this.txtdescripcionPROD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnmenuPROD = new System.Windows.Forms.Button();
            this.epPROD = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosPROD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPROD)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminarProd
            // 
            this.btneliminarProd.Location = new System.Drawing.Point(786, 542);
            this.btneliminarProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneliminarProd.Name = "btneliminarProd";
            this.btneliminarProd.Size = new System.Drawing.Size(119, 52);
            this.btneliminarProd.TabIndex = 28;
            this.btneliminarProd.Text = "Eliminar";
            this.btneliminarProd.UseVisualStyleBackColor = true;
            this.btneliminarProd.Click += new System.EventHandler(this.btneliminarProd_Click);
            // 
            // btnactualizarProd
            // 
            this.btnactualizarProd.Location = new System.Drawing.Point(786, 464);
            this.btnactualizarProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnactualizarProd.Name = "btnactualizarProd";
            this.btnactualizarProd.Size = new System.Drawing.Size(119, 52);
            this.btnactualizarProd.TabIndex = 27;
            this.btnactualizarProd.Text = "Actualizar";
            this.btnactualizarProd.UseVisualStyleBackColor = true;
            this.btnactualizarProd.Click += new System.EventHandler(this.btnactualizarProd_Click);
            // 
            // btnagregarPROD
            // 
            this.btnagregarPROD.Location = new System.Drawing.Point(786, 385);
            this.btnagregarPROD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnagregarPROD.Name = "btnagregarPROD";
            this.btnagregarPROD.Size = new System.Drawing.Size(119, 52);
            this.btnagregarPROD.TabIndex = 26;
            this.btnagregarPROD.Text = "Agregar";
            this.btnagregarPROD.UseVisualStyleBackColor = true;
            this.btnagregarPROD.Click += new System.EventHandler(this.btnagregarPROD_Click);
            // 
            // dgvproductosPROD
            // 
            this.dgvproductosPROD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductosPROD.Location = new System.Drawing.Point(43, 385);
            this.dgvproductosPROD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvproductosPROD.Name = "dgvproductosPROD";
            this.dgvproductosPROD.RowHeadersWidth = 51;
            this.dgvproductosPROD.RowTemplate.Height = 25;
            this.dgvproductosPROD.Size = new System.Drawing.Size(721, 209);
            this.dgvproductosPROD.TabIndex = 25;
            this.dgvproductosPROD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductosPROD_CellDoubleClick);
            // 
            // cbcategoriaPROD
            // 
            this.cbcategoriaPROD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoriaPROD.FormattingEnabled = true;
            this.cbcategoriaPROD.Location = new System.Drawing.Point(132, 114);
            this.cbcategoriaPROD.Name = "cbcategoriaPROD";
            this.cbcategoriaPROD.Size = new System.Drawing.Size(209, 28);
            this.cbcategoriaPROD.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Proveedor";
            // 
            // cbproveedorPROD
            // 
            this.cbproveedorPROD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproveedorPROD.FormattingEnabled = true;
            this.cbproveedorPROD.Location = new System.Drawing.Point(489, 114);
            this.cbproveedorPROD.Name = "cbproveedorPROD";
            this.cbproveedorPROD.Size = new System.Drawing.Size(209, 28);
            this.cbproveedorPROD.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Existencia";
            // 
            // txtprecioPROD
            // 
            this.txtprecioPROD.Location = new System.Drawing.Point(132, 190);
            this.txtprecioPROD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprecioPROD.Name = "txtprecioPROD";
            this.txtprecioPROD.Size = new System.Drawing.Size(242, 27);
            this.txtprecioPROD.TabIndex = 36;
            this.txtprecioPROD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioPROD_KeyPress);
            this.txtprecioPROD.Validating += new System.ComponentModel.CancelEventHandler(this.txtprecioPROD_Validating);
            // 
            // txtExistenciaPROD
            // 
            this.txtExistenciaPROD.Location = new System.Drawing.Point(489, 273);
            this.txtExistenciaPROD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExistenciaPROD.Name = "txtExistenciaPROD";
            this.txtExistenciaPROD.Size = new System.Drawing.Size(242, 27);
            this.txtExistenciaPROD.TabIndex = 37;
            this.txtExistenciaPROD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistenciaPROD_KeyPress);
            this.txtExistenciaPROD.Validating += new System.ComponentModel.CancelEventHandler(this.txtExistenciaPROD_Validating);
            // 
            // txtnombrePROD
            // 
            this.txtnombrePROD.Location = new System.Drawing.Point(489, 193);
            this.txtnombrePROD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombrePROD.Name = "txtnombrePROD";
            this.txtnombrePROD.Size = new System.Drawing.Size(242, 27);
            this.txtnombrePROD.TabIndex = 38;
            this.txtnombrePROD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrePROD_KeyPress);
            this.txtnombrePROD.Validating += new System.ComponentModel.CancelEventHandler(this.txtnombrePROD_Validating);
            // 
            // txtdescripcionPROD
            // 
            this.txtdescripcionPROD.Location = new System.Drawing.Point(132, 273);
            this.txtdescripcionPROD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdescripcionPROD.Name = "txtdescripcionPROD";
            this.txtdescripcionPROD.Size = new System.Drawing.Size(242, 27);
            this.txtdescripcionPROD.TabIndex = 40;
            this.txtdescripcionPROD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcionPROD_KeyPress);
            this.txtdescripcionPROD.Validating += new System.ComponentModel.CancelEventHandler(this.txtdescripcionPROD_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Descrpcion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(239, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(356, 41);
            this.label10.TabIndex = 41;
            this.label10.Text = "Inventario de Productos";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(347, 337);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 35);
            this.btnbuscar.TabIndex = 75;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Buscar :";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(112, 341);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(229, 27);
            this.txtbuscar.TabIndex = 73;
            // 
            // btnmenuPROD
            // 
            this.btnmenuPROD.Location = new System.Drawing.Point(786, 15);
            this.btnmenuPROD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnmenuPROD.Name = "btnmenuPROD";
            this.btnmenuPROD.Size = new System.Drawing.Size(119, 52);
            this.btnmenuPROD.TabIndex = 76;
            this.btnmenuPROD.Text = "Menu";
            this.btnmenuPROD.UseVisualStyleBackColor = true;
            this.btnmenuPROD.Click += new System.EventHandler(this.btnmenuPROD_Click);
            // 
            // epPROD
            // 
            this.epPROD.ContainerControl = this;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 621);
            this.Controls.Add(this.btnmenuPROD);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdescripcionPROD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnombrePROD);
            this.Controls.Add(this.txtExistenciaPROD);
            this.Controls.Add(this.txtprecioPROD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbproveedorPROD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbcategoriaPROD);
            this.Controls.Add(this.btneliminarProd);
            this.Controls.Add(this.btnactualizarProd);
            this.Controls.Add(this.btnagregarPROD);
            this.Controls.Add(this.dgvproductosPROD);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosPROD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPROD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btneliminarProd;
        private Button btnactualizarProd;
        private Button btnagregarPROD;
        private DataGridView dgvproductosPROD;
        private ComboBox cbcategoriaPROD;
        private Label label1;
        private Label label2;
        private ComboBox cbproveedorPROD;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtprecioPROD;
        private TextBox txtExistenciaPROD;
        private TextBox txtnombrePROD;
        private TextBox txtdescripcionPROD;
        private Label label6;
        private Label label10;
        private Button btnbuscar;
        private Label label7;
        private TextBox txtbuscar;
        private Button btnmenuPROD;
        private ErrorProvider epPROD;
    }
}