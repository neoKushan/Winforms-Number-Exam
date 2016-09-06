using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numberwang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.OutputLabel.Text = $"{this.ConvertToWords(this.InputTextBox.Text)}: That's Numberwang!";
            }
            catch (Exception ex)
            {
                this.OutputLabel.Text = $"{ex.Message}{Environment.NewLine}That's not numberwang :(";
            }
        }

        /// <summary>
        /// You must impliment this method
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string ConvertToWords(string input)
        {
            throw new NotImplementedException();
        }
    }
}
