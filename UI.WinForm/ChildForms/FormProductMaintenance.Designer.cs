namespace UI.WinForm.ChildForms
{
    partial class FormProductMaintenance
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
            this.txtProductSize = new System.Windows.Forms.TextBox();
            this.txtProductColor = new System.Windows.Forms.TextBox();
            this.btnDeletePhoto = new System.Windows.Forms.Button();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.panelMultiInsert = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelAddedControl = new System.Windows.Forms.Panel();
            this.rbMultiInsert = new System.Windows.Forms.RadioButton();
            this.rbSingleInsert = new System.Windows.Forms.RadioButton();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtCantidadPro = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtNameProduc = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.PictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.lbltitle1 = new System.Windows.Forms.Label();
            this.panelMultiInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAddedControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductSize
            // 
            this.txtProductSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSize.Location = new System.Drawing.Point(489, 178);
            this.txtProductSize.Name = "txtProductSize";
            this.txtProductSize.Size = new System.Drawing.Size(230, 22);
            this.txtProductSize.TabIndex = 154;
            // 
            // txtProductColor
            // 
            this.txtProductColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductColor.Location = new System.Drawing.Point(489, 228);
            this.txtProductColor.Name = "txtProductColor";
            this.txtProductColor.Size = new System.Drawing.Size(230, 22);
            this.txtProductColor.TabIndex = 153;
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeletePhoto.FlatAppearance.BorderSize = 0;
            this.btnDeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePhoto.ForeColor = System.Drawing.Color.White;
            this.btnDeletePhoto.Location = new System.Drawing.Point(173, 246);
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.Size = new System.Drawing.Size(25, 25);
            this.btnDeletePhoto.TabIndex = 135;
            this.btnDeletePhoto.Text = "-";
            this.btnDeletePhoto.UseVisualStyleBackColor = false;
            this.btnDeletePhoto.Click += new System.EventHandler(this.btnDeletePhoto_Click);
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddPhoto.FlatAppearance.BorderSize = 0;
            this.btnAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddPhoto.Location = new System.Drawing.Point(142, 246);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(25, 25);
            this.btnAddPhoto.TabIndex = 134;
            this.btnAddPhoto.Text = "+";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // panelMultiInsert
            // 
            this.panelMultiInsert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMultiInsert.Controls.Add(this.dataGridView1);
            this.panelMultiInsert.Controls.Add(this.btnAddUser);
            this.panelMultiInsert.Location = new System.Drawing.Point(28, 290);
            this.panelMultiInsert.Name = "panelMultiInsert";
            this.panelMultiInsert.Size = new System.Drawing.Size(728, 251);
            this.panelMultiInsert.TabIndex = 140;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(9, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(732, 282);
            this.dataGridView1.TabIndex = 108;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(296, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(150, 40);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Agregar";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(398, 557);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 141;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(231, 557);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 142;
            this.btnCancel.Text = "X  Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelAddedControl
            // 
            this.panelAddedControl.Controls.Add(this.rbMultiInsert);
            this.panelAddedControl.Controls.Add(this.rbSingleInsert);
            this.panelAddedControl.Location = new System.Drawing.Point(455, 59);
            this.panelAddedControl.Name = "panelAddedControl";
            this.panelAddedControl.Size = new System.Drawing.Size(246, 30);
            this.panelAddedControl.TabIndex = 152;
            // 
            // rbMultiInsert
            // 
            this.rbMultiInsert.AutoSize = true;
            this.rbMultiInsert.Checked = true;
            this.rbMultiInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbMultiInsert.Location = new System.Drawing.Point(123, 3);
            this.rbMultiInsert.Name = "rbMultiInsert";
            this.rbMultiInsert.Size = new System.Drawing.Size(122, 19);
            this.rbMultiInsert.TabIndex = 1;
            this.rbMultiInsert.TabStop = true;
            this.rbMultiInsert.Text = "Inserción múltiple";
            this.rbMultiInsert.UseVisualStyleBackColor = true;
            // 
            // rbSingleInsert
            // 
            this.rbSingleInsert.AutoSize = true;
            this.rbSingleInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSingleInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbSingleInsert.Location = new System.Drawing.Point(22, 3);
            this.rbSingleInsert.Name = "rbSingleInsert";
            this.rbSingleInsert.Size = new System.Drawing.Size(95, 19);
            this.rbSingleInsert.TabIndex = 0;
            this.rbSingleInsert.Text = "Inserto único";
            this.rbSingleInsert.UseVisualStyleBackColor = true;
            this.rbSingleInsert.CheckedChanged += new System.EventHandler(this.rbSingleInsert_CheckedChanged);
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblConfirmPass.Location = new System.Drawing.Point(486, 209);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(42, 16);
            this.lblConfirmPass.TabIndex = 151;
            this.lblConfirmPass.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(51, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 150;
            this.label3.Text = "Cambiar foto:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(77, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 26);
            this.lblTitle.TabIndex = 148;
            this.lblTitle.Text = "Mantenimiento";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(486, 109);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 16);
            this.Label1.TabIndex = 143;
            this.Label1.Text = "Precio:";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(489, 128);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(230, 22);
            this.txtprice.TabIndex = 139;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.DimGray;
            this.lbl2.Location = new System.Drawing.Point(237, 209);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(67, 16);
            this.lbl2.TabIndex = 147;
            this.lbl2.Text = "Cantidad: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Location = new System.Drawing.Point(486, 159);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 16);
            this.lblPassword.TabIndex = 144;
            this.lblPassword.Text = "Talla:";
            // 
            // txtCantidadPro
            // 
            this.txtCantidadPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadPro.Location = new System.Drawing.Point(231, 228);
            this.txtCantidadPro.Name = "txtCantidadPro";
            this.txtCantidadPro.Size = new System.Drawing.Size(230, 22);
            this.txtCantidadPro.TabIndex = 138;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.DimGray;
            this.Label5.Location = new System.Drawing.Point(228, 159);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(85, 16);
            this.Label5.TabIndex = 146;
            this.Label5.Text = "Descripcion :";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrip.Location = new System.Drawing.Point(231, 178);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(230, 22);
            this.txtDescrip.TabIndex = 137;
            // 
            // txtNameProduc
            // 
            this.txtNameProduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProduc.Location = new System.Drawing.Point(231, 128);
            this.txtNameProduc.Name = "txtNameProduc";
            this.txtNameProduc.Size = new System.Drawing.Size(230, 22);
            this.txtNameProduc.TabIndex = 136;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(228, 109);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(116, 16);
            this.Label4.TabIndex = 145;
            this.Label4.Text = "Nombre Producto:";
            // 
            // PictureBoxPhoto
            // 
            this.PictureBoxPhoto.Image = global::UI.WinForm.Properties.Resources.defultProduct;
            this.PictureBoxPhoto.Location = new System.Drawing.Point(48, 89);
            this.PictureBoxPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxPhoto.Name = "PictureBoxPhoto";
            this.PictureBoxPhoto.Size = new System.Drawing.Size(150, 150);
            this.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxPhoto.TabIndex = 149;
            this.PictureBoxPhoto.TabStop = false;
            // 
            // lbltitle1
            // 
            this.lbltitle1.AutoSize = true;
            this.lbltitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle1.ForeColor = System.Drawing.Color.DimGray;
            this.lbltitle1.Location = new System.Drawing.Point(77, 59);
            this.lbltitle1.Name = "lbltitle1";
            this.lbltitle1.Size = new System.Drawing.Size(155, 26);
            this.lbltitle1.TabIndex = 156;
            this.lbltitle1.Text = "Mantenimiento";
            // 
            // FormProductMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 621);
            this.Controls.Add(this.lbltitle1);
            this.Controls.Add(this.txtProductSize);
            this.Controls.Add(this.txtProductColor);
            this.Controls.Add(this.btnDeletePhoto);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.panelMultiInsert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelAddedControl);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PictureBoxPhoto);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtCantidadPro);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtNameProduc);
            this.Controls.Add(this.Label4);
            this.Name = "FormProductMaintenance";
            this.Text = "FormProductMaintenance";
            this.Load += new System.EventHandler(this.FormProductMaintenance_Load);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.txtNameProduc, 0);
            this.Controls.SetChildIndex(this.txtDescrip, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.txtCantidadPro, 0);
            this.Controls.SetChildIndex(this.lblPassword, 0);
            this.Controls.SetChildIndex(this.lbl2, 0);
            this.Controls.SetChildIndex(this.txtprice, 0);
            this.Controls.SetChildIndex(this.Label1, 0);
            this.Controls.SetChildIndex(this.PictureBoxPhoto, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblConfirmPass, 0);
            this.Controls.SetChildIndex(this.panelAddedControl, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.panelMultiInsert, 0);
            this.Controls.SetChildIndex(this.btnAddPhoto, 0);
            this.Controls.SetChildIndex(this.btnDeletePhoto, 0);
            this.Controls.SetChildIndex(this.txtProductColor, 0);
            this.Controls.SetChildIndex(this.txtProductSize, 0);
            this.Controls.SetChildIndex(this.lbltitle1, 0);
            this.panelMultiInsert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAddedControl.ResumeLayout(false);
            this.panelAddedControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtProductSize;
        internal System.Windows.Forms.TextBox txtProductColor;
        internal System.Windows.Forms.Button btnDeletePhoto;
        internal System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Panel panelMultiInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnAddUser;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelAddedControl;
        private System.Windows.Forms.RadioButton rbMultiInsert;
        private System.Windows.Forms.RadioButton rbSingleInsert;
        internal System.Windows.Forms.Label lblConfirmPass;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.PictureBox PictureBoxPhoto;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtprice;
        internal System.Windows.Forms.Label lbl2;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.TextBox txtCantidadPro;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtDescrip;
        internal System.Windows.Forms.TextBox txtNameProduc;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label lbltitle1;
    }
}