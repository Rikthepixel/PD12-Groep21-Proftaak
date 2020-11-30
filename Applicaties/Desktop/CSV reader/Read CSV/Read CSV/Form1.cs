using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SQLDataLibrary;
using Dapper;
using System.Net.Sockets;
using System.Reflection;
using System.Diagnostics;


namespace Read_CSV
{
    public partial class Form1 : Form
    {
        SerialPort ArduinoPort;
        DataTable data;


        int ZoekOp = 1;
        bool SearchbarActive;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< Website
            ArduinoPort = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
=======
            ArduinoPort = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
>>>>>>> [Addition] CSV reader (technology)
=======
            ArduinoPort = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
>>>>>>> Application

            string ExecutableLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); //Gets the .exe file location
            string CSVPath = Path.Combine(ExecutableLocation, "data.csv"); //Get CSV data file path

            string[] str = File.ReadAllLines(CSVPath); //csv importeren

            data = new DataTable(); //nieuw datatabel

            string[] temp = str[0].Split(','); //kop namen
            //Column names
            foreach (string t in temp)
            {
                if (t.Contains("Volledige naam"))
                {
                    //Zet de column volledige naam naar Volnaam, want spaties doen weer leuk met de filter...
                    data.Columns.Add("Volnaam", typeof(string));
                }
                else
                {
                    //De rest mag gewoon zo heten als dat het wilt :p
                    data.Columns.Add(t, typeof(string));
                }
            }

            //rest erbij
            for (int i = 1; i < str.Length; i++)
            {
                string[] t = str[i].Split(',');
                data.Rows.Add(t);
            }
            dataGridView1.DataSource = data; //dataset laten zien
            dataGridView1.Columns[1].HeaderText = "Volledige naam";

            data.DefaultView.Sort = "Barcode ASC";

            ArduinoPort.Open();
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataRecieved);
        }

        public List<T> LoadData<T>(MySqlConnection Connection, string SQLstatement)
        {
            using (Connection)
            {
                var rows = Connection.Query<T>(SQLstatement);
                return rows.ToList();
            }
        }
        private void searchbar_Gotfocus(object sender, EventArgs e)
        {
            SearchbarActive = true;
        }
        private void searchbar_Lostfocus(object sender, EventArgs e)
        {
            SearchbarActive = false;
        }

        private void DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            if (SearchbarActive)
            {
<<<<<<< HEAD
<<<<<<< Website
                string ArduinoInput = ArduinoPort.ReadLine().ToString();
                if(ArduinoInput != String.Empty)
                {
                    ArduinoInput = ArduinoInput.Trim();
                    if (InvokeRequired)
                    {
                        this.Invoke(new Action<object, SerialDataReceivedEventArgs>(DataRecieved), new object[] { sender, e });
                        return;
                    }
                    searchbar.Text += ArduinoInput;
                    InitiateSearch();
                }
 
=======
=======
>>>>>>> Application
                string ArduinoInput = ArduinoPort.ReadLine();

                if (InvokeRequired)
                {
                    this.Invoke(new Action<object,SerialDataReceivedEventArgs>(DataRecieved), new object[] { sender, e });
                    return;
                }

                searchbar.Text += ArduinoInput;
<<<<<<< HEAD
>>>>>>> [Addition] CSV reader (technology)
=======
>>>>>>> Application

            }
        }
        private void searchbar_KeyUp(object sender, KeyEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< Website
            InitiateSearch();
        }

        private void InitiateSearch()
        {
=======
>>>>>>> [Addition] CSV reader (technology)
=======
>>>>>>> Application
            string ZoekOpStr;
            switch (ZoekOp)
            {
                case 1:
                    ZoekOpStr = data.Columns[0].ColumnName;
                    break;
                case 2:
                    ZoekOpStr = data.Columns[1].ColumnName;
                    break;
                case 3:
                    ZoekOpStr = data.Columns[2].ColumnName;
                    break;
                default:
                    ZoekOpStr = data.Columns[0].ColumnName;
<<<<<<< HEAD
<<<<<<< Website
                    break;
            }
            string thingy = Convert.ToString(0087714817);
            if (searchbar.Text.Length == 0)
            {
                data.DefaultView.RowFilter = String.Empty;
            }
            else
            {
                data.DefaultView.RowFilter = $"{ZoekOpStr} LIKE '%{searchbar.Text}%'";
            }
        }
=======
=======
>>>>>>> Application
                    break; 
            }
            string thingy = Convert.ToString(0087714817);
            if(searchbar.Text.Length == 0)
            {
                data.DefaultView.RowFilter = String.Empty;
            } else
            {
                data.DefaultView.RowFilter = $"{ZoekOpStr} LIKE '%{searchbar.Text}%'";
            }

        }

<<<<<<< HEAD
>>>>>>> [Addition] CSV reader (technology)
=======
>>>>>>> Application
        #region Radio buttons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ZoekOp = 1;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ZoekOp = 2;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                ZoekOp = 3;
            }
        }

        #endregion

    }
}
