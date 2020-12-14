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
using System.Globalization;

namespace NetflixApp
{
    public partial class Form1 : Form
    {
        // List data structure to keep track of the information from the csv file:
        private List<TableData> tableDataList = new List<TableData>();

        Form2 f2;

        public Form1()
        {
            InitializeComponent();
            // Start aplication with delete and add button disable
            deleteButton.Enabled = false;
            addButton.Enabled = false;

        }
        private void UpdateListBox()
        {
            // clear list box, because I don't want to repeat data:
            dataListBox.Items.Clear();

            string headline = string.Format("{0,-10}\t| {1,-10}\t| {2,-50}\t| {3,-10}\t| {4,-10}", "Id", "Type", "Title", "date_added", "release_year");
            dataListBox.Items.Add(headline);
            int numOfTabs = 4;

            string border = new String('-', headline.Length + 4 * (numOfTabs));
            dataListBox.Items.Add(border);

            foreach (TableData tb in tableDataList)
            {
                dataListBox.Items.Add(tb);
            }
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader("netflix_titles.csv"))
                {
                    string streamLine = "";
                    int i = 0;
                    while ((streamLine = streamReader.ReadLine()) != null)
                    {
                        if (i != 0)
                        {
                            // tokenize the data from the ',':
                            string[] token = streamLine.Split(',');
                            TableData tableData = new TableData(ulong.Parse(token[0]), token[1], token[2], DateTime.Parse(token[3]), int.Parse(token[4]));
                            tableDataList.Add(tableData);
                        }
                        else
                        {
                            i++;
                        }

                    }
                }
                addButton.Enabled = true;
                UpdateListBox();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void idCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(idCheckBox.Checked == true)
            {
                typeCheckBox.Checked = false;
                titleCheckBox.Checked = false;
                dateCheckBox.Checked = false;
                yearCheckBox.Checked = false;
            }

            System.Threading.Thread.Sleep(200);
            tableDataList.Sort((item1, item2) => item1.Id.CompareTo(item2.Id));
            UpdateListBox();
        }

        private void typeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            idCheckBox.Checked = false;
            titleCheckBox.Checked = false;
            dateCheckBox.Checked = false;
            yearCheckBox.Checked = false;

            System.Threading.Thread.Sleep(200);
            tableDataList.Sort((item1, item2) => item1.Type.CompareTo(item2.Type));
            UpdateListBox();
        }

        private void titleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            idCheckBox.Checked = false;
            typeCheckBox.Checked = false;
            dateCheckBox.Checked = false;
            yearCheckBox.Checked = false;

            System.Threading.Thread.Sleep(200);
            tableDataList.Sort((item1, item2) => item1.Title.CompareTo(item2.Title));
            UpdateListBox();
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            idCheckBox.Checked = false;
            typeCheckBox.Checked = false;
            titleCheckBox.Checked = false;
            yearCheckBox.Checked = false;

            System.Threading.Thread.Sleep(200);
            tableDataList.Sort((item1, item2) => item1.Date.CompareTo(item2.Date));
            UpdateListBox();
        }

        private void yearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            idCheckBox.Checked = false;
            typeCheckBox.Checked = false;
            titleCheckBox.Checked = false;
            dateCheckBox.Checked = false;

            System.Threading.Thread.Sleep(200);

            tableDataList.Sort((item1, item2) => item1.Year.CompareTo(item2.Year));
            UpdateListBox();
        }

        private void dataListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = dataListBox.SelectedIndex - 2; // headline + border
            //statusLabel.Text = index.ToString();
            deleteButton.Enabled = true;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Operation", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                statusLabel.Text = "Deleting row...";
                int index = dataListBox.SelectedIndex - 2; // headline + border
                tableDataList.RemoveAt(index);
                UpdateListBox();
                deleteButton.Enabled = false;
                statusLabel.Text = "Status";
            }
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i += 10)
            {
                System.Threading.Thread.Sleep(10);
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            f2 = new Form2(this);
            f2.ShowDialog();         

            TableData tb = new TableData(f2.Id, f2.Type, f2.Title, DateTime.Now, f2.Year);
            tableDataList.Add(tb);

            UpdateListBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter("netflix_titles_mod.csv"))
                {
                    string headline = string.Format("{0,-10}\t| {1,-10}\t| {2,-50}\t| {3,-10}\t| {4,-10}", "Id", "Type", "Title", "date_added", "release_year");
                    streamWriter.WriteLine(headline);
                    int numOfTabs = 4;

                    string border = new String('-', headline.Length + 4 * (numOfTabs));
                    streamWriter.WriteLine(border);

                    foreach (TableData tb in tableDataList)
                    {
                        streamWriter.WriteLine(tb);
                    }
                    
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
