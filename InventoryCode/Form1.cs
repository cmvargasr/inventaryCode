using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryCode
{

    public partial class Form1 : Form
    {
        private SqlConnection Cnx;
        private string StrCnx = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidateDataConnection()
        {
            bool ret = true;

            if (TextBoxSqlHost.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del host o el IP");
                return ret;
            }

            if (TextBoxSqlUser.Text.Trim().Length == 0 && RadioButtonNoAutentica.Checked)
            {
                MessageBox.Show("Debe ingresar el Usuario");
                return ret;
            }

            if (TextBoxSqlPassword.Text.Trim().Length == 0 && RadioButtonNoAutentica.Checked)
            {
                MessageBox.Show("Debe ingresar la contraseña");
                return ret;
            }

            return ret;
        }

        private bool DbConnect(bool pTrustedConnnection = false )
        {
            bool ret = false;
            string ValidateUser = ";User id=" + TextBoxSqlUser.Text + ";Password=" + TextBoxSqlPassword.Text;

            StrCnx = "Server=" + TextBoxSqlHost.Text + ";Database=" + TextBoxSqlDatabase.Text;

            if (pTrustedConnnection)
                ValidateUser = ";Trusted_Connection=yes;";

            StrCnx += ValidateUser;

            if (Cnx != null)
            {
                if (Cnx.State == ConnectionState.Open)
                    Cnx.Close();
            }

            try
            {
                Cnx = new SqlConnection(StrCnx);
                Cnx.Open();
                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ret;
        }

        private void RadioButtonSiAutentica_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxSqlUser.Enabled = false;
            TextBoxSqlPassword.Enabled = false;
            LabelDB_Usuario.Enabled = false;
            LabelDB_Password.Enabled = false;
        }

        private void RadioButtonNoAutentica_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxSqlUser.Enabled = true;
            TextBoxSqlPassword.Enabled = true;
            LabelDB_Usuario.Enabled = true;
            LabelDB_Password.Enabled = true;
        }

        private void ButtonViewSqlPassword_Click(object sender, EventArgs e)
        {
            if (TextBoxSqlPassword.Tag.ToString().Length == 0)
            {
                TextBoxSqlPassword.PasswordChar = (char)0;
                TextBoxSqlPassword.Tag = "1";
            }
            else
            { 
                TextBoxSqlPassword.PasswordChar = '.';
                string psw = TextBoxSqlPassword.Text;
                TextBoxSqlPassword.Text = "";
                TextBoxSqlPassword.Text = psw;
                TextBoxSqlPassword.Tag = "";
            }
        }

        private void ButtonSqlSearch_Click(object sender, EventArgs e)
        {
            if (!ValidateDataConnection())
                return;

            ComboBoxSqlDatabases.Items.Clear();

            if (DbConnect(RadioButtonSiAutentica.Checked))
            { 
                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases ORDER BY name", Cnx);
                SqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    ComboBoxSqlDatabases.Items.Add(dt.GetString(0));
                }
                dt.Close();
                Cnx.Close();
                ComboBoxSqlDatabases.Visible = true;
                TextBoxSqlDatabase.Visible = false;
                ComboBoxSqlDatabases.BringToFront();
                ComboBoxSqlDatabases.Focus();
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (!ValidateDataConnection())
                return;

            if (TextBoxPathFiles.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar la ruta de los archivos a inspeccionar");
                return;
            }

            if (!DbConnect(RadioButtonSiAutentica.Checked))
                return;

            ButtonSearch.Enabled = false;

            TextBoxMessage.Clear();

            SqlDataAdapter da = new SqlDataAdapter("select name from sys.objects where type in ('U','P','V')", Cnx);
            DataSet ds = new DataSet("obj");
            da.Fill(ds,"objs");
            DataTable dt = ds.Tables["objs"];

            string[] sqlObjects = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();

            string fileOutput = Directory.GetCurrentDirectory() + "\\" + TextBoxSqlDatabase.Text + "-Out.csv";

            string separetor = "|";

            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Join(separetor, "Database", "ObjectSQL", "File", "Line"));

            var exts = new[] { ".exe", ".dll", ".pdb", ".config",".css", ".pack", ".zip", ".7z", ".rar", ".bmp", ".emf", ".emz", ".eps", ".fpix", ".fpx", ".gif", ".jpeg", ".jfif", ".pdf", ".pict", ".pct", ".png", ".pntg", ".psd", ".qtif", ".sgi", ".tga", ".tpic", ".tiff", ".tif", ".wmf", ".wmz" };

            foreach (string sqlObject in sqlObjects)
            {
                var files = from file in Directory.EnumerateFiles(TextBoxPathFiles.Text, "*", SearchOption.AllDirectories)
                            .Where(file => !exts.Any(x => file.EndsWith(x,StringComparison.OrdinalIgnoreCase)))
                            from line in File.ReadLines(file)
                            where line.Contains(sqlObject)
                            select new
                            {
                                File = file,
                                Line = line
                            };

                foreach (var fi in files)
                {
                    if (fi.Line.Trim().Length > 0)
                    {
                        String[] newLine = { TextBoxSqlDatabase.Text, sqlObject, fi.File, fi.Line };
                        output.AppendLine(string.Join(separetor, newLine));

                        if (TextBoxMessage.Text.Length == 0)
                            TextBoxMessage.AppendText(fi.File + "\t" + fi.Line);
                        else
                            TextBoxMessage.AppendText("\r\n" + fi.File + "\t" + fi.Line);
                    }
                }
            }
            File.AppendAllText(fileOutput, output.ToString());

            Cnx.Close();

            ButtonSearch.Enabled = true;

            MessageBox.Show("Busqueda finalizada");
        }

        private void ButtonRutaArchivos_Click(object sender, EventArgs e)
        {
            DialogResult value = folderBrowserDialog1.ShowDialog();

            if (value != System.Windows.Forms.DialogResult.OK)
                return;

            TextBoxPathFiles.Text = folderBrowserDialog1.SelectedPath;

        }

        private void ComboBoxSqlDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxSqlDatabase.Text = ComboBoxSqlDatabases.Text;
        }
    }
}
