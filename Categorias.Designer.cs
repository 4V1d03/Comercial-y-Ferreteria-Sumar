namespace Comercial_y_Ferreteria_Sumar
{
    partial class Categorias
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
            this.btneliminarCAT = new System.Windows.Forms.Button();
            this.btnactualizarCAT = new System.Windows.Forms.Button();
            this.btnagregarCAT = new System.Windows.Forms.Button();
            this.dgvCategoriasCAT = new System.Windows.Forms.DataGridView();
            this.txtnombreCAT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnmenuCAT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriasCAT)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminarCAT
            // 
            this.btneliminarCAT.Location = new System.Drawing.Point(776, 472);
            this.btneliminarCAT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneliminarCAT.Name = "btneliminarCAT";
            this.btneliminarCAT.Size = new System.Drawing.Size(119, 52);
            this.btneliminarCAT.TabIndex = 60;
            this.btneliminarCAT.Text = "Eliminar";
            this.btneliminarCAT.UseVisualStyleBackColor = true;
            this.btneliminarCAT.Click += new System.EventHandler(this.btneliminarCAT_Click);
            // 
            // btnactualizarCAT
            // 
            this.btnactualizarCAT.Location = new System.Drawing.Point(776, 394);
            this.btnactualizarCAT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnactualizarCAT.Name = "btnactualizarCAT";
            this.btnactualizarCAT.Size = new System.Drawing.Size(119, 52);
            this.btnactualizarCAT.TabIndex = 59;
            this.btnactualizarCAT.Text = "Actualizar";
            this.btnactualizarCAT.UseVisualStyleBackColor = true;
            this.btnactualizarCAT.Click += new System.EventHandler(this.btnactualizarCAT_Click);
            // 
            // btnagregarCAT
            // 
            this.btnagregarCAT.Location = new System.Drawing.Point(776, 315);
            this.btnagregarCAT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnagregarCAT.Name = "btnagregarCAT";
            this.btnagregarCAT.Size = new System.Drawing.Size(119, 52);
            this.btnagregarCAT.TabIndex = 58;
            this.btnagregarCAT.Text = "Agregar";
            this.btnagregarCAT.UseVisualStyleBackColor = true;
            this.btnagregarCAT.Click += new System.EventHandler(this.btnagregarCAT_Click);
            // 
            // dgvCategoriasCAT
            // 
            this.dgvCategoriasCAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriasCAT.Location = new System.Drawing.Point(33, 315);
            this.dgvCategoriasCAT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCategoriasCAT.Name = "dgvCategoriasCAT";
            this.dgvCategoriasCAT.RowHeadersWidth = 51;
            this.dgvCategoriasCAT.RowTemplate.Height = 25;
            this.dgvCategoriasCAT.Size = new System.Drawing.Size(721, 209);
            this.dgvCategoriasCAT.TabIndex = 57;
            this.dgvCategoriasCAT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriasCAT_CellClick);
            // 
            // txtnombreCAT
            // 
            this.txtnombreCAT.Location = new System.Drawing.Point(342, 165);
            this.txtnombreCAT.Name = "txtnombreCAT";
            this.txtnombreCAT.Size = new System.Drawing.Size(242, 27);
            this.txtnombreCAT.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(231, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(421, 41);
            this.label10.TabIndex = 63;
            this.label10.Text = "Adminitración de Categorias";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(324, 273);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 35);
            this.btnbuscar.TabIndex = 66;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Buscar :";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(89, 277);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(229, 27);
            this.txtbuscar.TabIndex = 64;
            // 
            // btnmenuCAT
            // 
            this.btnmenuCAT.Location = new System.Drawing.Point(812, 13);
            this.btnmenuCAT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnmenuCAT.Name = "btnmenuCAT";
            this.btnmenuCAT.Size = new System.Drawing.Size(119, 52);
            this.btnmenuCAT.TabIndex = 67;
            this.btnmenuCAT.Text = "Menu";
            this.btnmenuCAT.UseVisualStyleBackColor = true;
            this.btnmenuCAT.Click += new System.EventHandler(this.btnmenuCAT_Click);
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 561);
            this.Controls.Add(this.btnmenuCAT);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtnombreCAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btneliminarCAT);
            this.Controls.Add(this.btnactualizarCAT);
            this.Controls.Add(this.btnagregarCAT);
            this.Controls.Add(this.dgvCategoriasCAT);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriasCAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btneliminarCAT;
        private Button btnactualizarCAT;
        private Button btnagregarCAT;
        private DataGridView dgvCategoriasCAT;
        private TextBox txtnombreCAT;
        private Label label6;
        private Label label10;
        private Button btnbuscar;
        private Label label1;
        private TextBox txtbuscar;
        private Button btnmenuCAT;
    }
}