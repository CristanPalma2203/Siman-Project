namespace UI.WinForm.ChildForms
{
    partial class FormCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltrasero = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.EleminarCustomer = new FontAwesome.Sharp.IconButton();
            this.ActualizarCustomer = new FontAwesome.Sharp.IconButton();
            this.NewCustomer = new FontAwesome.Sharp.IconButton();
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
            this.paneltrasero.Location = new System.Drawing.Point(13, 85);
            this.paneltrasero.Name = "paneltrasero";
            this.paneltrasero.Size = new System.Drawing.Size(901, 331);
            this.paneltrasero.TabIndex = 162;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(897, 327);
            this.dataGridView1.TabIndex = 0;
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
            this.iconButton1.Location = new System.Drawing.Point(462, 440);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(211, 74);
            this.iconButton1.TabIndex = 161;
            this.iconButton1.Text = "Ver Detalles";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // EleminarCustomer
            // 
            this.EleminarCustomer.BackColor = System.Drawing.Color.Transparent;
            this.EleminarCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EleminarCustomer.FlatAppearance.BorderSize = 0;
            this.EleminarCustomer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.EleminarCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.EleminarCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.EleminarCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EleminarCustomer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EleminarCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EleminarCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.EleminarCustomer.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.EleminarCustomer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.EleminarCustomer.IconSize = 70;
            this.EleminarCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EleminarCustomer.Location = new System.Drawing.Point(684, 440);
            this.EleminarCustomer.Name = "EleminarCustomer";
            this.EleminarCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EleminarCustomer.Rotation = 0D;
            this.EleminarCustomer.Size = new System.Drawing.Size(229, 74);
            this.EleminarCustomer.TabIndex = 160;
            this.EleminarCustomer.Text = "Eliminar Cliente";
            this.EleminarCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EleminarCustomer.UseVisualStyleBackColor = false;
            this.EleminarCustomer.Click += new System.EventHandler(this.EleminarCustomer_Click);
            // 
            // ActualizarCustomer
            // 
            this.ActualizarCustomer.BackColor = System.Drawing.Color.Transparent;
            this.ActualizarCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarCustomer.FlatAppearance.BorderSize = 0;
            this.ActualizarCustomer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ActualizarCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.ActualizarCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.ActualizarCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarCustomer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ActualizarCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.ActualizarCustomer.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.ActualizarCustomer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.ActualizarCustomer.IconSize = 70;
            this.ActualizarCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarCustomer.Location = new System.Drawing.Point(241, 437);
            this.ActualizarCustomer.Name = "ActualizarCustomer";
            this.ActualizarCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ActualizarCustomer.Rotation = 0D;
            this.ActualizarCustomer.Size = new System.Drawing.Size(244, 74);
            this.ActualizarCustomer.TabIndex = 159;
            this.ActualizarCustomer.Text = "Actualizar Cliente";
            this.ActualizarCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ActualizarCustomer.UseVisualStyleBackColor = false;
            this.ActualizarCustomer.Click += new System.EventHandler(this.ActualizarCustomer_Click);
            // 
            // NewCustomer
            // 
            this.NewCustomer.BackColor = System.Drawing.Color.Transparent;
            this.NewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewCustomer.FlatAppearance.BorderSize = 0;
            this.NewCustomer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.NewCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.NewCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.NewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCustomer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NewCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.NewCustomer.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.NewCustomer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.NewCustomer.IconSize = 70;
            this.NewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewCustomer.Location = new System.Drawing.Point(14, 437);
            this.NewCustomer.Name = "NewCustomer";
            this.NewCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.NewCustomer.Rotation = 0D;
            this.NewCustomer.Size = new System.Drawing.Size(211, 68);
            this.NewCustomer.TabIndex = 158;
            this.NewCustomer.Text = "Nuevo Cliente";
            this.NewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewCustomer.UseVisualStyleBackColor = false;
            this.NewCustomer.Click += new System.EventHandler(this.NewCustomer_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.panel4.Location = new System.Drawing.Point(16, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 1);
            this.panel4.TabIndex = 157;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.Search.IconSize = 27;
            this.Search.Location = new System.Drawing.Point(457, 40);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(32, 27);
            this.Search.TabIndex = 156;
            this.Search.TabStop = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Label7.ForeColor = System.Drawing.Color.DimGray;
            this.Label7.Location = new System.Drawing.Point(12, 9);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(374, 21);
            this.Label7.TabIndex = 155;
            this.Label7.Text = "Buscar por nombre, apellido, gmail y ID Cliente:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSearch.Location = new System.Drawing.Point(16, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(442, 20);
            this.txtSearch.TabIndex = 154;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 526);
            this.Controls.Add(this.paneltrasero);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.EleminarCustomer);
            this.Controls.Add(this.ActualizarCustomer);
            this.Controls.Add(this.NewCustomer);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtSearch);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.paneltrasero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltrasero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton EleminarCustomer;
        private FontAwesome.Sharp.IconButton ActualizarCustomer;
        private FontAwesome.Sharp.IconButton NewCustomer;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox Search;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtSearch;
    }
}