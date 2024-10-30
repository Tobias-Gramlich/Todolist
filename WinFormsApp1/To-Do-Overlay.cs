using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WinFormsApp1
{
    public partial class Overlay : Form
    {


        public Overlay()
        {
            InitializeComponent();

            var conn = new SQLiteConnection("Data Source=C:\\Users\\tgramlich\\Desktop\\S1.P1\\To-Do-List\\Datenbank_todolist.db");
            conn.Open();

            var createtable = new SQLiteCommand("CREATE TABLE IF NOT EXISTS ToDos (" +
                                                "Primarykey INTEGER PRIMARY KEY, Name TEXT, Description TEXT, Date TEXT, Done INTEGER)"
                                                , conn);
            createtable.ExecuteNonQuery();

            var removetable = new SQLiteCommand("DELETE FROM ToDos WHERE Done IS '1'", conn);
            removetable.ExecuteNonQuery();

            var Datenlesen = new SQLiteCommand("SELECT * FROM ToDos", conn);
            var reader = Datenlesen.ExecuteReader();

            while (reader.Read())
            {
                int col1 = reader.GetInt32(0);
                string col2 = reader.GetString(1);
                string col3 = reader.GetString(2);
                string col4 = reader.GetString(3);
                int col5 = reader.GetInt32(4);

                if (col5 == 0)
                {
                    Liste.Items.Add(col4 + ' ' + col2 + ": " + col3);
                }
            }
            conn.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Liste.Items.Add(datum.Text + ' ' + Eingabename.Text + ": " + Description.Text);

            var conn = new SQLiteConnection("Data Source=C:\\Users\\tgramlich\\Desktop\\S1.P1\\To-Do-List\\Datenbank_todolist.db");
            conn.Open();

            var insertdata = new SQLiteCommand("INSERT INTO ToDos (Name, Description, Date, Done) VALUES('"
                                                + Eingabename.Text.ToString() + "', '"
                                                + Description.Text.ToString() + "', '"
                                                + datum.Text.ToString() + "', "
                                                + "0" + ")", conn);
            insertdata.ExecuteNonQuery();

            conn.Close();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var conn = new SQLiteConnection("Data Source=C:\\Users\\tgramlich\\Desktop\\S1.P1\\To-Do-List\\Datenbank_todolist.db");
            conn.Open();

            var Datenlesen = new SQLiteCommand("SELECT * FROM ToDos", conn);
            var reader = Datenlesen.ExecuteReader();

            while (reader.Read())
            {
                string col2 = reader.GetString(1);

                if (col2 == RemoveName.Text) 
                {
                    string col3 = reader.GetString(2);
                    string col4 = reader.GetString(3);

                    Liste.Items.Remove(col4 + ' ' + col2 + ": " + col3);

                    var removetable = new SQLiteCommand("DELETE FROM ToDos WHERE Name IS '" + col2 + "'", conn);
                    removetable.ExecuteNonQuery();
                }
            }
            conn.Close();
        }

        private void removeall_Click(object sender, EventArgs e)
        {
            var conn = new SQLiteConnection("Data Source=C:\\Users\\tgramlich\\Desktop\\S1.P1\\To-Do-List\\Datenbank_todolist.db");
            conn.Open();

            Liste.Items.Clear();
            var removeall = new SQLiteCommand("DROP TABLE IF EXISTS ToDos", conn);
            removeall.ExecuteNonQuery();

            conn.Close();
        }

        private void Liste_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var conn = new SQLiteConnection("Data Source=C:\\Users\\tgramlich\\Desktop\\S1.P1\\To-Do-List\\Datenbank_todolist.db");
            conn.Open();

            int index = e.Index + 1;

            if (e.NewValue.ToString() == "Checked")
            {
                var checkeddata = new SQLiteCommand("UPDATE ToDos SET Done = 1 WHERE PrimaryKey = '" + index.ToString() + "'", conn);
                checkeddata.ExecuteNonQuery();
            }
            else
            {
                var checkeddata = new SQLiteCommand("UPDATE ToDos SET Done = 0 WHERE PrimaryKey = '" + index.ToString() + "'", conn);
                checkeddata.ExecuteNonQuery();
            }

            conn.Close();
        }
    }
}
