using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contacts
{
    public partial class ObjectvillePaperCompanyContactForm : Form
    {
        public ObjectvillePaperCompanyContactForm()
        {
            InitializeComponent();
        }

        private void OPCLogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OPC logo");
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactsDBDataSet);

        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactsDBDataSet.people' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contactsDBDataSet.people);

        }
    }
}
