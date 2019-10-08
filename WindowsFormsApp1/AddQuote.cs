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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            desk newDesk = new desk();
            newDesk.setWidth(Int32.Parse(txtWidth.Text));
            newDesk.setDepth(Int32.Parse(txtDepth.Text));
            newDesk.setDrawers((int)numDrawers.Value);
            newDesk.setMaterial((int)lstMaterial.SelectedIndex);

            DeskQuote newQuote = new DeskQuote(newDesk, txtName.Text, lstRush.SelectedIndex);
            WriteToDeskFile(newQuote);
            var displayQuoteForm = new DisplayQuote();
            displayQuoteForm.Show();
            this.Close();
        }

        private void txtWidth_Validating(object sender, CancelEventArgs e)
        {
            double cmpWidth;
            if (double.TryParse(txtWidth.Text, out cmpWidth))
            {
                if ((cmpWidth >= 24.0) && (cmpWidth <= 96.0))
                    e.Cancel = false;
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Enter number between 24 and 96");
                }
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Enter number between 24 and 96");
            };
        }

        private void txtDepth_Validating(object sender, CancelEventArgs e)
        {
            double cmpDepth;
            if (double.TryParse(txtWidth.Text, out cmpDepth))
            {
                if ((cmpDepth >= 24.0) && (cmpDepth <= 96.0))
                    e.Cancel = false;
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Enter number between 12 and 48");
                }
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Enter number between 12 and 48");
            };
        }

        private int getNextQuoteNo()
        {
            StreamReader quoteFile = new StreamReader("quotes.txt");
            int quoteNo = 1;
            while (quoteFile.EndOfStream == false)
            {
                string line = quoteFile.ReadLine();
                quoteNo = Int32.Parse(line.Substring(1, 10));
            }
            quoteFile.Close();
            return quoteNo;
        }

        private void WriteToDeskFile(DeskQuote dq)
        {
            String dqQuoteNo = dq.getQuoteNo().ToString();
            String dqName = dq.getName();
            String dqWidth = dq.inDesk.getWidth().ToString();
            String dqDepth = dq.inDesk.getDepth().ToString();
            String dqDrawers = dq.inDesk.getDrawers().ToString();
            String dqMaterial = dq.inDesk.getMaterial().ToString();
            String dqRush = dq.getRush().ToString();
            String dqTotalCost = dq.TotalCost(dq.inDesk, dq.getRush()).ToString();
            String dqDate = dq.getDate().ToString();
            String dqWriteLine = dqQuoteNo + '|' + dqName + '|' + dqWidth + '|' + dqDepth + '|' + dqDrawers + '|' +
                                 dqMaterial + '|' + dqRush + '|' + dqTotalCost + '|' + dqDate;
            StreamWriter deskFile = new StreamWriter(@"quotes.txt",true);
            deskFile.WriteLine(dqWriteLine);
            deskFile.Close();
        }
    }
}
