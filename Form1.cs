using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchBttn_Click(object sender, EventArgs e)
        {
            matchedListBox.Items.Clear();    

            string text = textRichTxtBox.Text;
            string pattern = patternTxtBox.Text;

            try
            {
                foreach (Match hit in Regex.Matches(text, pattern))
                {
                    matchedListBox.Items.Add(hit.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
