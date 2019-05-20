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
    public partial class Form1 : Form
    {
        private phonebookEntities4 database;

        public Form1()
        {
            InitializeComponent();
            database = new EntityFramework.phonebookEntities4();
        }
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new PopupEffect.transparentBg(this,new frmAddContact());
        }
        void PopulateDataToDataGrid()
        {
            //zagruzka database
            var results = database.contacts.Select(r=>r);

            //filter poiska
            if (txtSearch.Text.Trim().Length>0)
            {
                results = results.Where(r => r.name.Contains(txtSearch.Text.Trim().ToLower()) || r.phone.Contains(txtSearch.Text.Trim().ToLower()));
            }

            grid.Rows.Clear();

            foreach(var contact in results)
            {
                grid.Rows.Add(
                    new object[]
                    {
                        contact.name,
                        contact.email,
                        contact.phone,
                        contact.address
                    }
                    );
                grid.Rows[grid.RowCount - 1].Tag = contact;
            }
        }
        private void BtnAllContacts_Click(object sender, EventArgs e)
        {
            lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            PopulateDataToDataGrid();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            PopulateDataToDataGrid();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                var contact = (contact)row.Tag;
                database.contacts.Remove(contact);
                grid.Rows.Remove(row);
            }
            if (database.ChangeTracker.HasChanges())
            {
                if (database.SaveChanges()>0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }
    }
}
