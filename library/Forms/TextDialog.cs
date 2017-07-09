using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace library.Forms
{
    public partial class TextDialog : Form
    {
        public TextDialog()
        {
            InitializeComponent();
        }

        public string EditedText
        {
            get { return EditingTextBox.Text; }
            set { EditingTextBox.Text = value; }
        }

        public string FormText
        {
            get { return Text; }
            set { Text = value; }
        }

        public bool OkResult { get; private set; }

        private void OkButton_Click(object sender, EventArgs e)
        {
            OkResult = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            OkResult = false;
            this.Close();
        }
    }
}
