namespace InventoryCode
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.RadioButtonNoAutentica = new System.Windows.Forms.RadioButton();
            this.RadioButtonSiAutentica = new System.Windows.Forms.RadioButton();
            this.Label19 = new System.Windows.Forms.Label();
            this.ButtonSqlSearch = new System.Windows.Forms.Button();
            this.ButtonViewSqlPassword = new System.Windows.Forms.Button();
            this.TextBoxSqlPassword = new System.Windows.Forms.TextBox();
            this.TextBoxSqlUser = new System.Windows.Forms.TextBox();
            this.LabelDB_Password = new System.Windows.Forms.Label();
            this.LabelDB_Usuario = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.TextBoxSqlHost = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.TextBoxSqlDatabase = new System.Windows.Forms.TextBox();
            this.ComboBoxSqlDatabases = new System.Windows.Forms.ComboBox();
            this.TextBoxPathFiles = new System.Windows.Forms.TextBox();
            this.ButtonRutaArchivos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButtonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.ForeColor = System.Drawing.Color.Black;
            this.ButtonSearch.Location = new System.Drawing.Point(342, 379);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(80, 42);
            this.ButtonSearch.TabIndex = 17;
            this.ButtonSearch.Text = "&Buscar";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // RadioButtonNoAutentica
            // 
            this.RadioButtonNoAutentica.AutoSize = true;
            this.RadioButtonNoAutentica.Location = new System.Drawing.Point(245, 53);
            this.RadioButtonNoAutentica.Name = "RadioButtonNoAutentica";
            this.RadioButtonNoAutentica.Size = new System.Drawing.Size(39, 17);
            this.RadioButtonNoAutentica.TabIndex = 23;
            this.RadioButtonNoAutentica.Text = "No";
            this.RadioButtonNoAutentica.UseVisualStyleBackColor = true;
            this.RadioButtonNoAutentica.CheckedChanged += new System.EventHandler(this.RadioButtonNoAutentica_CheckedChanged);
            // 
            // RadioButtonSiAutentica
            // 
            this.RadioButtonSiAutentica.AutoSize = true;
            this.RadioButtonSiAutentica.Checked = true;
            this.RadioButtonSiAutentica.Location = new System.Drawing.Point(189, 53);
            this.RadioButtonSiAutentica.Name = "RadioButtonSiAutentica";
            this.RadioButtonSiAutentica.Size = new System.Drawing.Size(34, 17);
            this.RadioButtonSiAutentica.TabIndex = 22;
            this.RadioButtonSiAutentica.TabStop = true;
            this.RadioButtonSiAutentica.Text = "Si";
            this.RadioButtonSiAutentica.UseVisualStyleBackColor = true;
            this.RadioButtonSiAutentica.CheckedChanged += new System.EventHandler(this.RadioButtonSiAutentica_CheckedChanged);
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(12, 51);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(119, 13);
            this.Label19.TabIndex = 21;
            this.Label19.Text = "Autenticación Windows";
            // 
            // ButtonSqlSearch
            // 
            this.ButtonSqlSearch.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSqlSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSqlSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonSqlSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonSqlSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.ButtonSqlSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSqlSearch.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSqlSearch.Image")));
            this.ButtonSqlSearch.Location = new System.Drawing.Point(434, 147);
            this.ButtonSqlSearch.Name = "ButtonSqlSearch";
            this.ButtonSqlSearch.Size = new System.Drawing.Size(20, 20);
            this.ButtonSqlSearch.TabIndex = 31;
            this.ButtonSqlSearch.UseVisualStyleBackColor = false;
            this.ButtonSqlSearch.Click += new System.EventHandler(this.ButtonSqlSearch_Click);
            // 
            // ButtonViewSqlPassword
            // 
            this.ButtonViewSqlPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonViewSqlPassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonViewSqlPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonViewSqlPassword.Image = ((System.Drawing.Image)(resources.GetObject("ButtonViewSqlPassword.Image")));
            this.ButtonViewSqlPassword.Location = new System.Drawing.Point(434, 115);
            this.ButtonViewSqlPassword.Name = "ButtonViewSqlPassword";
            this.ButtonViewSqlPassword.Size = new System.Drawing.Size(19, 16);
            this.ButtonViewSqlPassword.TabIndex = 28;
            this.ButtonViewSqlPassword.UseVisualStyleBackColor = true;
            this.ButtonViewSqlPassword.Click += new System.EventHandler(this.ButtonViewSqlPassword_Click);
            // 
            // TextBoxSqlPassword
            // 
            this.TextBoxSqlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSqlPassword.Enabled = false;
            this.TextBoxSqlPassword.Location = new System.Drawing.Point(152, 115);
            this.TextBoxSqlPassword.Name = "TextBoxSqlPassword";
            this.TextBoxSqlPassword.PasswordChar = '.';
            this.TextBoxSqlPassword.Size = new System.Drawing.Size(270, 20);
            this.TextBoxSqlPassword.TabIndex = 27;
            // 
            // TextBoxSqlUser
            // 
            this.TextBoxSqlUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSqlUser.Enabled = false;
            this.TextBoxSqlUser.Location = new System.Drawing.Point(152, 81);
            this.TextBoxSqlUser.Name = "TextBoxSqlUser";
            this.TextBoxSqlUser.Size = new System.Drawing.Size(270, 20);
            this.TextBoxSqlUser.TabIndex = 25;
            // 
            // LabelDB_Password
            // 
            this.LabelDB_Password.AutoSize = true;
            this.LabelDB_Password.Enabled = false;
            this.LabelDB_Password.Location = new System.Drawing.Point(12, 117);
            this.LabelDB_Password.Name = "LabelDB_Password";
            this.LabelDB_Password.Size = new System.Drawing.Size(61, 13);
            this.LabelDB_Password.TabIndex = 26;
            this.LabelDB_Password.Text = "Contraseña";
            // 
            // LabelDB_Usuario
            // 
            this.LabelDB_Usuario.AutoSize = true;
            this.LabelDB_Usuario.Enabled = false;
            this.LabelDB_Usuario.Location = new System.Drawing.Point(12, 83);
            this.LabelDB_Usuario.Name = "LabelDB_Usuario";
            this.LabelDB_Usuario.Size = new System.Drawing.Size(43, 13);
            this.LabelDB_Usuario.TabIndex = 24;
            this.LabelDB_Usuario.Text = "Usuario";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(12, 151);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(77, 13);
            this.Label14.TabIndex = 29;
            this.Label14.Text = "Base de Datos";
            // 
            // TextBoxSqlHost
            // 
            this.TextBoxSqlHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSqlHost.Location = new System.Drawing.Point(152, 22);
            this.TextBoxSqlHost.Name = "TextBoxSqlHost";
            this.TextBoxSqlHost.Size = new System.Drawing.Size(270, 20);
            this.TextBoxSqlHost.TabIndex = 20;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(12, 24);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(134, 13);
            this.Label15.TabIndex = 19;
            this.Label15.Text = "Nombre Host (IP or DDNS)";
            // 
            // TextBoxSqlDatabase
            // 
            this.TextBoxSqlDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSqlDatabase.Location = new System.Drawing.Point(152, 149);
            this.TextBoxSqlDatabase.Name = "TextBoxSqlDatabase";
            this.TextBoxSqlDatabase.Size = new System.Drawing.Size(270, 20);
            this.TextBoxSqlDatabase.TabIndex = 30;
            // 
            // ComboBoxSqlDatabases
            // 
            this.ComboBoxSqlDatabases.FormattingEnabled = true;
            this.ComboBoxSqlDatabases.Location = new System.Drawing.Point(152, 149);
            this.ComboBoxSqlDatabases.Name = "ComboBoxSqlDatabases";
            this.ComboBoxSqlDatabases.Size = new System.Drawing.Size(270, 21);
            this.ComboBoxSqlDatabases.TabIndex = 32;
            this.ComboBoxSqlDatabases.Visible = false;
            this.ComboBoxSqlDatabases.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSqlDatabases_SelectedIndexChanged);
            // 
            // TextBoxPathFiles
            // 
            this.TextBoxPathFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPathFiles.Location = new System.Drawing.Point(152, 182);
            this.TextBoxPathFiles.Name = "TextBoxPathFiles";
            this.TextBoxPathFiles.Size = new System.Drawing.Size(270, 20);
            this.TextBoxPathFiles.TabIndex = 33;
            // 
            // ButtonRutaArchivos
            // 
            this.ButtonRutaArchivos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonRutaArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRutaArchivos.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRutaArchivos.Image")));
            this.ButtonRutaArchivos.Location = new System.Drawing.Point(428, 181);
            this.ButtonRutaArchivos.Name = "ButtonRutaArchivos";
            this.ButtonRutaArchivos.Size = new System.Drawing.Size(26, 19);
            this.ButtonRutaArchivos.TabIndex = 34;
            this.ButtonRutaArchivos.UseVisualStyleBackColor = true;
            this.ButtonRutaArchivos.Click += new System.EventHandler(this.ButtonRutaArchivos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ruta para busqueda";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.BackColor = System.Drawing.Color.Black;
            this.TextBoxMessage.ForeColor = System.Drawing.Color.Lime;
            this.TextBoxMessage.Location = new System.Drawing.Point(15, 228);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(438, 134);
            this.TextBoxMessage.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 433);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPathFiles);
            this.Controls.Add(this.ButtonRutaArchivos);
            this.Controls.Add(this.RadioButtonNoAutentica);
            this.Controls.Add(this.RadioButtonSiAutentica);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.ButtonSqlSearch);
            this.Controls.Add(this.ButtonViewSqlPassword);
            this.Controls.Add(this.TextBoxSqlPassword);
            this.Controls.Add(this.TextBoxSqlUser);
            this.Controls.Add(this.LabelDB_Password);
            this.Controls.Add(this.LabelDB_Usuario);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.TextBoxSqlHost);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxSqlDatabase);
            this.Controls.Add(this.ComboBoxSqlDatabases);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Busqueda objetos DB en Codigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.RadioButton RadioButtonNoAutentica;
        private System.Windows.Forms.RadioButton RadioButtonSiAutentica;
        private System.Windows.Forms.Label Label19;
        private System.Windows.Forms.Button ButtonSqlSearch;
        private System.Windows.Forms.Button ButtonViewSqlPassword;
        private System.Windows.Forms.TextBox TextBoxSqlPassword;
        private System.Windows.Forms.TextBox TextBoxSqlUser;
        private System.Windows.Forms.Label LabelDB_Password;
        private System.Windows.Forms.Label LabelDB_Usuario;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.TextBox TextBoxSqlHost;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.TextBox TextBoxSqlDatabase;
        private System.Windows.Forms.ComboBox ComboBoxSqlDatabases;
        private System.Windows.Forms.TextBox TextBoxPathFiles;
        private System.Windows.Forms.Button ButtonRutaArchivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

    }
}

