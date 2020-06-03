using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTGK_Entities
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            SetCBBLop();
            SetCBBsort();
            //Show();
            //combobox1.SelectedIndex = 0;
        }

        public void Show()
        {
            DemoQLSVEntities db = new DemoQLSVEntities();
            var l = db.SinhVien.Select(p => new { p.MSSV, p.NameSV, p.Age, p.LopSV.NameLop });
            dataGridView1.DataSource = l.ToList();
            //string query = "select * from SinhVien";
            //dataGridView1.DataSource = QLSV_DB.DataProvider.Instance.GetRecords(query);
        }
        public void SetCBBLop()
        {
            DataTable dt = new DataTable();
            var db = new DemoQLSVEntities();
            if (cbbLop.Items != null)
            {
                cbbLop.Items.Clear();
            }
            cbbLop.Items.Add(new CBBItems { Values = 0, Text = "All" });
            foreach (SinhVien i in db.SinhVien)
            {
                cbbLop.Items.Add(new CBBItems
                {
                    Values = Convert.ToInt32(i.ID_Lop.Value.ToString()),
                    Text = i.LopSV.NameLop.ToString()
                });
            }
        }
        public void SetCBBsort()
        {

            cbbSoft.Items.AddRange(new object[] {
            "MSSV",
            "Age",
            "NameSV",
            "NameLop" });
            
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            
            var db = new DemoQLSVEntities();
            List<SinhVien> t = new List<SinhVien>();
            
            foreach (SinhVien i in db.SinhVien)
            {
                if (i.NameSV.ToString().Contains(txtSearch.Text))
                {
                    t.Add(i);
                }
            }
            
            dataGridView1.DataSource = t;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            DemoQLSVEntities db = new DemoQLSVEntities();
            foreach (SinhVien i in db.SinhVien)
            {
                foreach (DataGridViewRow j in r)
                {
                    if (i.MSSV == j.Cells["MSSV"].Value.ToString())
                    {
                        db.SinhVien.Remove(i);
                    }
                }
            }
            db.SaveChanges();
            Show();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("");
            f.D += new Form2.Mydel(Show);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {
                string MSSV = r[0].Cells["MSSV"].Value.ToString();
                Form2 f = new Form2(MSSV);
                f.D += new Form2.Mydel(Show);
                f.ShowDialog();
            }
        }

        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = cbbLop.SelectedItem.ToString();
            DemoQLSVEntities db = new DemoQLSVEntities(); if (n == "All")
            {
                Show();
            }
            else
            {
                var l = db.SinhVien.Where(p => p.LopSV.NameLop == n.ToString()).Select(p => new { p.MSSV, p.NameSV, p.Age, p.LopSV.NameLop });
                dataGridView1.DataSource = l.ToList();
            }
        }
        
        private void btnSoft_Click(object sender, EventArgs e)
        {
            object r = cbbSoft.SelectedItem;
            if (r != null)
            {
                DemoQLSVEntities db = new DemoQLSVEntities();
                if (cbbSoft.SelectedItem.ToString() == "MSSV")
                {
                    var l = db.SinhVien.OrderBy(p => p.MSSV).Select(p => new { p.MSSV, p.NameSV, p.Age, p.LopSV.NameLop });
                    dataGridView1.DataSource = l.ToList();
                }
                if (cbbSoft.SelectedItem.ToString() == "NameSV")
                {
                    var l = db.SinhVien.OrderBy(p => p.NameSV).Select(p => new { p.MSSV, p.NameSV, p.Age, p.LopSV.NameLop });
                    dataGridView1.DataSource = l.ToList();
                }
                if (cbbSoft.SelectedItem.ToString() == "Age")
                {
                    var l = db.SinhVien.OrderBy(p => p.Age).Select(p => new { p.MSSV, p.NameSV, p.Age, p.LopSV.NameLop });
                    dataGridView1.DataSource = l.ToList();
                }
                if (cbbSoft.SelectedItem.ToString() == "NameLop")
                {
                    var l = db.SinhVien.OrderBy(p => p.LopSV.NameLop).Select(p => new { p.MSSV, p.NameSV, p.Age, p.LopSV.NameLop });
                    dataGridView1.DataSource = l.ToList();
                }
            }
            else return;
            
        }
    }
}
