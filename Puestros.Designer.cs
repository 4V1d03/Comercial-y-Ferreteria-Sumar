namespace Comercial_y_Ferreteria_Sumar
{
    partial class Puestros
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
            this.label10 = new System.Windows.Forms.Label();
            this.btneliminarCOM = new System.Windows.Forms.Button();
            this.btnactualizarCOM = new System.Windows.Forms.Button();
            this.btnagregarCOM = new System.Windows.Forms.Button();
            this.dgvpuestosPUE = new System.Windows.Forms.DataGridView();
            this.txtnombrePUE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnmenuPUE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpuestosPUE)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(253, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(379, 41);
            this.label10.TabIndex = 51;
            this.label10.Text = "Adminitración de Puestos";
            // 
            // btneliminarCOM
            // 
            this.btneliminarCOM.Location = new System.Drawing.Point(791, 494);
            this.btneliminarCOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneliminarCOM.Name = "btneliminarCOM";
            this.btneliminarCOM.Size = new System.Drawing.Size(119, 52);
            this.btneliminarCOM.TabIndex = 60;
            this.btneliminarCOM.Text = "Eliminar";
            this.btneliminarCOM.UseVisualStyleBackColor = true;
            this.btneliminarCOM.Click += new System.EventHandler(this.btneliminarCOM_Click);
            // 
            // btnactualizarCOM
            // 
            this.btnactualizarCOM.Location = new System.Drawing.Point(791, 416);
            this.btnactualizarCOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnactualizarCOM.Name = "btnactualizarCOM";
            this.btnactualizarCOM.Size = new System.Drawing.Size(119, 52);
            this.btnactualizarCOM.TabIndex = 59;
            this.btnactualizarCOM.Text = "Actualizar";
            this.btnactualizarCOM.UseVisualStyleBackColor = true;
            this.btnactualizarCOM.Click += new System.EventHandler(this.btnactualizarCOM_Click);
            // 
            // btnagregarCOM
            // 
            this.btnagregarCOM.Location = new System.Drawing.Point(791, 337);
            this.btnagregarCOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnagregarCOM.Name = "btnagregarCOM";
            this.btnagregarCOM.Size = new System.Drawing.Size(119, 52);
            this.btnagregarCOM.TabIndex = 58;
            this.btnagregarCOM.Text = "Agregar";
            this.btnagregarCOM.UseVisualStyleBackColor = true;
            this.btnagregarCOM.Click += new System.EventHandler(this.btnagregarCOM_Click);
            // 
            // dgvpuestosPUE
            // 
            this.dgvpuestosPUE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpuestosPUE.Location = new System.Drawing.Point(48, 337);
            this.dgvpuestosPUE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvpuestosPUE.Name = "dgvpuestosPUE";
            this.dgvpuestosPUE.RowHeadersWidth = 51;
            this.dgvpuestosPUE.RowTemplate.Height = 25;
            this.dgvpuestosPUE.Size = new System.Drawing.Size(721, 209);
            this.dgvpuestosPUE.TabIndex = 57;
            this.dgvpuestosPUE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpuestosPUE_CellClick);
            // 
            // txtnombrePUE
            // 
            this.txtnombrePUE.Location = new System.Drawing.Point(335, 195);
            this.txtnombrePUE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombrePUE.Name = "txtnombrePUE";
            this.txtnombrePUE.Size = new System.Drawing.Size(242, 27);
            this.txtnombrePUE.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nombre Puesto";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(346, 296);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 35);
            this.btnbuscar.TabIndex = 69;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Buscar :";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(111, 300);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(229, 27);
            this.txtbuscar.TabIndex = 67;
            // 
            // btnmenuPUE
            // 
            this.btnmenuPUE.Location = new System.Drawing.Point(791, 21);
            this.btnmenuPUE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnmenuPUE.Name = "btnmenuPUE";
            this.btnmenuPUE.Size = new System.Drawing.Size(119, 52);
            this.btnmenuPUE.TabIndex = 77;
            this.btnmenuPUE.Text = "Menu";
            this.btnmenuPUE.UseVisualStyleBackColor = true;
            this.btnmenuPUE.Click += new System.EventHandler(this.btnmenuPUE_Click);
            // 
            // Puestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 582);
            this.Controls.Add(this.btnmenuPUE);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.txtnombrePUE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminarCOM);
            this.Controls.Add(this.btnactualizarCOM);
            this.Controls.Add(this.btnagregarCOM);
            this.Controls.Add(this.dgvpuestosPUE);
            this.Controls.Add(this.label10);
            this.Name = "Puestros";
            this.Text = "Puestros";
            this.Load += new System.EventHandler(this.Puestros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpuestosPUE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private Button btneliminarCOM;
        private Button btnactualizarCOM;
        private Button btnagregarCOM;
        private DataGridView dgvpuestosPUE;
        private TextBox txtnombrePUE;
        private Label label1;
        private Button btnbuscar;
        private Label label2;
        private TextBox txtbuscar;
        private Button btnmenuPUE;
    }
}