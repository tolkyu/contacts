using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testing.EntityFramework;

namespace testing
{
    public partial class frmAddContact : Form
    {
        private phonebookEntities4 database;

        public frmAddContact()
        {
            database = new EntityFramework.phonebookEntities4();
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            database.contacts.Add(
                new contact()
                {
                    ContactID = database.contacts.Count(),
                    name = txtName.Text.Trim(),
                    email = txtEmail.Text.Trim(),
                    phone = txtPhone.Text.Trim(),
                    address = txtAddress.Text.Trim(),
                    isFriend = isFriend.Checked,
                    isFamily = isFamily.Checked,
                    isCoWorker = isCoWorker.Checked,
                    isBusiness = isBusiness.Checked
                }
                );

            if (database.SaveChanges()>0)
            {
                
                MessageBox.Show(txtName.Text.Trim()+" Successfully Added");
            }
            else
            {
                MessageBox.Show(txtName.Text.Trim() + " Failed, check database connection");
            }
            
        }
    }
}
