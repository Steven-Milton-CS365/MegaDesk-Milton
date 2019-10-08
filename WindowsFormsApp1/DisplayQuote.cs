using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            String[] materials = new string[] {"Laminate", "Oak", "Pine", "Rosewood", "Veneer"};
            String[] rushDays = new String[] {"0", "3", "5", "7"};
            String quoteLine = GetLastQuoteInfo();
            int pipe1 = quoteLine.IndexOf('|', 0);
            int pipe2 = quoteLine.IndexOf('|', pipe1 + 1);
            int pipe3 = quoteLine.IndexOf('|', pipe2 + 1);
            int pipe4 = quoteLine.IndexOf('|', pipe3 + 1);
            int pipe5 = quoteLine.IndexOf('|', pipe4 + 1);
            int pipe6 = quoteLine.IndexOf('|', pipe5 + 1);
            int pipe7 = quoteLine.IndexOf('|', pipe6 + 1);
            int pipe8 = quoteLine.IndexOf('|', pipe7 + 1);

            lblDispQuoteNo.Text = quoteLine.Substring(0, pipe1);
            lblDispName.Text = quoteLine.Substring(pipe1 + 1, pipe2 - pipe1 - 1);
            lblDispWidth.Text = quoteLine.Substring(pipe2 + 1, pipe3 - pipe2 - 1);
            lblDispDepth.Text = quoteLine.Substring(pipe3 + 1, pipe4 - pipe3 - 1);
            lblDispDrawers.Text = quoteLine.Substring(pipe4 + 1, pipe5 - pipe4 - 1);
            int arrayPosition = 0;
            bool success = int.TryParse(quoteLine.Substring(pipe5 + 1, pipe6 - pipe5 - 1), out arrayPosition);
            lblDispMaterial.Text = materials[arrayPosition];
            arrayPosition = 0;
            success = int.TryParse(quoteLine.Substring(pipe6 + 1, pipe7 - pipe6 - 1), out arrayPosition);
            lblDispRush.Text = rushDays[arrayPosition];
            lblDispTotalCost.Text = quoteLine.Substring(pipe7 + 1, pipe8 - pipe7 - 1);
            lblDispCreateDate.Text = quoteLine.Substring(pipe8 + 1, quoteLine.Length - pipe8 - 1);
        }

        private String GetLastQuoteInfo()
        {
            StreamReader quoteFile = new StreamReader("quotes.txt");
            int quoteNo = 1;
            string line = null;
            while (quoteFile.EndOfStream == false)
            {
                line = quoteFile.ReadLine();
            }
            quoteFile.Close();
            return line;
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
