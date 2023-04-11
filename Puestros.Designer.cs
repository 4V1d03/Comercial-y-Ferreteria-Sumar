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
            this.dgvcomprasCOM = new System.Windows.Forms.DataGridView();
            this.txtnombrePROV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomprasCOM)).BeginInit();
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
            // 
            // dgvcomprasCOM
            // 
            this.dgvcomprasCOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcomprasCOM.Location = new System.Drawing.Point(48, 337);
            this.dgvcomprasCOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvcomprasCOM.Name = "dgvcomprasCOM";
            this.dgvcomprasCOM.RowHeadersWidth = 51;
            this.dgvcomprasCOM.RowTemplate.Height = 25;
            this.dgvcomprasCOM.Size = new System.Drawing.Size(721, 209);
            this.dgvcomprasCOM.TabIndex = 57;
            // 
            // txtnombrePROV
            // 
            this.txtnombrePROV.Location = new System.Drawing.Point(335, 195);
            this.txtnombrePROV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombrePROV.Name = "txtnombrePROV";
            this.txtnombrePROV.Size = new System.Drawing.Size(242, 27);
            this.txtnombrePROV.TabIndex = 62;
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
            // Puestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 582);
            this.Controls.Add(this.txtnombrePROV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminarCOM);
            this.Controls.Add(this.btnactualizarCOM);
            this.Controls.Add(this.btnagregarCOM);
            this.Controls.Add(this.dgvcomprasCOM);
            this.Controls.Add(this.label10);
            this.Name = "Puestros";
            this.Text = "Puestros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomprasCOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private Button btneliminarCOM;
        private Button btnactualizarCOM;
        private Button btnagregarCOM;
        private DataGridView dgvcomprasCOM;
        private TextBox txtnombrePROV;
        private Label label1;
    }
}