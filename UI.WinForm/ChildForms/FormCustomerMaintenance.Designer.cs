namespace UI.WinForm.ChildForms
{
    partial class FormCustomerMaintenance
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtphoneNumber = new System.Windows.Forms.TextBox();
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
            this.lblDirrecion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtfEmail = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txttArchivioID = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.panelMultiInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAddedControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(486, 268);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 22);
            this.txtAddress.TabIndex = 158;
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneNumber.Location = new System.Drawing.Point(486, 209);
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.Size = new System.Drawing.Size(230, 22);
            this.txtphoneNumber.TabIndex = 157;
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeletePhoto.FlatAppearance.BorderSize = 0;
            this.btnDeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePhoto.ForeColor = System.Drawing.Color.White;
            this.btnDeletePhoto.Location = new System.Drawing.Point(166, 253);
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.Size = new System.Drawing.Size(25, 25);
            this.btnDeletePhoto.TabIndex = 138;
            this.btnDeletePhoto.Text = "-";
            this.btnDeletePhoto.UseVisualStyleBackColor = false;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddPhoto.FlatAppearance.BorderSize = 0;
            this.btnAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddPhoto.Location = new System.Drawing.Point(135, 253);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(25, 25);
            this.btnAddPhoto.TabIndex = 137;
            this.btnAddPhoto.Text = "+";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            // 
            // panelMultiInsert
            // 
            this.panelMultiInsert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMultiInsert.Controls.Add(this.dataGridView1);
            this.panelMultiInsert.Controls.Add(this.btnAddUser);
            this.panelMultiInsert.Location = new System.Drawing.Point(15, 317);
            this.panelMultiInsert.Name = "panelMultiInsert";
            this.panelMultiInsert.Size = new System.Drawing.Size(772, 250);
            this.panelMultiInsert.TabIndex = 143;
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
            this.btnSave.Location = new System.Drawing.Point(384, 586);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 144;
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
            this.btnCancel.Location = new System.Drawing.Point(211, 586);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 145;
            this.btnCancel.Text = "X  Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelAddedControl
            // 
            this.panelAddedControl.Controls.Add(this.rbMultiInsert);
            this.panelAddedControl.Controls.Add(this.rbSingleInsert);
            this.panelAddedControl.Location = new System.Drawing.Point(486, 89);
            this.panelAddedControl.Name = "panelAddedControl";
            this.panelAddedControl.Size = new System.Drawing.Size(241, 30);
            this.panelAddedControl.TabIndex = 156;
            // 
            // rbMultiInsert
            // 
            this.rbMultiInsert.AutoSize = true;
            this.rbMultiInsert.Checked = true;
            this.rbMultiInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbMultiInsert.Location = new System.Drawing.Point(109, 3);
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
            this.rbSingleInsert.Location = new System.Drawing.Point(8, 5);
            this.rbSingleInsert.Name = "rbSingleInsert";
            this.rbSingleInsert.Size = new System.Drawing.Size(95, 19);
            this.rbSingleInsert.TabIndex = 0;
            this.rbSingleInsert.Text = "Inserto único";
            this.rbSingleInsert.UseVisualStyleBackColor = true;
            this.rbSingleInsert.CheckedChanged += new System.EventHandler(this.rbSingleInsert_CheckedChanged);
            // 
            // lblDirrecion
            // 
            this.lblDirrecion.AutoSize = true;
            this.lblDirrecion.BackColor = System.Drawing.Color.Transparent;
            this.lblDirrecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirrecion.ForeColor = System.Drawing.Color.DimGray;
            this.lblDirrecion.Location = new System.Drawing.Point(483, 249);
            this.lblDirrecion.Name = "lblDirrecion";
            this.lblDirrecion.Size = new System.Drawing.Size(64, 16);
            this.lblDirrecion.TabIndex = 155;
            this.lblDirrecion.Text = "Dirrecion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(44, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 154;
            this.label3.Text = "Cambiar foto:";
            // 
            // PictureBoxPhoto
            // 
            this.PictureBoxPhoto.Image = global::UI.WinForm.Properties.Resources.customer;
            this.PictureBoxPhoto.Location = new System.Drawing.Point(41, 99);
            this.PictureBoxPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxPhoto.Name = "PictureBoxPhoto";
            this.PictureBoxPhoto.Size = new System.Drawing.Size(150, 150);
            this.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxPhoto.TabIndex = 153;
            this.PictureBoxPhoto.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(60, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 26);
            this.lblTitle.TabIndex = 151;
            this.lblTitle.Text = "Mantenimiento";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(483, 140);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 16);
            this.Label1.TabIndex = 146;
            this.Label1.Text = "Email:";
            // 
            // txtfEmail
            // 
            this.txtfEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfEmail.Location = new System.Drawing.Point(486, 159);
            this.txtfEmail.Name = "txtfEmail";
            this.txtfEmail.Size = new System.Drawing.Size(230, 22);
            this.txtfEmail.TabIndex = 142;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.DimGray;
            this.lbl2.Location = new System.Drawing.Point(225, 240);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(102, 16);
            this.lbl2.TabIndex = 150;
            this.lbl2.Text = "Codigo Archivo:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.DimGray;
            this.lbl.Location = new System.Drawing.Point(483, 190);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(134, 16);
            this.lbl.TabIndex = 147;
            this.lbl.Text = "Numero de Telefono:";
            // 
            // txttArchivioID
            // 
            this.txttArchivioID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttArchivioID.Location = new System.Drawing.Point(228, 259);
            this.txttArchivioID.Name = "txttArchivioID";
            this.txttArchivioID.Size = new System.Drawing.Size(230, 22);
            this.txttArchivioID.TabIndex = 141;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.DimGray;
            this.Label5.Location = new System.Drawing.Point(225, 190);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 16);
            this.Label5.TabIndex = 149;
            this.Label5.Text = "Apellido:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(228, 209);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(230, 22);
            this.txtLastName.TabIndex = 140;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(228, 159);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 22);
            this.txtName.TabIndex = 139;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(225, 140);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(59, 16);
            this.Label4.TabIndex = 148;
            this.Label4.Text = "Nombre:";
            // 
            // FormCustomerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 633);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtphoneNumber);
            this.Controls.Add(this.btnDeletePhoto);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.panelMultiInsert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelAddedControl);
            this.Controls.Add(this.lblDirrecion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PictureBoxPhoto);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtfEmail);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txttArchivioID);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label4);
            this.Name = "FormCustomerMaintenance";
            this.Text = "FormCustomerMaintenance";
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtLastName, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.txttArchivioID, 0);
            this.Controls.SetChildIndex(this.lbl, 0);
            this.Controls.SetChildIndex(this.lbl2, 0);
            this.Controls.SetChildIndex(this.txtfEmail, 0);
            this.Controls.SetChildIndex(this.Label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.PictureBoxPhoto, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblDirrecion, 0);
            this.Controls.SetChildIndex(this.panelAddedControl, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.panelMultiInsert, 0);
            this.Controls.SetChildIndex(this.btnAddPhoto, 0);
            this.Controls.SetChildIndex(this.btnDeletePhoto, 0);
            this.Controls.SetChildIndex(this.txtphoneNumber, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.panelMultiInsert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAddedControl.ResumeLayout(false);
            this.panelAddedControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtphoneNumber;
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
        internal System.Windows.Forms.Label lblDirrecion;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.PictureBox PictureBoxPhoto;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtfEmail;
        internal System.Windows.Forms.Label lbl2;
        internal System.Windows.Forms.Label lbl;
        internal System.Windows.Forms.TextBox txttArchivioID;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label4;
    }
}