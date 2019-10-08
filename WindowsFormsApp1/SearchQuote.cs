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
    public partial class SearchQuote : Form
    {
        public SearchQuote()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getResults(lstSearchMaterial.SelectedIndex);
        }

        private void getResults(int material)
        {
            StreamReader quoteFile = new StreamReader("quotes.txt");
            String searchResults = null;
            String[] materials = new string[] { "Laminate", "Oak", "Pine", "Rosewood", "Veneer" };
            String[] rushDays = new String[] { "0", "3", "5", "7" };
            String quoteLine = null;
            String dispQuoteNo = null;
            String dispName = null;
            String dispDepth = null;
            String dispDrawers = null;
            String dispMaterial = null;
            String dispRush = null;
            String dispWidth = null;
            String dispTotalCost = null;
            String dispCreateDate = null;
            bool success = true;
            int materialPosition = 0;
            int rushPosition = 0;
            while (quoteFile.EndOfStream == false)
            {
                quoteLine = quoteFile.ReadLine();
                int pipe1 = quoteLine.IndexOf('|', 0);
                int pipe2 = quoteLine.IndexOf('|', pipe1 + 1);
                int pipe3 = quoteLine.IndexOf('|', pipe2 + 1);
                int pipe4 = quoteLine.IndexOf('|', pipe3 + 1);
                int pipe5 = quoteLine.IndexOf('|', pipe4 + 1);
                int pipe6 = quoteLine.IndexOf('|', pipe5 + 1);
                int pipe7 = quoteLine.IndexOf('|', pipe6 + 1);
                int pipe8 = quoteLine.IndexOf('|', pipe7 + 1);

                dispQuoteNo = quoteLine.Substring(0, pipe1);
                dispName = quoteLine.Substring(pipe1 + 1, pipe2 - pipe1 - 1);
                dispWidth = quoteLine.Substring(pipe2 + 1, pipe3 - pipe2 - 1);
                dispDepth = quoteLine.Substring(pipe3 + 1, pipe4 - pipe3 - 1);
                dispDrawers = quoteLine.Substring(pipe4 + 1, pipe5 - pipe4 - 1);
                materialPosition = 0;
                success = int.TryParse(quoteLine.Substring(pipe5 + 1, pipe6 - pipe5 - 1), out materialPosition);
                dispMaterial = materials[materialPosition];
                rushPosition = 0;
                success = int.TryParse(quoteLine.Substring(pipe6 + 1, pipe7 - pipe6 - 1), out rushPosition);
                dispRush = rushDays[rushPosition];
                dispTotalCost = quoteLine.Substring(pipe7 + 1, pipe8 - pipe7 - 1);
                dispCreateDate = quoteLine.Substring(pipe8 + 1, quoteLine.Length - pipe8 - 1);
                if (materialPosition == material)
                    searchResults = searchResults + Environment.NewLine + dispQuoteNo + "\t" + dispName + "\t" +
                        dispWidth + "\t" + dispDepth + "\t" + dispDrawers + "\t" + dispMaterial + "\t" +
                        dispRush + "\t" + dispTotalCost + "\t" + dispCreateDate;
            }
            quoteFile.Close();
            txtBoxResults.Text = searchResults;
        }

        private void btnSearchClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
