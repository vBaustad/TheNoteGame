using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TheNoteGame
{
    public partial class BaseProgram : Form
    {
        string sqlConnection = "server=localhost;userid=root;database=thenotegame;persistsecurityinfo=True";
        
        

        public BaseProgram()
        {
            InitializeComponent();            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getUsers();
            
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addNote_button_click(object sender, EventArgs e)
        {

        }

        private void getNote_button_click(object sender, EventArgs e)
        {
                using (var conn = new MySqlConnection(sqlConnection))
                {
                    conn.Open();
                    string number = textbox_number_input.Text;
                    string name = get_combobox_names.Text;
                    var query = "SELECT * FROM `activity` WHERE Number = '" + number + "' AND Name = '" + name + "'";

                    using (var command = new MySqlCommand(query, conn))
                    {


                    using (var reader = command.ExecuteReader())
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("There's no note with that number.");
                        }else if (reader.Read())
                        {
                            textboxNote_desc.Text = reader.GetString(3).ToString();

                        }
                    }
                     conn.Close();
            }  
           
        }

        private void addOwners(object sender, EventArgs e)
        {
            AddOwners form = new AddOwners(get_combobox_names, set_combobox_names);
            form.Show();
        }

        private void removeOwners(object sender, EventArgs e)
        {
            RemoveOwners form = new RemoveOwners(get_combobox_names, set_combobox_names);
            form.Show();
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            var query = "SELECT Number FROM activity WHERE Name =" + set_combobox_names.Text + " ORDER BY Number ASC";
            string names = set_combobox_names.Text;
            string note = textboxNote_desc.Text;
            int number = 1;

            MySqlConnection conn = new MySqlConnection(sqlConnection);
            conn.Open();

            MySqlCommand checkRows = new MySqlCommand("SELECT COUNT(*) from activity", conn);
            int result = int.Parse(checkRows.ExecuteScalar().ToString());

            if (result == 0)
            {
                number = 1;

            }
            else
            {
                MySqlCommand getNames = new MySqlCommand("SELECT * from activity", conn);

                using (MySqlDataReader reader = getNames.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        string navn = reader.GetString(2).ToString();
                        

                        if (!navn.Equals(names))
                        {
                            continue;

                        }else 
                        {
                                int tall = int.Parse(reader.GetString(1));
                                if (tall <= number)
                                {
                                    ++number;
                                }

                            }

                        }
                        reader.Close();

                    }

                }

            MySqlCommand addActivity = new MySqlCommand("insert into Activity(Number, Name, Activity, Date)Values('" + number + "','" + 
                                                        names + "','" + note + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')", conn);

            addActivity.ExecuteNonQuery();
            MessageBox.Show("Save success");
            
            conn.Close();
        
    }
        

        public void getUsers()
        {

            MySqlConnection conn = new MySqlConnection(sqlConnection);
            
                
            conn.Open();

            string query = "SELECT Name FROM users";
            MySqlCommand command = new MySqlCommand(query, conn);
                
            set_combobox_names.Items.Clear();
            get_combobox_names.Items.Clear();
            var reader = command.ExecuteReader();
                
            while (reader.Read())
            {
                string name = reader.GetString("Name");
                set_combobox_names.Items.Add(name);
                get_combobox_names.Items.Add(name);
                            
                
            }
        }

        private void textboxNote_desc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
