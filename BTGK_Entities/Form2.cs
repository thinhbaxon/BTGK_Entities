using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTGK_Entities
{

    public partial class Form2 : Form
    {

        private string _MSSV;
        public string MSSV { get => _MSSV; set => _MSSV = value; }
        public Mydel D { get; set; }

        public delegate void Mydel();
        public Form2(string m)
        {
            MSSV = m;
            InitializeComponent();
            SetCBB();
            SetView();

        }
        public List<SinhVien> GetRecords(string query)
        {
            DemoQLSVEntities db = new DemoQLSVEntities();

            return db.SinhVien.Where(p => p.MSSV == query).Select(p => p).ToList();
        }
        public void SetView()
        {
            this.cbbNameLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Text = "ADD";
            if (this.MSSV != "")
            {
                this.Text = "EDITs";
                txtMSSV.Text = MSSV;
                txtMSSV.Enabled = false;
                DemoQLSVEntities db = new DemoQLSVEntities();
                string NameLop = "";
                foreach(SinhVien i in db.SinhVien)
                {
                    if(i.MSSV == MSSV)
                    {
                        txtMSSV.Text = i.MSSV.ToString();
                        txtNameSV.Text = i.NameSV.ToString();
                        txtAge.Text = i.Age.ToString();
                        NameLop = i.LopSV.NameLop.ToString();
                    }
                }
                int j = 0;
                bool check = true;
                while (check)
                {
                    cbbNameLop.SelectedIndex = j;
                    if (NameLop == cbbNameLop.SelectedItem.ToString())
                    {
                        check = false;
                        break;
                    }
                    j++;
                }
            }
        }

        public void SetCBB()
        {
            DataTable dt = new DataTable();
            var db = new DemoQLSVEntities();
            if (cbbNameLop.Items != null)
            {
                cbbNameLop.Items.Clear();
            }
           
            foreach (SinhVien i in db.SinhVien)
            {
                cbbNameLop.Items.Add(new CBBItems
                {
                    Values = Convert.ToInt32(i.ID_Lop.Value.ToString()),
                    Text = i.LopSV.NameLop.ToString()
                });
            }
        }
        public void AU()
        {
           
            DemoQLSVEntities db = new DemoQLSVEntities();
            if (MSSV == "")
            {
                if (Check_Infor(txtMSSV.Text, txtNameSV.Text, txtAge.Text, cbbNameLop.SelectedItem))
                {
                    int ID_LopC = (cbbNameLop.SelectedItem as CBBItems).Values;
                    SinhVien sv = new SinhVien
                    {
                        MSSV = txtMSSV.Text,
                        NameSV = txtNameSV.Text,
                        Age = Convert.ToInt32(txtAge.Text),
                        ID_Lop = ID_LopC
                    };
                    
                    try
                    {
                        db.SinhVien.Add(sv);
                        this.MSSV = txtMSSV.Text;
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công!");
                        this.Close();
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Nhập sai định dạng!");
                    }
                }

            }
            else
            {
                try
                {
                    var l = db.SinhVien.Where(p => p.MSSV == this.MSSV).FirstOrDefault();
                    l.MSSV = MSSV;
                    l.NameSV = txtNameSV.Text;
                    l.Age = Convert.ToInt32(txtAge.Text);
                    l.ID_Lop = (cbbNameLop.SelectedItem as CBBItems).Values;
                    db.SaveChanges();
                    MessageBox.Show("Chỉnh sửa thành công!");
                    this.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Nhập sai định dạng!");
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            AU();
            if (D != null)
            {
                D();
            };
        }

        public bool Check_Infor(string MSSV, string HoTen, string AGE, object LopHP)
        {
            DemoQLSVEntities db = new DemoQLSVEntities();
            var l = db.SinhVien.Where(p => p.MSSV == MSSV).Select(p => new { p.MSSV, p.NameSV, p.Age, p.LopSV.NameLop });
            if (MSSV == "" || HoTen == "" || AGE == "" || LopHP == null)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return false;
            }
            else if (l.ToList().Count == 1)
            {
                MessageBox.Show(" Sinh viên này đã tồn tại vui lòng nhập lại");
                return false;
            }
            else return true;
        }

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
