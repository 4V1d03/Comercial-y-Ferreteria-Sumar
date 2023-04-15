namespace Comercial_y_Ferreteria_Sumar
{
    partial class Compras
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
            this.dtpfechaCOM = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbempleadoCOM = new System.Windows.Forms.ComboBox();
            this.cbproveedorCOM = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btneliminarCOM = new System.Windows.Forms.Button();
            this.btnactualizarCOM = new System.Windows.Forms.Button();
            this.btnagregarCOM = new System.Windows.Forms.Button();
            this.dgvcomprasCOM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmenuCOM = new System.Windows.Forms.Button();
            this.cbproductoCOM = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpreciocostoCOM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidadCOM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblcantidadapagarVT = new System.Windows.Forms.Label();
            this.txtimpuestoVT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltotalapagarVT = new System.Windows.Forms.Label();
            this.txtsubtotalVT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.epCOM = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomprasCOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCOM)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpfechaCOM
            // 
            this.dtpfechaCOM.Location = new System.Drawing.Point(190, 216);
            this.dtpfechaCOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpfechaCOM.Name = "dtpfechaCOM";
            this.dtpfechaCOM.Size = new System.Drawing.Size(209, 27);
            this.dtpfechaCOM.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Empleado";
            // 
            // cbempleadoCOM
            // 
            this.cbempleadoCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbempleadoCOM.FormattingEnabled = true;
            this.cbempleadoCOM.Location = new System.Drawing.Point(190, 130);
            this.cbempleadoCOM.Name = "cbempleadoCOM";
            this.cbempleadoCOM.Size = new System.Drawing.Size(209, 28);
            this.cbempleadoCOM.TabIndex = 30;
            // 
            // cbproveedorCOM
            // 
            this.cbproveedorCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproveedorCOM.FormattingEnabled = true;
            this.cbproveedorCOM.Location = new System.Drawing.Point(530, 125);
            this.cbproveedorCOM.Name = "cbproveedorCOM";
            this.cbproveedorCOM.Size = new System.Drawing.Size(209, 28);
            this.cbproveedorCOM.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(234, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(395, 41);
            this.label10.TabIndex = 52;
            this.label10.Text = "Adminitración de Compras";
            // 
            // btneliminarCOM
            // 
            this.btneliminarCOM.Location = new System.Drawing.Point(804, 586);
            this.btneliminarCOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneliminarCOM.Name = "btneliminarCOM";
            this.btneliminarCOM.Size = new System.Drawing.Size(119, 52);
            this.btneliminarCOM.TabIndex = 56;
            this.btneliminarCOM.Text = "Eliminar";
            this.btneliminarCOM.UseVisualStyleBackColor = true;
            this.btneliminarCOM.Click += new System.EventHandler(this.btneliminarCOM_Click);
            // 
            // btnactualizarCOM
            // 
            this.btnactualizarCOM.Location = new System.Drawing.Point(804, 508);
            this.btnactualizarCOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnactualizarCOM.Name = "btnactualizarCOM";
            this.btnactualizarCOM.Size = new System.Drawing.Size(119, 52);
            this.btnactualizarCOM.TabIndex = 55;
            this.btnactualizarCOM.Text = "Actualizar";
            this.btnactualizarCOM.UseVisualStyleBackColor = true;
            this.btnactualizarCOM.Click += new System.EventHandler(this.btnactualizarCOM_Click);
            // 
            // btnagregarCOM
            // 
            this.btnagregarCOM.Location = new System.Drawing.Point(804, 429);
            this.btnagregarCOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnagregarCOM.Name = "btnagregarCOM";
            this.btnagregarCOM.Size = new System.Drawing.Size(119, 52);
            this.btnagregarCOM.TabIndex = 54;
            this.btnagregarCOM.Text = "Agregar";
            this.btnagregarCOM.UseVisualStyleBackColor = true;
            this.btnagregarCOM.Click += new System.EventHandler(this.btnagregarCOM_Click);
            // 
            // dgvcomprasCOM
            // 
            this.dgvcomprasCOM.AllowUserToAddRows = false;
            this.dgvcomprasCOM.AllowUserToDeleteRows = false;
            this.dgvcomprasCOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcomprasCOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvcomprasCOM.Location = new System.Drawing.Point(61, 429);
            this.dgvcomprasCOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvcomprasCOM.Name = "dgvcomprasCOM";
            this.dgvcomprasCOM.ReadOnly = true;
            this.dgvcomprasCOM.RowHeadersWidth = 51;
            this.dgvcomprasCOM.RowTemplate.Height = 25;
            this.dgvcomprasCOM.Size = new System.Drawing.Size(721, 209);
            this.dgvcomprasCOM.TabIndex = 53;
            this.dgvcomprasCOM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcomprasCOM_CellClick);
            this.dgvcomprasCOM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcomprasCOM_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CodigoCompra";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CodigoProducto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PrecioCosto";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // btnmenuCOM
            // 
            this.btnmenuCOM.Location = new System.Drawing.Point(805, 22);
            this.btnmenuCOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnmenuCOM.Name = "btnmenuCOM";
            this.btnmenuCOM.Size = new System.Drawing.Size(119, 52);
            this.btnmenuCOM.TabIndex = 77;
            this.btnmenuCOM.Text = "Menu";
            this.btnmenuCOM.UseVisualStyleBackColor = true;
            this.btnmenuCOM.Click += new System.EventHandler(this.btnmenuCOM_Click);
            // 
            // cbproductoCOM
            // 
            this.cbproductoCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproductoCOM.FormattingEnabled = true;
            this.cbproductoCOM.Location = new System.Drawing.Point(530, 213);
            this.cbproductoCOM.Name = "cbproductoCOM";
            this.cbproductoCOM.Size = new System.Drawing.Size(205, 28);
            this.cbproductoCOM.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 79;
            this.label6.Text = "Producto";
            // 
            // txtpreciocostoCOM
            // 
            this.txtpreciocostoCOM.Location = new System.Drawing.Point(186, 302);
            this.txtpreciocostoCOM.Name = "txtpreciocostoCOM";
            this.txtpreciocostoCOM.Size = new System.Drawing.Size(209, 27);
            this.txtpreciocostoCOM.TabIndex = 82;
            this.txtpreciocostoCOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciocostoCOM_KeyPress);
            this.txtpreciocostoCOM.Validating += new System.ComponentModel.CancelEventHandler(this.txtpreciocostoCOM_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 81;
            this.label4.Text = "Precio Costo";
            // 
            // txtcantidadCOM
            // 
            this.txtcantidadCOM.Location = new System.Drawing.Point(526, 298);
            this.txtcantidadCOM.Name = "txtcantidadCOM";
            this.txtcantidadCOM.Size = new System.Drawing.Size(209, 27);
            this.txtcantidadCOM.TabIndex = 84;
            this.txtcantidadCOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidadCOM_KeyPress);
            this.txtcantidadCOM.Validating += new System.ComponentModel.CancelEventHandler(this.txtcantidadCOM_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "Cantidad";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(804, 355);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(119, 52);
            this.btnComprar.TabIndex = 85;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // lblcantidadapagarVT
            // 
            this.lblcantidadapagarVT.AutoSize = true;
            this.lblcantidadapagarVT.Location = new System.Drawing.Point(627, 383);
            this.lblcantidadapagarVT.Name = "lblcantidadapagarVT";
            this.lblcantidadapagarVT.Size = new System.Drawing.Size(44, 20);
            this.lblcantidadapagarVT.TabIndex = 91;
            this.lblcantidadapagarVT.Text = "00.00";
            // 
            // txtimpuestoVT
            // 
            this.txtimpuestoVT.Location = new System.Drawing.Point(371, 380);
            this.txtimpuestoVT.Name = "txtimpuestoVT";
            this.txtimpuestoVT.Size = new System.Drawing.Size(135, 27);
            this.txtimpuestoVT.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 89;
            this.label8.Text = "Impuesto";
            // 
            // lbltotalapagarVT
            // 
            this.lbltotalapagarVT.AutoSize = true;
            this.lbltotalapagarVT.Location = new System.Drawing.Point(523, 383);
            this.lbltotalapagarVT.Name = "lbltotalapagarVT";
            this.lbltotalapagarVT.Size = new System.Drawing.Size(98, 20);
            this.lbltotalapagarVT.TabIndex = 88;
            this.lbltotalapagarVT.Text = "Total a Pagar:\r\n";
            // 
            // txtsubtotalVT
            // 
            this.txtsubtotalVT.Location = new System.Drawing.Point(135, 380);
            this.txtsubtotalVT.Name = "txtsubtotalVT";
            this.txtsubtotalVT.Size = new System.Drawing.Size(135, 27);
            this.txtsubtotalVT.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "Subtotal";
            // 
            // epCOM
            // 
            this.epCOM.ContainerControl = this;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 662);
            this.Controls.Add(this.lblcantidadapagarVT);
            this.Controls.Add(this.txtimpuestoVT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbltotalapagarVT);
            this.Controls.Add(this.txtsubtotalVT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtcantidadCOM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpreciocostoCOM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbproductoCOM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnmenuCOM);
            this.Controls.Add(this.btneliminarCOM);
            this.Controls.Add(this.btnactualizarCOM);
            this.Controls.Add(this.btnagregarCOM);
            this.Controls.Add(this.dgvcomprasCOM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbproveedorCOM);
            this.Controls.Add(this.cbempleadoCOM);
            this.Controls.Add(this.dtpfechaCOM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomprasCOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker dtpfechaCOM;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbempleadoCOM;
        private ComboBox cbproveedorCOM;
        private Label label10;
        private Button btneliminarCOM;
        private Button btnactualizarCOM;
        private Button btnagregarCOM;
        private DataGridView dgvcomprasCOM;
        private Button btnmenuCOM;
        private ComboBox cbproductoCOM;
        private Label label6;
        private TextBox txtpreciocostoCOM;
        private Label label4;
        private TextBox txtcantidadCOM;
        private Label label5;
        private Button btnComprar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label lblcantidadapagarVT;
        private TextBox txtimpuestoVT;
        private Label label8;
        private Label lbltotalapagarVT;
        private TextBox txtsubtotalVT;
        private Label label7;
        private ErrorProvider epCOM;
    }
}