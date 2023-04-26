namespace UI.WinForm.ChildForms
{
    partial class FormUserMaintenance
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.panelAddedControl = new System.Windows.Forms.Panel();
            this.rbMultiInsert = new System.Windows.Forms.RadioButton();
            this.rbSingleInsert = new System.Windows.Forms.RadioButton();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panelMultiInsert = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.btnDeletePhoto = new System.Windows.Forms.Button();
            this.PictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.panelAddedControl.SuspendLayout();
            this.panelMultiInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(212, 654);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "X  Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(210, 266);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(230, 24);
            this.cmbPosition.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(388, 654);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.DimGray;
            this.Label6.Location = new System.Drawing.Point(207, 246);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 16);
            this.Label6.TabIndex = 97;
            this.Label6.Text = "Cargo:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(23, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 26);
            this.lblTitle.TabIndex = 94;
            this.lblTitle.Text = "Mantenimiento";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(465, 96);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(126, 16);
            this.Label1.TabIndex = 85;
            this.Label1.Text = "Nombre de usuario:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(468, 115);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(230, 22);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(468, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 22);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.DimGray;
            this.lbl2.Location = new System.Drawing.Point(207, 196);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(45, 16);
            this.lbl2.TabIndex = 93;
            this.lbl2.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Location = new System.Drawing.Point(465, 146);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 16);
            this.lblPassword.TabIndex = 87;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(210, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.DimGray;
            this.Label5.Location = new System.Drawing.Point(207, 146);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(61, 16);
            this.Label5.TabIndex = 91;
            this.Label5.Text = "Apellido:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(210, 165);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(230, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(210, 115);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(230, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(207, 96);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(60, 16);
            this.Label4.TabIndex = 89;
            this.Label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(31, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "Cambiar foto:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(468, 215);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(230, 22);
            this.txtConfirmPass.TabIndex = 8;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblConfirmPass.Location = new System.Drawing.Point(465, 196);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(138, 16);
            this.lblConfirmPass.TabIndex = 103;
            this.lblConfirmPass.Text = "Confirmar contraseña:";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.Location = new System.Drawing.Point(468, 265);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(230, 22);
            this.txtCurrentPass.TabIndex = 9;
            this.txtCurrentPass.UseSystemPasswordChar = true;
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurrentPass.Location = new System.Drawing.Point(465, 246);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(119, 16);
            this.lblCurrentPass.TabIndex = 105;
            this.lblCurrentPass.Text = "Contraseña actual:";
            // 
            // panelAddedControl
            // 
            this.panelAddedControl.Controls.Add(this.rbMultiInsert);
            this.panelAddedControl.Controls.Add(this.rbSingleInsert);
            this.panelAddedControl.Location = new System.Drawing.Point(503, 45);
            this.panelAddedControl.Name = "panelAddedControl";
            this.panelAddedControl.Size = new System.Drawing.Size(241, 30);
            this.panelAddedControl.TabIndex = 106;
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
            this.rbSingleInsert.Location = new System.Drawing.Point(8, 3);
            this.rbSingleInsert.Name = "rbSingleInsert";
            this.rbSingleInsert.Size = new System.Drawing.Size(95, 19);
            this.rbSingleInsert.TabIndex = 0;
            this.rbSingleInsert.Text = "Inserto único";
            this.rbSingleInsert.UseVisualStyleBackColor = true;
            this.rbSingleInsert.CheckedChanged += new System.EventHandler(this.rbSingleInsert_CheckedChanged);
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
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUserList_Click);
            // 
            // panelMultiInsert
            // 
            this.panelMultiInsert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMultiInsert.Controls.Add(this.dataGridView1);
            this.panelMultiInsert.Controls.Add(this.btnAddUser);
            this.panelMultiInsert.Location = new System.Drawing.Point(2, 308);
            this.panelMultiInsert.Name = "panelMultiInsert";
            this.panelMultiInsert.Size = new System.Drawing.Size(750, 330);
            this.panelMultiInsert.TabIndex = 10;
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
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddPhoto.FlatAppearance.BorderSize = 0;
            this.btnAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddPhoto.Location = new System.Drawing.Point(122, 250);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(25, 25);
            this.btnAddPhoto.TabIndex = 0;
            this.btnAddPhoto.Text = "+";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeletePhoto.FlatAppearance.BorderSize = 0;
            this.btnDeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePhoto.ForeColor = System.Drawing.Color.White;
            this.btnDeletePhoto.Location = new System.Drawing.Point(153, 250);
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.Size = new System.Drawing.Size(25, 25);
            this.btnDeletePhoto.TabIndex = 1;
            this.btnDeletePhoto.Text = "-";
            this.btnDeletePhoto.UseVisualStyleBackColor = false;
            this.btnDeletePhoto.Click += new System.EventHandler(this.btnDeletePhoto_Click);
            // 
            // PictureBoxPhoto
            // 
            this.PictureBoxPhoto.Image = global::UI.WinForm.Properties.Resources.defaultImageProfileUser;
            this.PictureBoxPhoto.Location = new System.Drawing.Point(28, 96);
            this.PictureBoxPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxPhoto.Name = "PictureBoxPhoto";
            this.PictureBoxPhoto.Size = new System.Drawing.Size(150, 150);
            this.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxPhoto.TabIndex = 100;
            this.PictureBoxPhoto.TabStop = false;
            // 
            // FormUserMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(754, 715);
            this.Controls.Add(this.btnDeletePhoto);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.panelMultiInsert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelAddedControl);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.lblCurrentPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.PictureBoxPhoto);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.Label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User maintenance";
            this.Load += new System.EventHandler(this.FormUserMaintenance_Load);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.txtFirstName, 0);
            this.Controls.SetChildIndex(this.txtLastName, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.lblPassword, 0);
            this.Controls.SetChildIndex(this.lbl2, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.txtUsername, 0);
            this.Controls.SetChildIndex(this.Label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.Label6, 0);
            this.Controls.SetChildIndex(this.PictureBoxPhoto, 0);
            this.Controls.SetChildIndex(this.cmbPosition, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblConfirmPass, 0);
            this.Controls.SetChildIndex(this.txtConfirmPass, 0);
            this.Controls.SetChildIndex(this.lblCurrentPass, 0);
            this.Controls.SetChildIndex(this.txtCurrentPass, 0);
            this.Controls.SetChildIndex(this.panelAddedControl, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.panelMultiInsert, 0);
            this.Controls.SetChildIndex(this.btnAddPhoto, 0);
            this.Controls.SetChildIndex(this.btnDeletePhoto, 0);
            this.panelAddedControl.ResumeLayout(false);
            this.panelAddedControl.PerformLayout();
            this.panelMultiInsert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.ComboBox cmbPosition;
        internal System.Windows.Forms.PictureBox PictureBoxPhoto;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label lbl2;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtConfirmPass;
        internal System.Windows.Forms.Label lblConfirmPass;
        internal System.Windows.Forms.TextBox txtCurrentPass;
        internal System.Windows.Forms.Label lblCurrentPass;
        private System.Windows.Forms.Panel panelAddedControl;
        private System.Windows.Forms.RadioButton rbMultiInsert;
        private System.Windows.Forms.RadioButton rbSingleInsert;
        internal System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel panelMultiInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnAddPhoto;
        internal System.Windows.Forms.Button btnDeletePhoto;
    }
}