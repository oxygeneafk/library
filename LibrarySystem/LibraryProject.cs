using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class LibraryProject : Form
    {
        public LibraryProject()
        {
            InitializeComponent();
        }

        InformationDal _informationDal = new InformationDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            LoadMembers();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }

            if (e.KeyCode == Keys.Delete)
            {
                btnRemove.PerformClick();
            }
        }

        private void LoadMembers()
        {
            dgwInformation.DataSource = _informationDal.GetAll();
        }

        private void Clear()
        {
            tbxName.Clear();
            tbxLastName.Clear();
            tbxPhoneNumber.Clear();
            tbxReceivedBook.Clear();
        }
        private void ClearUpdate()
        {
            tbxNameUpdate.Clear();
            tbxLastNameUpdate.Clear();
            tbxPhoneNumberUpdate.Clear();
            tbxReceivedBookUpdate.Clear();
        }
        private void SearchInformation(string key)
        {
            var result = _informationDal.GetByName(key);
            dgwInformation.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _informationDal.Add(new Information
            {
                Name = tbxName.Text,
                LastName = tbxLastName.Text,
                PhoneNumber = tbxPhoneNumber.Text,
                ReceivedBook = tbxReceivedBook.Text,
                DeliveryDate = Convert.ToDateTime(dateTimeDeliveryDate.Text),
                DateOfReceipt = Convert.ToDateTime(dateTimeDateOfReceipt.Text)
            });
            try
            {
                if (string.IsNullOrEmpty(tbxName.Text) || string.IsNullOrEmpty(tbxLastName.Text) || string.IsNullOrEmpty(tbxPhoneNumber.Text) || string.IsNullOrEmpty(tbxReceivedBook.Text))
                {
                    throw new Exception("Please fill in all blank fields!!");
                }
                else
                {
                    LoadMembers();
                    Clear();
                    MessageBox.Show("Member Added!!", "develepor by oxyyylesnar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _informationDal.Update(new Information
            {
                Id = Convert.ToInt32(dgwInformation.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                LastName = tbxLastNameUpdate.Text,
                PhoneNumber = tbxPhoneNumberUpdate.Text,
                ReceivedBook = tbxReceivedBookUpdate.Text,
                DeliveryDate = Convert.ToDateTime(dateTimeDeliveryDateUpdate.Text),
                DateOfReceipt = Convert.ToDateTime(dateTimeDateOfReceiptUpdate.Text),
            });
            LoadMembers();
            ClearUpdate();
            MessageBox.Show("Member Updated!!", "develepor by oxyyylesnar.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwInformation.SelectedRows.Count == 0)
                {
                    throw new Exception("Please select a member");
                }
                else
                {
                    _informationDal.Delete(new Information
                    {
                        Id = Convert.ToInt32(dgwInformation.CurrentRow.Cells[0].Value),

                    });
                    LoadMembers();
                    ClearUpdate();
                    MessageBox.Show("Member Removed!!", "develepor by oxyyylesnar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgwInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwInformation.CurrentRow.Cells[1].Value.ToString();
            tbxLastNameUpdate.Text = dgwInformation.CurrentRow.Cells[2].Value.ToString();
            tbxPhoneNumberUpdate.Text = dgwInformation.CurrentRow.Cells[3].Value.ToString();
            tbxReceivedBookUpdate.Text = dgwInformation.CurrentRow.Cells[4].Value.ToString();
            dateTimeDeliveryDateUpdate.Text = dgwInformation.CurrentRow.Cells[5].Value.ToString();
            dateTimeDateOfReceiptUpdate.Text = dgwInformation.CurrentRow.Cells[6].Value.ToString();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchInformation(tbxSearch.Text);
        }

        private static void NumberControl(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private static void MessageControl(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberControl(e);
        }

        private void tbxPhoneNumberUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberControl(e);
        }

        private void tbxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageControl(e);
        }

        private void tbxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageControl(e);
        }

        private void tbxNameUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageControl(e);
        }

        private void tbxLastNameUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageControl(e);
        }
    }
}
