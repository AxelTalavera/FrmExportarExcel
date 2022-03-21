namespace FrmExportarExcel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnGuardarD = new Guna.UI2.WinForms.Guna2Button();
            this.BtnExportar = new Guna.UI2.WinForms.Guna2Button();
            this.DtgvExcel = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TxtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.BtnGuardarD);
            this.guna2Panel1.Controls.Add(this.BtnExportar);
            this.guna2Panel1.Controls.Add(this.DtgvExcel);
            this.guna2Panel1.Controls.Add(this.TxtTelefono);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.TxtDireccion);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.TxtApellido);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.TxtNombre);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(794, 394);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // BtnGuardarD
            // 
            this.BtnGuardarD.CheckedState.Parent = this.BtnGuardarD;
            this.BtnGuardarD.CustomImages.Parent = this.BtnGuardarD;
            this.BtnGuardarD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardarD.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarD.HoverState.Parent = this.BtnGuardarD;
            this.BtnGuardarD.Location = new System.Drawing.Point(389, 296);
            this.BtnGuardarD.Name = "BtnGuardarD";
            this.BtnGuardarD.ShadowDecoration.Parent = this.BtnGuardarD;
            this.BtnGuardarD.Size = new System.Drawing.Size(161, 45);
            this.BtnGuardarD.TabIndex = 10;
            this.BtnGuardarD.Text = "Guardar";
            this.BtnGuardarD.Click += new System.EventHandler(this.BtnGuardarD_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.CheckedState.Parent = this.BtnExportar;
            this.BtnExportar.CustomImages.Parent = this.BtnExportar;
            this.BtnExportar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExportar.ForeColor = System.Drawing.Color.White;
            this.BtnExportar.HoverState.Parent = this.BtnExportar;
            this.BtnExportar.Location = new System.Drawing.Point(597, 296);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.ShadowDecoration.Parent = this.BtnExportar;
            this.BtnExportar.Size = new System.Drawing.Size(170, 45);
            this.BtnExportar.TabIndex = 9;
            this.BtnExportar.Text = "Exportar ";
            this.BtnExportar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DtgvExcel
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DtgvExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgvExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgvExcel.BackgroundColor = System.Drawing.Color.White;
            this.DtgvExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgvExcel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgvExcel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgvExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgvExcel.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgvExcel.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtgvExcel.EnableHeadersVisualStyles = false;
            this.DtgvExcel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DtgvExcel.Location = new System.Drawing.Point(375, 45);
            this.DtgvExcel.Name = "DtgvExcel";
            this.DtgvExcel.RowHeadersVisible = false;
            this.DtgvExcel.RowHeadersWidth = 51;
            this.DtgvExcel.RowTemplate.Height = 24;
            this.DtgvExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgvExcel.Size = new System.Drawing.Size(392, 229);
            this.DtgvExcel.TabIndex = 8;
            this.DtgvExcel.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DtgvExcel.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DtgvExcel.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DtgvExcel.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DtgvExcel.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DtgvExcel.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DtgvExcel.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DtgvExcel.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DtgvExcel.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DtgvExcel.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgvExcel.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtgvExcel.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DtgvExcel.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DtgvExcel.ThemeStyle.HeaderStyle.Height = 4;
            this.DtgvExcel.ThemeStyle.ReadOnly = false;
            this.DtgvExcel.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DtgvExcel.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgvExcel.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtgvExcel.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DtgvExcel.ThemeStyle.RowsStyle.Height = 24;
            this.DtgvExcel.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DtgvExcel.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DtgvExcel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvExcel_CellClick);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTelefono.DefaultText = "";
            this.TxtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTelefono.DisabledState.Parent = this.TxtTelefono;
            this.TxtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTelefono.FocusedState.Parent = this.TxtTelefono;
            this.TxtTelefono.ForeColor = System.Drawing.Color.Black;
            this.TxtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTelefono.HoverState.Parent = this.TxtTelefono;
            this.TxtTelefono.Location = new System.Drawing.Point(129, 267);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PasswordChar = '\0';
            this.TxtTelefono.PlaceholderText = "";
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.ShadowDecoration.Parent = this.TxtTelefono;
            this.TxtTelefono.Size = new System.Drawing.Size(182, 31);
            this.TxtTelefono.TabIndex = 7;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(27, 278);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(79, 20);
            this.guna2HtmlLabel4.TabIndex = 6;
            this.guna2HtmlLabel4.Text = "Telefono  .";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDireccion.DefaultText = "";
            this.TxtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDireccion.DisabledState.Parent = this.TxtDireccion;
            this.TxtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDireccion.FocusedState.Parent = this.TxtDireccion;
            this.TxtDireccion.ForeColor = System.Drawing.Color.Black;
            this.TxtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDireccion.HoverState.Parent = this.TxtDireccion;
            this.TxtDireccion.Location = new System.Drawing.Point(129, 201);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.PasswordChar = '\0';
            this.TxtDireccion.PlaceholderText = "";
            this.TxtDireccion.SelectedText = "";
            this.TxtDireccion.ShadowDecoration.Parent = this.TxtDireccion;
            this.TxtDireccion.Size = new System.Drawing.Size(182, 31);
            this.TxtDireccion.TabIndex = 5;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(27, 201);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(85, 20);
            this.guna2HtmlLabel3.TabIndex = 4;
            this.guna2HtmlLabel3.Text = "Direccion  .";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtApellido.DefaultText = "";
            this.TxtApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtApellido.DisabledState.Parent = this.TxtApellido;
            this.TxtApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtApellido.FocusedState.Parent = this.TxtApellido;
            this.TxtApellido.ForeColor = System.Drawing.Color.Black;
            this.TxtApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtApellido.HoverState.Parent = this.TxtApellido;
            this.TxtApellido.Location = new System.Drawing.Point(129, 125);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.PasswordChar = '\0';
            this.TxtApellido.PlaceholderText = "";
            this.TxtApellido.SelectedText = "";
            this.TxtApellido.ShadowDecoration.Parent = this.TxtApellido;
            this.TxtApellido.Size = new System.Drawing.Size(182, 31);
            this.TxtApellido.TabIndex = 3;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(28, 125);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(72, 20);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Apellido  .";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.DefaultText = "";
            this.TxtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombre.DisabledState.Parent = this.TxtNombre;
            this.TxtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombre.FocusedState.Parent = this.TxtNombre;
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombre.HoverState.Parent = this.TxtNombre;
            this.TxtNombre.Location = new System.Drawing.Point(129, 45);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.ShadowDecoration.Parent = this.TxtNombre;
            this.TxtNombre.Size = new System.Drawing.Size(182, 31);
            this.TxtNombre.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(27, 45);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(73, 20);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Nombre      .  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 423);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DtgvExcel;
        private Guna.UI2.WinForms.Guna2TextBox TxtTelefono;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox TxtDireccion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox TxtApellido;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox TxtNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button BtnExportar;
        private Guna.UI2.WinForms.Guna2Button BtnGuardarD;
    }
}

