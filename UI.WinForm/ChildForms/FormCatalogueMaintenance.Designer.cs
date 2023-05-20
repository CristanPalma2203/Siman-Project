namespace UI.WinForm.ChildForms
{
    partial class FormCatalogueMaintenance
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
            this.panelMultiInsert = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAbrevitura = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtfechacreacion = new System.Windows.Forms.TextBox();
            this.txtusuarioCrea = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.PictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.rbSingleInsert = new System.Windows.Forms.RadioButton();
            this.rbMultiInsert = new System.Windows.Forms.RadioButton();
            this.panelAddedControl = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnDeletePhoto = new System.Windows.Forms.Button();
            this.txtFechaUpde = new System.Windows.Forms.TextBox();
            this.txtUsuarioUpdate = new System.Windows.Forms.TextBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.txtfather = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMultiInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).BeginInit();
            this.panelAddedControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMultiInsert
            // 
            this.panelMultiInsert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMultiInsert.Controls.Add(this.dataGridView1);
            this.panelMultiInsert.Controls.Add(this.btnAddUser);
            this.panelMultiInsert.Location = new System.Drawing.Point(27, 324);
            this.panelMultiInsert.Name = "panelMultiInsert";
            this.panelMultiInsert.Size = new System.Drawing.Size(772, 250);
            this.panelMultiInsert.TabIndex = 117;
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
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUserList_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(396, 593);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 118;
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
            this.btnCancel.Location = new System.Drawing.Point(223, 593);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 119;
            this.btnCancel.Text = "X  Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(72, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 26);
            this.lblTitle.TabIndex = 125;
            this.lblTitle.Text = "Mantenimiento";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(232, 106);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(59, 16);
            this.Label4.TabIndex = 122;
            this.Label4.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(235, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 22);
            this.txtName.TabIndex = 109;
            // 
            // txtAbrevitura
            // 
            this.txtAbrevitura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbrevitura.Location = new System.Drawing.Point(235, 175);
            this.txtAbrevitura.Name = "txtAbrevitura";
            this.txtAbrevitura.Size = new System.Drawing.Size(230, 22);
            this.txtAbrevitura.TabIndex = 110;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.DimGray;
            this.Label5.Location = new System.Drawing.Point(232, 156);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(71, 16);
            this.Label5.TabIndex = 123;
            this.Label5.Text = "Abrevitura:";
            // 
            // txttipo
            // 
            this.txttipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.Location = new System.Drawing.Point(235, 225);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(230, 22);
            this.txttipo.TabIndex = 111;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.DimGray;
            this.lbl.Location = new System.Drawing.Point(490, 156);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(149, 16);
            this.lbl.TabIndex = 121;
            this.lbl.Text = "Fecha de Actualizacion:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.DimGray;
            this.lbl2.Location = new System.Drawing.Point(232, 206);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(38, 16);
            this.lbl2.TabIndex = 124;
            this.lbl2.Text = "Tipo:";
            // 
            // txtfechacreacion
            // 
            this.txtfechacreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechacreacion.Location = new System.Drawing.Point(493, 125);
            this.txtfechacreacion.Name = "txtfechacreacion";
            this.txtfechacreacion.Size = new System.Drawing.Size(230, 22);
            this.txtfechacreacion.TabIndex = 113;
            // 
            // txtusuarioCrea
            // 
            this.txtusuarioCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuarioCrea.Location = new System.Drawing.Point(235, 284);
            this.txtusuarioCrea.Name = "txtusuarioCrea";
            this.txtusuarioCrea.Size = new System.Drawing.Size(230, 22);
            this.txtusuarioCrea.TabIndex = 134;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.DimGray;
            this.Label6.Location = new System.Drawing.Point(232, 256);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(70, 16);
            this.Label6.TabIndex = 126;
            this.Label6.Text = "UsuarioID:";
            // 
            // PictureBoxPhoto
            // 
            this.PictureBoxPhoto.Image = global::UI.WinForm.Properties.Resources.Catalogue;
            this.PictureBoxPhoto.Location = new System.Drawing.Point(53, 106);
            this.PictureBoxPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxPhoto.Name = "PictureBoxPhoto";
            this.PictureBoxPhoto.Size = new System.Drawing.Size(150, 150);
            this.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxPhoto.TabIndex = 127;
            this.PictureBoxPhoto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(56, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 128;
            this.label3.Text = "Cambiar foto:";
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblConfirmPass.Location = new System.Drawing.Point(490, 215);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(139, 16);
            this.lblConfirmPass.TabIndex = 129;
            this.lblConfirmPass.Text = "Usuario Actualizacion:";
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
            this.rbSingleInsert.CheckedChanged += new System.EventHandler(this.rbSingleInsert_CheckedChanged_1);
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
            // panelAddedControl
            // 
            this.panelAddedControl.Controls.Add(this.rbMultiInsert);
            this.panelAddedControl.Controls.Add(this.rbSingleInsert);
            this.panelAddedControl.Location = new System.Drawing.Point(461, 58);
            this.panelAddedControl.Name = "panelAddedControl";
            this.panelAddedControl.Size = new System.Drawing.Size(241, 30);
            this.panelAddedControl.TabIndex = 131;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(490, 106);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(122, 16);
            this.Label1.TabIndex = 120;
            this.Label1.Text = "Fecha de creacion:";
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeletePhoto.FlatAppearance.BorderSize = 0;
            this.btnDeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePhoto.ForeColor = System.Drawing.Color.White;
            this.btnDeletePhoto.Location = new System.Drawing.Point(178, 260);
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.Size = new System.Drawing.Size(25, 25);
            this.btnDeletePhoto.TabIndex = 108;
            this.btnDeletePhoto.Text = "-";
            this.btnDeletePhoto.UseVisualStyleBackColor = false;
            // 
            // txtFechaUpde
            // 
            this.txtFechaUpde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaUpde.Location = new System.Drawing.Point(493, 181);
            this.txtFechaUpde.Name = "txtFechaUpde";
            this.txtFechaUpde.Size = new System.Drawing.Size(230, 22);
            this.txtFechaUpde.TabIndex = 132;
            // 
            // txtUsuarioUpdate
            // 
            this.txtUsuarioUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioUpdate.Location = new System.Drawing.Point(493, 234);
            this.txtUsuarioUpdate.Name = "txtUsuarioUpdate";
            this.txtUsuarioUpdate.Size = new System.Drawing.Size(230, 22);
            this.txtUsuarioUpdate.TabIndex = 133;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddPhoto.FlatAppearance.BorderSize = 0;
            this.btnAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddPhoto.Location = new System.Drawing.Point(147, 260);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(25, 25);
            this.btnAddPhoto.TabIndex = 107;
            this.btnAddPhoto.Text = "+";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            // 
            // txtfather
            // 
            this.txtfather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfather.Location = new System.Drawing.Point(493, 284);
            this.txtfather.Name = "txtfather";
            this.txtfather.Size = new System.Drawing.Size(230, 22);
            this.txtfather.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(490, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 136;
            this.label2.Text = "Father ID:";
            // 
            // FormCatalogueMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfather);
            this.Controls.Add(this.txtusuarioCrea);
            this.Controls.Add(this.txtUsuarioUpdate);
            this.Controls.Add(this.txtFechaUpde);
            this.Controls.Add(this.btnDeletePhoto);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.panelMultiInsert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelAddedControl);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PictureBoxPhoto);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtfechacreacion);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtAbrevitura);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label4);
            this.Name = "FormCatalogueMaintenance";
            this.Text = "FormCatalogueMaintenance";
       //     this.Load += new System.EventHandler(this.FormCatalogueMaintenance_Load);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtAbrevitura, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.txttipo, 0);
            this.Controls.SetChildIndex(this.lbl, 0);
            this.Controls.SetChildIndex(this.lbl2, 0);
            this.Controls.SetChildIndex(this.txtfechacreacion, 0);
            this.Controls.SetChildIndex(this.Label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.Label6, 0);
            this.Controls.SetChildIndex(this.PictureBoxPhoto, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblConfirmPass, 0);
            this.Controls.SetChildIndex(this.panelAddedControl, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.panelMultiInsert, 0);
            this.Controls.SetChildIndex(this.btnAddPhoto, 0);
            this.Controls.SetChildIndex(this.btnDeletePhoto, 0);
            this.Controls.SetChildIndex(this.txtFechaUpde, 0);
            this.Controls.SetChildIndex(this.txtUsuarioUpdate, 0);
            this.Controls.SetChildIndex(this.txtusuarioCrea, 0);
            this.Controls.SetChildIndex(this.txtfather, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.panelMultiInsert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).EndInit();
            this.panelAddedControl.ResumeLayout(false);
            this.panelAddedControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMultiInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnAddUser;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtAbrevitura;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txttipo;
        internal System.Windows.Forms.Label lbl;
        internal System.Windows.Forms.Label lbl2;
        internal System.Windows.Forms.TextBox txtfechacreacion;
        internal System.Windows.Forms.TextBox txtusuarioCrea;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.PictureBox PictureBoxPhoto;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.RadioButton rbSingleInsert;
        private System.Windows.Forms.RadioButton rbMultiInsert;
        private System.Windows.Forms.Panel panelAddedControl;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnDeletePhoto;
        internal System.Windows.Forms.TextBox txtFechaUpde;
        internal System.Windows.Forms.TextBox txtUsuarioUpdate;
        internal System.Windows.Forms.Button btnAddPhoto;
        internal System.Windows.Forms.TextBox txtfather;
        internal System.Windows.Forms.Label label2;
    }
}