using System;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TheNoteGame
{
    public partial class RemoveOwners : Form
    {

        MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;database=thenotegame;persistsecurityinfo=True");
        ComboBox cGet, cSet;

        public RemoveOwners(ComboBox get, ComboBox set)
        {
            InitializeComponent();
            getUsers(remove_owners_checklist);
            cGet = get;
            cSet = set;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (var item in remove_owners_checklist.CheckedItems.OfType<string>().ToList())
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE Name = " + "'" + item + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(item + " was removed");
                cGet.Items.Remove(item);
                cSet.Items.Remove(item);
                conn.Close();
            }
            
            Visible = false;
        }

  

        private void getUsers(object sender)
        {
           
                conn.Open();
                var query = "SELECT Name FROM users";
                using (var command = new MySqlCommand(query, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {                       
                        while (reader.Read())
                        {
                        remove_owners_checklist.Items.Add(reader.GetString("Name"));
                                                
                        }
                    }
                }
            conn.Close();
        }
    }
}

