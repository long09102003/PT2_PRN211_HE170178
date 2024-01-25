using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.MemberObject;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMenberRepository menberRepository = new MemberRepository();
        //create a data source
        BindingSource source;

        IEnumerable<MemberObject> memberList;

        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassWord.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private MemberObject GetMemberObject()
        {
            MemberObject memberObject = null;
            try
            {
                memberObject = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    PassWord = txtPassWord.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return memberObject;
        }

        public void LoadMemberList()
        {
            var members = memberList.ToList();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassWord.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassWord.DataBindings.Add("Text", source, "PassWord");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            //Register this event to open the frmMemberDetail from that performs updating
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;

        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemInfo = GetMemberObject(),
                MenRepository = menberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //Set focus car update
                //source.Position = source.Count - 1;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //LoadFilterOptions();
            memberList = menberRepository.GetMembers();
            LoadMemberList();
        }//end btnLoad_click

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                MenRepository = menberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //set focus car inserted
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var mem = GetMemberObject();
                menberRepository.DeleteMember(mem.MemberID);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete member");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtKey.Text.Trim().ToLower();
                memberList = menberRepository.Search(keyword);
                LoadMemberList();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Member");
            }

        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int index = cbSort.SelectedIndex;
            if (index == 0)
            {
                menberRepository.SortMemberByID();

            }
            else
            {
                menberRepository.SortMemberByName();
            }


            LoadMemberList();

        }

        //private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbxCountry.Text = "none ";
        //    if (memberList != null)
        //    {
        //        string key = cbxCity.Text;
        //        if (key.Equals("none"))
        //        {
        //            sortFuctionText();
        //        }
        //        else
        //        {
        //            var sortMembers = memberRepository1.getListMember().Where(x => x.City.Equals(key)).ToList();
        //            memberList = sortMembers;
        //            LoadMemberList();
        //        }
        //    }
        //}

        //private void LoadCityList()
        //{
        //    cityList = memberRepository1.getListMember().Select(x => x.City).Distinct().ToList();
        //    cityList.Insert(0, "none");
        //    cbxCity.DataSource = null;
        //    cbxCity.DataSource = cityList;
        //}

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedCity = cboCity.SelectedItem?.ToString();
            //FilterMembersByCity(selectedCity);
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedcountry = cbocountry.selecteditem?.tostring();
            //filtermembersbycountry(selectedcountry);
        }

       
    }
}
