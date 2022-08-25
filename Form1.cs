using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WSConnectorSimu;

namespace Traceability_Simu
{
    public partial class Form1 : Form
    {
        //For create base file
        private BaseDP[] BaseDP = new BaseDP[]
        {
            new BaseDP(){ PartNumber = "PartNumber", SerialNumber = "SerialNumber", StationName = "StationName", ProcessName = "ProcessName", Pass_Fail = "Pass_Fail"
                , TimesTested = "TimesTested", EntranceTime = "EntranceTime", ExitTime = "ExitTime", FailString = "FailString", UserName = "UserName" }
        };

        //For create base process file
        private ProcessDP[] Process = new ProcessDP[]
        {
            new ProcessDP(){ NumberProcess = "NumberProcess", Station = "Station", Process = "Process"},
            new ProcessDP(){ NumberProcess = "1", Station = "ITA_LASER06", Process = "SMT APPLY PANEL LABEL PASS 1"},
            new ProcessDP(){ NumberProcess = "2", Station = "STA_ICTE14", Process = "TEST ICT"},
            new ProcessDP(){ NumberProcess = "3", Station = "STA_FLASH32", Process = "FLASH PROGRAM"},
            new ProcessDP(){ NumberProcess = "4", Station = "SOA_SINGPNL59", Process = "GENERAL ROUTER DEPANEL"},
            new ProcessDP(){ NumberProcess = "5", Station = "ITA_AOI60", Process = "CONFORMAL INSPECTION PASS 1"},
            new ProcessDP(){ NumberProcess = "6", Station = "STA_FNLFUNC193", Process = "TEST FINAL FUNCTIONAL"},
            new ProcessDP(){ NumberProcess = "7", Station = "SOM_GP12_86", Process = "TEST GP12 PASS 1"},
            new ProcessDP(){ NumberProcess = "8", Station = "SPM_SHIPCHKIN01", Process = "SHIPPING CHECK-IN"}
        };

        //For create base serial file
        private SerialDP[] SerialDP = new SerialDP[]
        {
            new SerialDP(){ SerialReg = "SerialReg", PartNumber = "PartNumber"}
        };

        public Form1()
        {
            InitializeComponent();
        }

        //Path where the database is saved
        public string BasedataPath = AppDomain.CurrentDomain.BaseDirectory + "\\data\\Basedata.csv";
        //Path where the station-process relationship is saved
        public string ProcessPath = AppDomain.CurrentDomain.BaseDirectory + "\\data\\Process.csv";
        //Path where the registered serials are saved
        public string SerialPath = AppDomain.CurrentDomain.BaseDirectory + "\\data\\Serials.csv";

        private void Form1_Load(object sender, EventArgs e)
        {
            //Default plant
            toolStripComboBox1.Text = "Plant 1";

            //Create files
            string array = null;
            bool FileExistDB = false;
            bool FileExistPB = false;
            bool FileExistSB = false;
            //Create the csv files that the application needs to run.
            try
            {
                //DataBase: create if don't exist the file
                if (File.Exists(BasedataPath)) 
                {
                    FileExistDB = true;
                }
                //DataBase: if it does not exist, it is create
                if (FileExistDB == false) 
                {
                    StreamWriter writer = new StreamWriter(BasedataPath, false);
                    for (int i = 0; i < BaseDP.Length; i++)
                    {
                        array = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}", BaseDP[i].PartNumber, BaseDP[i].SerialNumber, BaseDP[i].StationName,
                            BaseDP[i].ProcessName, BaseDP[i].Pass_Fail, BaseDP[i].TimesTested, BaseDP[i].EntranceTime, BaseDP[i].ExitTime, BaseDP[i].FailString,
                            BaseDP[i].UserName);
                        writer.WriteLine(array);
                    }
                    writer.Close();
                    FileExistDB = true;
                    array = null;
                }
                //ProcessBase: create if don't exist the file
                if (File.Exists(ProcessPath))
                {
                    FileExistPB = true;
                }
                //if it does not exist, it is create
                if (FileExistPB == false) 
                {
                    StreamWriter writer = new StreamWriter(ProcessPath, false);
                    for (int i = 0; i < Process.Length; i++)
                    {
                        array = string.Format("{0};{1};{2}", Process[i].NumberProcess, Process[i].Station, Process[i].Process);
                        writer.WriteLine(array);
                    }
                    writer.Close();
                    FileExistPB = true;
                    array = null;
                }
                //SerialBase: create if don't exist the file
                if (File.Exists(SerialPath)) 
                {
                    FileExistSB = true;
                }
                //if it does not exist, it is create
                if (FileExistSB == false) 
                {
                    StreamWriter writer = new StreamWriter(SerialPath, false);
                    for (int i = 0; i < SerialDP.Length; i++)
                    {
                        array = string.Format("{0};{1}", SerialDP[i].SerialReg, SerialDP[i].PartNumber);
                        writer.WriteLine(array);
                    }
                    writer.Close();
                    FileExistSB = true;
                    array = null;
                }
                //Update combobox process
                StreamReader sr = new StreamReader(ProcessPath);
                string x = null;
                string[] y = null;
                x = sr.ReadToEnd();
                y = x.Split('\n');
                string data = null;
                int lastvalueidx = y.Length - 1;
                StationVali.Items.Clear();
                if (y[lastvalueidx] == null)
                {
                    lastvalueidx = lastvalueidx - 1;
                }
                for (int i = 1; i < lastvalueidx; i++)
                {
                    data = y[i].Split(';')[1];
                    StationVali.Items.Add(data);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error to create CSV...",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Path where the database is saved
            string UsingDLL = AppDomain.CurrentDomain.BaseDirectory + "WSConnectorSimu.dll";
            string DLL1 = AppDomain.CurrentDomain.BaseDirectory + "\\packages\\Plant 1\\WSConnectorSimu.dll";
            string DLL2 = AppDomain.CurrentDomain.BaseDirectory + "\\packages\\Plant 2\\WSConnectorSimu.dll";
            try
            {
                if (toolStripComboBox1.Enabled) //Si el control no esta activo es porque ya se inicio el programa
                {
                    if (toolStripComboBox1.Text != "Plant 1") // If change to plant 2
                    {
                        File.Delete(UsingDLL);
                        File.Copy(DLL2, UsingDLL);
                    }
                    else  // If change to plant 1
                    {
                        File.Delete(UsingDLL);
                        File.Copy(DLL1, UsingDLL);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is UnauthorizedAccessException)
                {
                    MessageBox.Show(ex.Message.ToString(), "The plant can only be modified at the start the program.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message.ToString(), "Error in main dll change...",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                toolStripComboBox1.Enabled = false; //Desactivo el control y se escribe que dll esta cargada al programa
                if(toolStripComboBox1.Text == "Plant 2")
                {
                    toolStripComboBox1.Text = "Plant 1";
                }
                else
                {
                    toolStripComboBox1.Text = "Plant 2";
                }
            }
        }

        private void ButtonTest_Click_1(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            string ser_num = TxTSerialVali.Text;
            string station_name = StationVali.Text;
            if (ser_num != "" && station_name != "")
            {
                string backcheck = connector.BackCheck_Serial(ser_num, station_name);
                int status = Int32.Parse(backcheck.Split('|')[0]);
                string function = backcheck.Split('|')[1];
                string replyBackCheck = function; //for variable change if is plant 2
                if (status == 1)
                {
                    int pass_fail = 0;
                    string fail_string = "";
                    string employee = "Test Simu";
                    string ent_time;
                    string ext_time;
                    connector.CIMP_GetDateTimeStr(out ent_time);
                    DialogResult testscript = MessageBox.Show("Test Pass?", "Test script simu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (testscript == DialogResult.Yes)
                    {
                        pass_fail = 1;
                    }
                    else
                    {
                        fail_string = "Random fail";
                    }
                    connector.CIMP_GetDateTimeStr(out ext_time);
                    // If it is Plant 2, get the process.
                    if (toolStripComboBox1.Text == "Plant 2")
                    {
                        function = "";
                        StreamReader read;
                        string baseprocess;
                        bool finded;
                        finded = false;
                        string[] infopcb = new string[3];
                        char[] separate = { ';' };
                        try 
                        {
                            read = File.OpenText(ProcessPath);
                            baseprocess = read.ReadLine();
                            while(baseprocess != null && finded == false)
                            {
                                infopcb = baseprocess.Split(separate);
                                if (infopcb[1].Trim().Equals(station_name))
                                {
                                    function = infopcb[2].Trim();
                                    finded = true;
                                }
                                else
                                {
                                    baseprocess = read.ReadLine();
                                }
                            }
                            read.Close();
                        }
                        catch(Exception fe)
                        {
                            //failure that should not happen xd
                            MessageBox.Show("Exception: " + fe.Message, "Fail with WSConnector.dll plant 2 in files.csv",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //saddsasfdnidsfsdf
                    string reply = connector.InsertProcessDataWithFails(ser_num, station_name, function, ent_time, ext_time, pass_fail, fail_string, employee);
                    //If the data is uploaded correctly
                    if (reply == "OK" || reply.Split('|')[0] == "OK ")
                    {
                        MessageBox.Show("Data uploaded. Reply:\n" + reply, "Process completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Read the file in the datagrid
                        try
                        {
                            // Open file
                            StreamReader reader = new StreamReader(BasedataPath);
                            string array = null;
                            string[] arraytmp = null;
                            array = reader.ReadLine();
                            DbVali.Rows.Clear();
                            while (array != null)
                            {
                                arraytmp = array.Split(';');
                                DbVali.Rows.Add(arraytmp);
                                array = reader.ReadLine();
                            }
                            // Close file
                            reader.Close();
                        }
                        catch (Exception readfail)
                        {
                            //failure that should not happen xd
                            MessageBox.Show("Exception: " + readfail.Message, "Fail with WSConnector.dll in files.csv",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else //Fail for no upload the information
                    {
                        MessageBox.Show(reply, "Error uploading data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else //Fail backcheck
                {
                    if (function.Split(':')[0] == "Fail" || replyBackCheck.Split(':')[0] == "Fail")  //Fail in backcheck
                    {
                        if(toolStripComboBox1.Text == "Plant 1")
                        {
                            MessageBox.Show("BackCheck:\n" + function, "Backcheck fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("BackCheck:\n" + replyBackCheck, "Backcheck fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else //Error in backcheck for exception
                    {
                        MessageBox.Show(backcheck, "Error uploading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter serial or station", "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonBackcheck_Click_1(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            string _serialNumber = TxTSerialVali.Text;
            string _stationName = StationVali.Text;
            if (_serialNumber != "" && _stationName != "")
            {
                string backcheck = connector.BackCheck_Serial(_serialNumber, _stationName);
                MessageBox.Show("BackCheck is:\n" + backcheck, "Reply BackCheck", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter serial or station", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefreshVali_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Open file
                StreamReader reader = new StreamReader(BasedataPath);
                string array = null;
                string[] arraytmp = null;
                array = reader.ReadLine();
                DbVali.Rows.Clear();
                while (array != null)
                {
                    arraytmp = array.Split(';');
                    DbVali.Rows.Add(arraytmp);
                    array = reader.ReadLine();
                }
                //Close file
                reader.Close();

                //Update combobox process
                StreamReader sr = new StreamReader(ProcessPath);
                string x = null;
                string[] y = null;
                x = sr.ReadToEnd();
                y = x.Split('\n');
                string data = null;
                int lastvalueidx = y.Length - 1;
                StationVali.Items.Clear();
                if (y[lastvalueidx] == null)
                {
                    lastvalueidx = lastvalueidx - 1;
                }
                for (int i = 1; i < lastvalueidx; i++)
                {
                    data = y[i].Split(';')[1];
                    StationVali.Items.Add(data);
                }
                sr.Close();
            }
            catch (Exception readfail)
            {
                MessageBox.Show("Exception: " + readfail.Message);
            }
        }

        private void buttonPartNumber_Click(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            string SerialNumber = TxTSerialVali.Text;
            int BCTYPE = 1;
            string AssemblyPartNumber = null;
            if (SerialNumber != "")
            {
                string reply = connector.CIMP_PartNumberRef(SerialNumber, BCTYPE, ref AssemblyPartNumber);
                //if (reply == "")
                if (AssemblyPartNumber != null)
                {
                    MessageBox.Show("The Part Number is: " + AssemblyPartNumber, "PartNumber", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (AssemblyPartNumber == null && reply == "")
                    {
                        MessageBox.Show("Enter a valid serial", "Serial no exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else /*if (reply != null) */
                {
                    MessageBox.Show(reply, "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter serial", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchDLL_Click(object sender, EventArgs e)
        {
            string filepath = AppDomain.CurrentDomain.BaseDirectory + @"dll";
            System.Diagnostics.Process.Start("explorer.exe", filepath);
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            string contenido = null;
            string serial = TxtSerialReg.Text;
            string partnumber = TxtPartNumbReg.Text;
            contenido = String.Format("{0};{1}", serial, partnumber);
            if (serial != "" && partnumber != "")
            {
                try
                {
                    StreamWriter writer = new StreamWriter(SerialPath, true); // Objeto que escribe             
                    writer.WriteLine(contenido);
                    // Cierre de flujo
                    writer.Close();
                    MessageBox.Show("Serial successfully registered", "Data added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtSerialReg.Clear();
                    TxtPartNumbReg.Clear();
                    LoadCSVData(SerialPath, ';');
                    txtFileCSV.Text = SerialPath;
                }
                catch (Exception writefail)
                {
                    MessageBox.Show("Exception: " + writefail.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter Serial o Part number", "Invalid information",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSelImportFile_Click(object sender, EventArgs e)
        { //Select file
            OpenFileDialog dlFileCSV = new OpenFileDialog();
            dlFileCSV.Title = "Open file CSV...";
            dlFileCSV.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "data";
            dlFileCSV.Filter = "CSV files (*.csv)|*.csv|" + "All files (*.*)|*.*";
            dlFileCSV.FilterIndex = 1;
            dlFileCSV.RestoreDirectory = true;
            if (dlFileCSV.ShowDialog() == DialogResult.OK)
            {
                txtFileCSV.Text = dlFileCSV.FileName;
            }
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtFileCSV.Text))
            {
                char separator = ';'; // how to separate the file: serial, part, etc
                try
                {
                    LoadCSVData(txtFileCSV.Text, separator);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error reading CSV...",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selected CSV file does not exist.",
                    "File not found...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Load a CSV file into a DataGridView
        private void LoadCSVData(string FileCSV, char separator)
        {
            dbTable.DataSource = null;
            dbTable.Rows.Clear();
            DataTable tableData = new DataTable();
            string[] lines = File.ReadAllLines(FileCSV, Encoding.Default);
            if (lines.Length > 0)
            {
                //The first line contains the title
                string[] LabelTitleEnd;
                string firstline = lines[0];
                string[] labelTitle = firstline.Split(separator);
                List<string> list = new List<string>();
                foreach (string campAct in labelTitle)
                {
                    string value = campAct;
                    tableData.Columns.Add(new DataColumn(value));
                    list.Add(value);
                }
                LabelTitleEnd = list.ToArray();
                //Remaining rows of data
                int startFile = 1;
                for (int i = startFile; i < lines.Length; i++)
                {
                    string[] filesData = lines[i].Split(separator);
                    DataRow dataGridS = tableData.NewRow();
                    int columnIndex = 0;
                    foreach (string campAct in LabelTitleEnd)
                    {
                        string value = filesData[columnIndex++];
                        dataGridS[campAct] = value;
                    }
                    tableData.Rows.Add(dataGridS);
                }
            }
            if (tableData.Rows.Count > 0)
            {
                dbTable.DataSource = tableData;
            }
        }

        private void buttonExportFile_Click(object sender, EventArgs e)
        {
            string Separator = ";";
            if (txtFileCSV.Text == "")
            {
                MessageBox.Show("You must indicate the CSV file to export to" +
                    "information, as well as the separator to use.", "Export to CSV...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFileCSV.Focus();
            }
            else
            {
                if (Directory.Exists(Path.GetDirectoryName(txtFileCSV.Text)))
                {
                    StringBuilder csvMemory = new StringBuilder();

                    //for column titles, header
                    for (int i = 0; i < dbTable.Columns.Count; i++)
                    {
                        if (i == dbTable.Columns.Count - 1)
                        {
                            csvMemory.Append(dbTable.Columns[i].HeaderText);
                        }
                        else
                        {
                            csvMemory.Append(dbTable.Columns[i].HeaderText + Separator);
                        }
                    }
                    csvMemory.AppendLine();

                    for (int m = 0; m < dbTable.Rows.Count; m++)
                    {
                        for (int n = 0; n < dbTable.Columns.Count; n++)
                        {
                            //if it is the last column do not put the separator
                            if (n == dbTable.Columns.Count - 1)
                            {
                                csvMemory.Append(dbTable.Rows[m].Cells[n].Value);
                            }
                            else
                            {
                                csvMemory.Append(dbTable.Rows[m].Cells[n].Value + Separator);
                            }
                        }
                        csvMemory.AppendLine();
                    }
                    try
                    {
                        System.IO.StreamWriter sw =
                            new System.IO.StreamWriter(txtFileCSV.Text, false,
                               System.Text.Encoding.Default);
                        sw.Write(csvMemory.ToString(), Encoding.Default);
                        sw.Close();
                        MessageBox.Show("The contents of the grid have been exported to the CSV file correctly.",
                            "Exported to a CSV file...",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error to export CSV...",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtFileCSV.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The folder specified for the CSV export file does not exist.",
                        "Export to CSV file...",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonCreateFiles_Click(object sender, EventArgs e)
        {
            string array = null;
            DialogResult reply = DialogResult.Cancel;
            bool FileExist = false;
            //Create the csv files that the application needs to run.
            try {
                if (radioButtonCreateBase.Checked) //if select create database
                {   
                    if (File.Exists(BasedataPath)) //if exist the file
                    {
                        reply = MessageBox.Show("Do you want to overwrite the database?", "File already exists",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        FileExist = true;
                    }
                    if(reply == DialogResult.OK || FileExist == false) //if it does not exist, it is created without asking
                    {
                        StreamWriter writer = new StreamWriter(BasedataPath, false);
                        for (int i = 0; i < BaseDP.Length; i++)
                        {
                            array = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}", BaseDP[i].PartNumber, BaseDP[i].SerialNumber, BaseDP[i].StationName,
                                BaseDP[i].ProcessName, BaseDP[i].Pass_Fail, BaseDP[i].TimesTested, BaseDP[i].EntranceTime, BaseDP[i].ExitTime, BaseDP[i].FailString,
                                BaseDP[i].UserName);
                            writer.WriteLine(array);
                        }     
                        writer.Close();
                        MessageBox.Show("Database has been created successfully", "Database create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        radioButtonCreateBase.Checked = false;
                        LoadCSVData(BasedataPath, ';');
                        txtFileCSV.Text = SerialPath;
                    }
                    else
                    {
                        radioButtonCreateBase.Checked = false;
                    }
                }
                else if (radioButtonCreateProcess.Checked) //if select create database process-station order
                {
                    if (File.Exists(ProcessPath)) //if exist the file
                    {
                        reply = MessageBox.Show("Do you want to overwrite the database?", "File already exists",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        FileExist = true;
                    }
                    if (reply == DialogResult.OK || FileExist == false) //if it does not exist, it is created without asking
                    {
                        StreamWriter writer = new StreamWriter(ProcessPath, false);
                        for (int i = 0; i < Process.Length; i++) 
                        {
                            array = string.Format("{0};{1};{2}", Process[i].NumberProcess, Process[i].Station, Process[i].Process);
                            writer.WriteLine(array);
                        }
                        writer.Close();
                        MessageBox.Show("Processdata has been created successfully", "Processdata create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        radioButtonCreateProcess.Checked = false;
                        LoadCSVData(ProcessPath, ';');
                        txtFileCSV.Text = ProcessPath;
                    }
                    else
                    {
                        radioButtonCreateProcess.Checked = false;
                    }
                }
                else if (radioButtonCreateSerial.Checked)
                {
                    if (File.Exists(SerialPath)) //if exist the file
                    {
                        reply = MessageBox.Show("Do you want to overwrite the database?", "File already exists",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        FileExist = true;
                    }
                    if (reply == DialogResult.OK || FileExist == false) //if it does not exist, it is created without asking
                    {
                        StreamWriter writer = new StreamWriter(SerialPath, false);
                        for (int i = 0; i < SerialDP.Length; i++)
                        {
                            array = string.Format("{0};{1}", SerialDP[i].SerialReg, SerialDP[i].PartNumber);
                            writer.WriteLine(array);
                        }
                        writer.Close();
                        MessageBox.Show("Serial register has been created successfully", "Basedata serial create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        radioButtonCreateSerial.Checked = false;
                        LoadCSVData(SerialPath, ';');
                        txtFileCSV.Text = SerialPath;
                    }
                    else
                    {
                        radioButtonCreateSerial.Checked = false;
                    }
                }
                else
                    MessageBox.Show("Select a file to create", "Waiting for information...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error to create CSV...",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void buttonSearchDLL_Click_1(object sender, EventArgs e)
        {
            string filepath = AppDomain.CurrentDomain.BaseDirectory + @"packages";
            System.Diagnostics.Process.Start("explorer.exe", filepath);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void functionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Path where the help pdf is located
            string PDFDLL = AppDomain.CurrentDomain.BaseDirectory + "Kimball Traceability Functions.pdf";
            try
            {
                System.Diagnostics.Process.Start(PDFDLL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error to open PDF...",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void appToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Path where the help pdf is located
            string PDF = AppDomain.CurrentDomain.BaseDirectory + "Manual Traceability Simu.pdf";
            try
            {
                System.Diagnostics.Process.Start(PDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error to open PDF...",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class BaseDP //Class to make the predefined base file 
    {
        public string PartNumber { get; set; }
        public string SerialNumber { get; set; }
        public string StationName { get; set; }
        public string ProcessName { get; set; }
        public string Pass_Fail { get; set; }
        public string TimesTested { get; set; }
        public string EntranceTime { get; set; }
        public string ExitTime { get; set; }
        public string FailString { get; set; }
        public string UserName { get; set; }
    }

    public class ProcessDP //Class to make the predefined process-station file
    {
        public string NumberProcess { get; set; }
        public string Station { get; set; }
        public string Process { get; set; }
    }

    public class SerialDP //Class to make the predefined serial base file
    {
        public string SerialReg { get; set; }
        public string PartNumber { get; set; }
    }
}
