namespace presentacion
{
    partial class frmDetalleArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleArticulo));
            this.lblArticulo = new System.Windows.Forms.Label();
            this.pbxImgArticulo = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCatergoria = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblDetallePrecio = new System.Windows.Forms.Label();
            this.lblDetalleCodigo = new System.Windows.Forms.Label();
            this.lblDetalleNombre = new System.Windows.Forms.Label();
            this.lblDetalleDescripcion = new System.Windows.Forms.Label();
            this.lblDetalleMarca = new System.Windows.Forms.Label();
            this.lblDetalleCategoria = new System.Windows.Forms.Label();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulo
            // 
            this.lblArticulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblArticulo.Location = new System.Drawing.Point(415, 38);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(254, 38);
            this.lblArticulo.TabIndex = 70;
            this.lblArticulo.Text = "Detalle Artículo";
            // 
            // pbxImgArticulo
            // 
            this.pbxImgArticulo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxImgArticulo.ErrorImage")));
            this.pbxImgArticulo.Image = ((System.Drawing.Image)(resources.GetObject("pbxImgArticulo.Image")));
            this.pbxImgArticulo.Location = new System.Drawing.Point(320, 12);
            this.pbxImgArticulo.Name = "pbxImgArticulo";
            this.pbxImgArticulo.Size = new System.Drawing.Size(90, 90);
            this.pbxImgArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImgArticulo.TabIndex = 87;
            this.pbxImgArticulo.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCodigo.Location = new System.Drawing.Point(20, 159);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(98, 25);
            this.lblCodigo.TabIndex = 88;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(20, 240);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(106, 25);
            this.lblNombre.TabIndex = 89;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 321);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(142, 25);
            this.lblDescripcion.TabIndex = 90;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMarca.Location = new System.Drawing.Point(20, 402);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(92, 25);
            this.lblMarca.TabIndex = 91;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCatergoria
            // 
            this.lblCatergoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCatergoria.AutoSize = true;
            this.lblCatergoria.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatergoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCatergoria.Location = new System.Drawing.Point(20, 483);
            this.lblCatergoria.Name = "lblCatergoria";
            this.lblCatergoria.Size = new System.Drawing.Size(130, 25);
            this.lblCatergoria.TabIndex = 92;
            this.lblCatergoria.Text = "Categoría:";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxArticulo.Location = new System.Drawing.Point(738, 159);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(346, 325);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 93;
            this.pbxArticulo.TabStop = false;
            // 
            // lblDetallePrecio
            // 
            this.lblDetallePrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetallePrecio.AutoSize = true;
            this.lblDetallePrecio.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallePrecio.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDetallePrecio.Location = new System.Drawing.Point(841, 487);
            this.lblDetallePrecio.Name = "lblDetallePrecio";
            this.lblDetallePrecio.Size = new System.Drawing.Size(0, 34);
            this.lblDetallePrecio.TabIndex = 94;
            // 
            // lblDetalleCodigo
            // 
            this.lblDetalleCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalleCodigo.AutoSize = true;
            this.lblDetalleCodigo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleCodigo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDetalleCodigo.Location = new System.Drawing.Point(233, 158);
            this.lblDetalleCodigo.Name = "lblDetalleCodigo";
            this.lblDetalleCodigo.Size = new System.Drawing.Size(0, 26);
            this.lblDetalleCodigo.TabIndex = 95;
            // 
            // lblDetalleNombre
            // 
            this.lblDetalleNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalleNombre.AutoSize = true;
            this.lblDetalleNombre.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDetalleNombre.Location = new System.Drawing.Point(233, 240);
            this.lblDetalleNombre.Name = "lblDetalleNombre";
            this.lblDetalleNombre.Size = new System.Drawing.Size(0, 26);
            this.lblDetalleNombre.TabIndex = 96;
            // 
            // lblDetalleDescripcion
            // 
            this.lblDetalleDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalleDescripcion.AutoSize = true;
            this.lblDetalleDescripcion.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleDescripcion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDetalleDescripcion.Location = new System.Drawing.Point(233, 322);
            this.lblDetalleDescripcion.Name = "lblDetalleDescripcion";
            this.lblDetalleDescripcion.Size = new System.Drawing.Size(0, 26);
            this.lblDetalleDescripcion.TabIndex = 97;
            // 
            // lblDetalleMarca
            // 
            this.lblDetalleMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalleMarca.AutoSize = true;
            this.lblDetalleMarca.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleMarca.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDetalleMarca.Location = new System.Drawing.Point(233, 404);
            this.lblDetalleMarca.Name = "lblDetalleMarca";
            this.lblDetalleMarca.Size = new System.Drawing.Size(0, 26);
            this.lblDetalleMarca.TabIndex = 98;
            // 
            // lblDetalleCategoria
            // 
            this.lblDetalleCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalleCategoria.AutoSize = true;
            this.lblDetalleCategoria.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDetalleCategoria.Location = new System.Drawing.Point(233, 486);
            this.lblDetalleCategoria.Name = "lblDetalleCategoria";
            this.lblDetalleCategoria.Size = new System.Drawing.Size(0, 26);
            this.lblDetalleCategoria.TabIndex = 99;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(135)))), ((int)(((byte)(185)))));
            this.btnAceptar.FlatAppearance.BorderSize = 3;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(135)))), ((int)(((byte)(185)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnAceptar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptar.IconSize = 32;
            this.btnAceptar.Location = new System.Drawing.Point(374, 560);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(153, 84);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Salir";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1124, 664);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDetalleCategoria);
            this.Controls.Add(this.lblDetalleMarca);
            this.Controls.Add(this.lblDetalleDescripcion);
            this.Controls.Add(this.lblDetalleNombre);
            this.Controls.Add(this.lblDetalleCodigo);
            this.Controls.Add(this.lblDetallePrecio);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lblCatergoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pbxImgArticulo);
            this.Controls.Add(this.lblArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1146, 720);
            this.MinimumSize = new System.Drawing.Size(1146, 720);
            this.Name = "frmDetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleArticulo";
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.PictureBox pbxImgArticulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCatergoria;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblDetallePrecio;
        private System.Windows.Forms.Label lblDetalleCodigo;
        private System.Windows.Forms.Label lblDetalleNombre;
        private System.Windows.Forms.Label lblDetalleDescripcion;
        private System.Windows.Forms.Label lblDetalleMarca;
        private System.Windows.Forms.Label lblDetalleCategoria;
        private FontAwesome.Sharp.IconButton btnAceptar;
    }
}