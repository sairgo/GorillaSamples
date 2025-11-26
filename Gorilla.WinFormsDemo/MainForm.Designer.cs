namespace Gorilla.WinFormsDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            btnCargar = new Button();
            btnCargarAsync = new Button();
            cboCategoria = new ComboBox();
            lblStatus = new Label();
            btnFacturaDemo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(23, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(765, 232);
            dgvProductos.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(203, 261);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(180, 29);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar datos";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnCargarAsync
            // 
            btnCargarAsync.Location = new Point(203, 296);
            btnCargarAsync.Name = "btnCargarAsync";
            btnCargarAsync.Size = new Size(180, 29);
            btnCargarAsync.TabIndex = 2;
            btnCargarAsync.Text = "Cargar Datos (async)";
            btnCargarAsync.UseVisualStyleBackColor = true;
            btnCargarAsync.Click += btnCargarAsync_Click;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(23, 262);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(151, 28);
            cboCategoria.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(400, 280);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(43, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Listo.";
            // 
            // btnFacturaDemo
            // 
            btnFacturaDemo.Location = new Point(203, 331);
            btnFacturaDemo.Name = "btnFacturaDemo";
            btnFacturaDemo.Size = new Size(180, 29);
            btnFacturaDemo.TabIndex = 5;
            btnFacturaDemo.Text = "Probar Factura";
            btnFacturaDemo.UseVisualStyleBackColor = true;
            btnFacturaDemo.Click += btnFacturaDemo_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFacturaDemo);
            Controls.Add(lblStatus);
            Controls.Add(cboCategoria);
            Controls.Add(btnCargarAsync);
            Controls.Add(btnCargar);
            Controls.Add(dgvProductos);
            Name = "MainForm";
            Text = "Gorilla WinForms Demo";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnCargar;
        private Button btnCargarAsync;
        private ComboBox cboCategoria;
        private Label lblStatus;
        private Button btnFacturaDemo;
    }
}
