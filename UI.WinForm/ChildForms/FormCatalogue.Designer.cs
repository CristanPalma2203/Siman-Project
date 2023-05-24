namespace UI.WinForm.ChildForms
{
    partial class FormCatalogue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltrasero = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detallesCatalogue = new FontAwesome.Sharp.IconButton();
            this.EleminarCatalogue = new FontAwesome.Sharp.IconButton();
            this.ActualizarCatalogue = new FontAwesome.Sharp.IconButton();
            this.NewCatalogue = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Search = new FontAwesome.Sharp.IconPictureBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.paneltrasero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltrasero
            // 
            this.paneltrasero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.paneltrasero.Controls.Add(this.dataGridView1);
            this.paneltrasero.Location = new System.Drawing.Point(31, 97);
            this.paneltrasero.Name = "paneltrasero";
            this.paneltrasero.Size = new System.Drawing.Size(901, 331);
            this.paneltrasero.TabIndex = 171;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(897, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // detallesCatalogue
            // 
            this.detallesCatalogue.BackColor = System.Drawing.Color.Transparent;
            this.detallesCatalogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.detallesCatalogue.FlatAppearance.BorderSize = 0;
            this.detallesCatalogue.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.detallesCatalogue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.detallesCatalogue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.detallesCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detallesCatalogue.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.detallesCatalogue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detallesCatalogue.ForeColor = System.Drawing.Color.DimGray;
            this.detallesCatalogue.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.detallesCatalogue.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.detallesCatalogue.IconSize = 70;
            this.detallesCatalogue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detallesCatalogue.Location = new System.Drawing.Point(480, 452);
            this.detallesCatalogue.Name = "detallesCatalogue";
            this.detallesCatalogue.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.detallesCatalogue.Rotation = 0D;
            this.detallesCatalogue.Size = new System.Drawing.Size(211, 74);
            this.detallesCatalogue.TabIndex = 170;
            this.detallesCatalogue.Text = "Ver Detalles";
            this.detallesCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.detallesCatalogue.UseVisualStyleBackColor = false;
            this.detallesCatalogue.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // EleminarCatalogue
            // 
            this.EleminarCatalogue.BackColor = System.Drawing.Color.Transparent;
            this.EleminarCatalogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EleminarCatalogue.FlatAppearance.BorderSize = 0;
            this.EleminarCatalogue.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.EleminarCatalogue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.EleminarCatalogue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.EleminarCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EleminarCatalogue.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EleminarCatalogue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EleminarCatalogue.ForeColor = System.Drawing.Color.DimGray;
            this.EleminarCatalogue.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.EleminarCatalogue.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.EleminarCatalogue.IconSize = 70;
            this.EleminarCatalogue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EleminarCatalogue.Location = new System.Drawing.Point(702, 452);
            this.EleminarCatalogue.Name = "EleminarCatalogue";
            this.EleminarCatalogue.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EleminarCatalogue.Rotation = 0D;
            this.EleminarCatalogue.Size = new System.Drawing.Size(229, 74);
            this.EleminarCatalogue.TabIndex = 169;
            this.EleminarCatalogue.Text = "Eliminar Catalogo";
            this.EleminarCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EleminarCatalogue.UseVisualStyleBackColor = false;
            this.EleminarCatalogue.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ActualizarCatalogue
            // 
            this.ActualizarCatalogue.BackColor = System.Drawing.Color.Transparent;
            this.ActualizarCatalogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarCatalogue.FlatAppearance.BorderSize = 0;
            this.ActualizarCatalogue.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ActualizarCatalogue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.ActualizarCatalogue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.ActualizarCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarCatalogue.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ActualizarCatalogue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarCatalogue.ForeColor = System.Drawing.Color.DimGray;
            this.ActualizarCatalogue.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.ActualizarCatalogue.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.ActualizarCatalogue.IconSize = 70;
            this.ActualizarCatalogue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarCatalogue.Location = new System.Drawing.Point(259, 449);
            this.ActualizarCatalogue.Name = "ActualizarCatalogue";
            this.ActualizarCatalogue.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ActualizarCatalogue.Rotation = 0D;
            this.ActualizarCatalogue.Size = new System.Drawing.Size(244, 74);
            this.ActualizarCatalogue.TabIndex = 168;
            this.ActualizarCatalogue.Text = "Actualizar Catalogo";
            this.ActualizarCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ActualizarCatalogue.UseVisualStyleBackColor = false;
            this.ActualizarCatalogue.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // NewCatalogue
            // 
            this.NewCatalogue.BackColor = System.Drawing.Color.Transparent;
            this.NewCatalogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewCatalogue.FlatAppearance.BorderSize = 0;
            this.NewCatalogue.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.NewCatalogue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.NewCatalogue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.NewCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCatalogue.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NewCatalogue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCatalogue.ForeColor = System.Drawing.Color.DimGray;
            this.NewCatalogue.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.NewCatalogue.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.NewCatalogue.IconSize = 70;
            this.NewCatalogue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewCatalogue.Location = new System.Drawing.Point(32, 449);
            this.NewCatalogue.Name = "NewCatalogue";
            this.NewCatalogue.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.NewCatalogue.Rotation = 0D;
            this.NewCatalogue.Size = new System.Drawing.Size(211, 68);
            this.NewCatalogue.TabIndex = 167;
            this.NewCatalogue.Text = "Nuevo Catalogo";
            this.NewCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewCatalogue.UseVisualStyleBackColor = false;
            this.NewCatalogue.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.panel4.Location = new System.Drawing.Point(34, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 1);
            this.panel4.TabIndex = 166;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Search.IconSize = 27;
            this.Search.Location = new System.Drawing.Point(475, 52);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(32, 27);
            this.Search.TabIndex = 165;
            this.Search.TabStop = false;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Label7.ForeColor = System.Drawing.Color.DimGray;
            this.Label7.Location = new System.Drawing.Point(30, 21);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(473, 21);
            this.Label7.TabIndex = 164;
            this.Label7.Text = "Buscar por nombre de producto, descripcion o ID producto:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSearch.Location = new System.Drawing.Point(34, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(442, 20);
            this.txtSearch.TabIndex = 163;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // FormCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 539);
            this.Controls.Add(this.paneltrasero);
            this.Controls.Add(this.detallesCatalogue);
            this.Controls.Add(this.EleminarCatalogue);
            this.Controls.Add(this.ActualizarCatalogue);
            this.Controls.Add(this.NewCatalogue);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtSearch);
            this.Name = "FormCatalogue";
            this.Text = "FormCatalogue";
            this.Load += new System.EventHandler(this.FormCatalogue_Load);
            this.paneltrasero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltrasero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton detallesCatalogue;
        private FontAwesome.Sharp.IconButton EleminarCatalogue;
        private FontAwesome.Sharp.IconButton ActualizarCatalogue;
        private FontAwesome.Sharp.IconButton NewCatalogue;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox Search;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtSearch;
    }
}