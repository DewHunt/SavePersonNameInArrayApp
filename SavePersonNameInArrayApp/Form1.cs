using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavePersonNameInArrayApp
{
    public partial class SavePersonNameInArrayUI : Form
    {
        int count = 0, previousIndex;
        bool loop = true;
        string[] nameArray = new string[5];
        public SavePersonNameInArrayUI()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (count < nameArray.Length)
            {
                string name = nameTextBox.Text;
                nameArray[count] = name;
                previousIndex = count++;
                loop = true;
                nameTextBox.Clear();
            }
            else
            {
                MessageBox.Show("U Can store only 5 names...");
                nameTextBox.Clear();
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (loop == true)
            {
                showAllListBox.Items.Add(nameArray[previousIndex]);
                totalTextBox.Text = count.ToString();
            }
            loop = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
