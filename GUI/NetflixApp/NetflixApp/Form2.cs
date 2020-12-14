using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixApp
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            typeComboBox.Items.Add("TV Show");
            typeComboBox.Items.Add("Movie");

            this.form1 = form1;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(idTextBox.Text == "" || typeComboBox.Text == "" || titleTextBox.Text == "" || yearTextBox.Text == "")
            {
                MessageBox.Show("Reenter the data");
            }
            else
            {
                 
                Id = ulong.Parse(idTextBox.Text);
                Type = typeComboBox.Text;
                Title = titleTextBox.Text;
                Year = int.Parse(yearTextBox.Text);

                this.Close();
            }

        }

        public ulong Id
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public int Year
        {
            get;
            set;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
