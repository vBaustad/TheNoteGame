using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TheNoteGame
{
    public partial class AddOwners : Form
    {
        
        MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;database=thenotegame;persistsecurityinfo=True");
        
        ComboBox cGet, cSet;
        
     

        public AddOwners(ComboBox get, ComboBox set)
        {
            InitializeComponent();
            cGet = get;
            cSet = set;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseProgram test = new BaseProgram();

            MySqlCommand cmd = new MySqlCommand("insert into Users(Name)Values('" + textbox1.Text + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            cGet.Items.Add(textbox1.Text);
            cSet.Items.Add(textbox1.Text);
                      
            MessageBox.Show("Success");
                       
            conn.Close();            
            Visible = false;
            
        }
    }
}
