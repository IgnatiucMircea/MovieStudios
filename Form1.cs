using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms_studio
{
    public partial class Form1 : Form
    {
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();

        private string childTableName = ConfigurationManager.AppSettings["ChildTableName"];
        private string parentTableName = ConfigurationManager.AppSettings["ParentTableName"];

        private string columnNamesInsertParameters = ConfigurationManager.AppSettings["ColumnNamesInsertParameters"];

        private string columnNamesInsertParametersIns = ConfigurationManager.AppSettings["ColumnNamesInsertParametersIns"];

        private List<string> columnNames = new List<string>(ConfigurationManager.AppSettings["ChildLabelNames"].Split(','));

        private List<string> columnNamesIns = new List<string>(ConfigurationManager.AppSettings["ChildLabelNamesIns"].Split(','));

        private List<string> paramsNames = new List<string>(ConfigurationManager.AppSettings["ColumnNamesInsertParameters"].Split(','));

        private List<string> paramsNamesIns = new List<string>(ConfigurationManager.AppSettings["ColumnNamesInsertParametersIns"].Split(','));

        private List<string> columnInitiate = new List<string>(ConfigurationManager.AppSettings["ChildTextBoxContent"].Split(','));
        private SqlConnection connection = new SqlConnection(GetConnectionString());
        private int nr = Convert.ToInt32(ConfigurationManager.AppSettings["ChildNumberOfColumns"]);

        private TextBox[] textBoxes;
        private Label[] labels;

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["cn"].ConnectionString.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            PopulatePanel();
            parentLabel.Text = parentTableName;
            childLabel.Text = childTableName;
            parentgrid.SelectionChanged += new EventHandler(LoadChildren);
            childgrid.SelectionChanged += new EventHandler(LoadInformation);
            LoadParent();
        }

        private void LoadInformation(object sender, EventArgs e)
        {
            LoadInformation();
        }

        private void LoadInformation()
        {
            for (int i = 0; i < nr; i++)
                textBoxes[i].Text = Convert.ToString(childgrid.CurrentRow.Cells[i].Value);
        }

        private void PopulatePanel()
        {
            textBoxes = new TextBox[nr];
            labels = new Label[nr];

            for (int i = 0; i < nr; i++)
            {
                textBoxes[i] = new TextBox();
                textBoxes[i].Text = columnInitiate[i];
                labels[i] = new Label();
                labels[i].Text = columnNames[i];
            }

            for (int i = 0; i < nr; i++)
            {
                flowLayoutPanel.Controls.Add(textBoxes[i]);
                flowLayoutPanel.Controls.Add(labels[i]);
            }
        }

        private void LoadParent()
        {
            string select = ConfigurationSettings.AppSettings["SelectParent"];
            da.SelectCommand = new SqlCommand(select, connection);
            ds.Clear();
            da.Fill(ds);
            parentgrid.DataSource = ds.Tables[0];
        }

        private void LoadChildren(object sender, EventArgs e)
        {
            LoadChildren();
        }

        private void LoadChildren()
        {
            int parentId = (int)parentgrid.CurrentRow.Cells[0].Value;
            string select = ConfigurationManager.AppSettings["SelectChild"];
            SqlCommand cmd = new SqlCommand(select, connection);
            cmd.Parameters.AddWithValue(ConfigurationManager.AppSettings["ParentId"], parentId);
            SqlDataAdapter daChild = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();

            daChild.Fill(dataSet);
            childgrid.DataSource = dataSet.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into " + childTableName + " ( " + ConfigurationManager.AppSettings["ChildLabelNamesIns"] + " ) values ( " + columnNamesInsertParametersIns + " )", connection);
                for (int i = 0; i < nr-1; i++)
                {
                    cmd.Parameters.AddWithValue(paramsNamesIns[i], textBoxes[i+1].Text);
                }
                SqlDataAdapter daChild = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                connection.Open();
                daChild.Fill(dataSet);
                connection.Close();
                LoadChildren();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                connection.Close();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string update = ConfigurationManager.AppSettings["UpdateQuery"];
                SqlCommand cmd = new SqlCommand(update, connection);
                for (int i = 0; i < nr; i++)
                {
                    cmd.Parameters.AddWithValue(paramsNames[i], textBoxes[i].Text);
                }
                SqlDataAdapter daChild = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                connection.Open();
                daChild.Fill(dataSet);
                connection.Close();
                LoadChildren();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                connection.Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                    "Do you want to delete the item?",
                    "Confirm delete",
                    MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    string delete = ConfigurationManager.AppSettings["DeleteChild"];
                    SqlCommand cmd = new SqlCommand(delete, connection);
                    cmd.Parameters.AddWithValue(ConfigurationManager.AppSettings["ChildId"], (int)childgrid.CurrentRow.Cells[0].Value); ;
                    SqlDataAdapter daChild = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    daChild.Fill(dataSet);
                    connection.Close();
                    LoadChildren();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    connection.Close();
                }
            }
        }
    }
}
