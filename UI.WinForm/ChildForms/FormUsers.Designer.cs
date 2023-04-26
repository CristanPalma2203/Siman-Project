namespace UI.WinForm.ChildForms
{
    partial class FormUsers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NewCita = new FontAwesome.Sharp.IconButton();
            this.ActualizarCita = new FontAwesome.Sharp.IconButton();
            this.EleminarCita = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.paneltrasero = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            this.paneltrasero.SuspendLayout();
            this.SuspendLayout();
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
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Label7.ForeColor = System.Drawing.Color.DimGray;
            this.Label7.Location = new System.Drawing.Point(38, 20);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(377, 21);
            this.Label7.TabIndex = 62;
            this.Label7.Text = "Buscar por nombre de usuario, nombre o email :";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSearch.Location = new System.Drawing.Point(42, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(442, 20);
            this.txtSearch.TabIndex = 61;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Search.IconSize = 27;
            this.Search.Location = new System.Drawing.Point(483, 51);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(32, 27);
            this.Search.TabIndex = 68;
            this.Search.TabStop = false;
            this.Search.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.panel4.Location = new System.Drawing.Point(42, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 1);
            this.panel4.TabIndex = 69;
            // 
            // NewCita
            // 
            this.NewCita.BackColor = System.Drawing.Color.Transparent;
            this.NewCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewCita.FlatAppearance.BorderSize = 0;
            this.NewCita.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.NewCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.NewCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.NewCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCita.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NewCita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCita.ForeColor = System.Drawing.Color.DimGray;
            this.NewCita.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.NewCita.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.NewCita.IconSize = 70;
            this.NewCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewCita.Location = new System.Drawing.Point(40, 448);
            this.NewCita.Name = "NewCita";
            this.NewCita.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.NewCita.Rotation = 0D;
            this.NewCita.Size = new System.Drawing.Size(211, 68);
            this.NewCita.TabIndex = 70;
            this.NewCita.Text = "Nueva Cita";
            this.NewCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewCita.UseVisualStyleBackColor = false;
            this.NewCita.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ActualizarCita
            // 
            this.ActualizarCita.BackColor = System.Drawing.Color.Transparent;
            this.ActualizarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarCita.FlatAppearance.BorderSize = 0;
            this.ActualizarCita.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ActualizarCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.ActualizarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.ActualizarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarCita.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ActualizarCita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarCita.ForeColor = System.Drawing.Color.DimGray;
            this.ActualizarCita.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.ActualizarCita.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.ActualizarCita.IconSize = 70;
            this.ActualizarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarCita.Location = new System.Drawing.Point(267, 448);
            this.ActualizarCita.Name = "ActualizarCita";
            this.ActualizarCita.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ActualizarCita.Rotation = 0D;
            this.ActualizarCita.Size = new System.Drawing.Size(244, 74);
            this.ActualizarCita.TabIndex = 71;
            this.ActualizarCita.Text = "Actualizar Proxima Cita";
            this.ActualizarCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ActualizarCita.UseVisualStyleBackColor = false;
            this.ActualizarCita.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // EleminarCita
            // 
            this.EleminarCita.BackColor = System.Drawing.Color.Transparent;
            this.EleminarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EleminarCita.FlatAppearance.BorderSize = 0;
            this.EleminarCita.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.EleminarCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.EleminarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.EleminarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EleminarCita.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EleminarCita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EleminarCita.ForeColor = System.Drawing.Color.DimGray;
            this.EleminarCita.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.EleminarCita.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.EleminarCita.IconSize = 70;
            this.EleminarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EleminarCita.Location = new System.Drawing.Point(710, 451);
            this.EleminarCita.Name = "EleminarCita";
            this.EleminarCita.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EleminarCita.Rotation = 0D;
            this.EleminarCita.Size = new System.Drawing.Size(229, 74);
            this.EleminarCita.TabIndex = 72;
            this.EleminarCita.Text = "Eliminar Cita";
            this.EleminarCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EleminarCita.UseVisualStyleBackColor = false;
            this.EleminarCita.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.iconButton1.IconSize = 70;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(488, 451);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(211, 74);
            this.iconButton1.TabIndex = 73;
            this.iconButton1.Text = "Ver Detalles";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // paneltrasero
            // 
            this.paneltrasero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.paneltrasero.Controls.Add(this.dataGridView1);
            this.paneltrasero.Location = new System.Drawing.Point(39, 96);
            this.paneltrasero.Name = "paneltrasero";
            this.paneltrasero.Size = new System.Drawing.Size(901, 331);
            this.paneltrasero.TabIndex = 126;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(968, 528);
            this.Controls.Add(this.paneltrasero);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.EleminarCita);
            this.Controls.Add(this.ActualizarCita);
            this.Controls.Add(this.NewCita);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtSearch);
            this.Name = "FormUsers";
            this.Text = "Lista de usuarios";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            this.paneltrasero.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconPictureBox Search;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton NewCita;
        private FontAwesome.Sharp.IconButton ActualizarCita;
        private FontAwesome.Sharp.IconButton EleminarCita;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel paneltrasero;
    }
}