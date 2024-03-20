using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace baitap
{
    public partial class bai7 : Form
    {
        public bai7()
        {
            InitializeComponent();
            dsphim.Add("Đào, phở và piano", 45000);
            dsphim.Add("Mai", 100000);
            dsphim.Add("Gặp lại chị bầu", 75000);
            dsphim.Add("Tarot", 90000);
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        Dictionary<string, int> dsphim= new Dictionary<string, int>();
       
        string[] dsdadat;
        string[] sogheedachon;
        string[] soghedachon2=new string [0];
        CheckedListBox.CheckedItemCollection items;
        List<string> trung = new List<string>();

        private void btxuatve_Click(object sender, EventArgs e)
        {
            
            string phimdachon=comboBox1.Text;
            
            items = checkedListBox1.CheckedItems;
            
            
            sogheedachon = LayPhanTuDaChon();
            
            if (KiemTraTrung() == true)
            {
                string danhSachTrung = string.Join(", ", trung);
                MessageBox.Show("Những ghế sau đã được đặt: " + danhSachTrung);
            }
            else
            {
                int giatienthucte = 0;
                foreach (string tmp in sogheedachon)
                {
                    int giave = 0;
                    switch (phimdachon)
                    {
                        case "Đào, phở và piano":
                            if (tmp == "A1" || tmp == "A5" || tmp == "C1" || tmp == "C5")
                            {
                                giatienthucte += dsphim["Đào, phở và piano"] / 4;
                            }
                            else if (tmp == "B2" || tmp == "B3" || tmp == "B4")
                            {
                                giatienthucte += dsphim["Đào, phở và piano"] * 2;
                            }
                            else if (tmp == "A2" || tmp == "A3" || tmp == "A4" || tmp == "C2" || tmp == "C3" || tmp == "C4" || tmp == "B1" || tmp == "B5")
                            {
                                giatienthucte += dsphim["Đào, phở và piano"];
                            }
                            break;
                        case "Mai":
                            if (tmp == "A1" || tmp == "A5" || tmp == "C1" || tmp == "C5")
                            {
                                giatienthucte += dsphim["Mai"] / 4;
                            }
                            else if (tmp == "B2" || tmp == "B3" || tmp == "B4")
                            {
                                giatienthucte += dsphim["Mai"] * 2;
                            }
                            else if (tmp == "A2" || tmp == "A3" || tmp == "A4" || tmp == "C2" || tmp == "C3" || tmp == "C4" || tmp == "B1" || tmp == "B5")
                            {
                                giatienthucte += dsphim["Mai"];
                            }
                            break;
                        case "Gặp lại chị bầu":
                            if (tmp == "A1" || tmp == "A5" || tmp == "C1" || tmp == "C5")
                            {
                                giatienthucte += dsphim["Gặp lại chị bầu"] / 4;
                            }
                            else if (tmp == "B2" || tmp == "B3" || tmp == "B4")
                            {
                                giatienthucte += dsphim["Gặp lại chị bầu"] * 2;
                            }
                            else if (tmp == "A2" || tmp == "A3" || tmp == "A4" || tmp == "C2" || tmp == "C3" || tmp == "C4" || tmp == "B1" || tmp == "B5")
                            {
                                giatienthucte += dsphim["Gặp lại chị bầu"];
                            }
                            break;
                        case "Tarot":
                            if (tmp == "A1" || tmp == "A5" || tmp == "C1" || tmp == "C5")
                            {
                                giatienthucte += dsphim["Tarot"] / 4;
                            }
                            else if (tmp == "B2" || tmp == "B3" || tmp == "B4")
                            {
                                giatienthucte += dsphim["Tarot"] * 2;
                            }
                            else if (tmp == "A2" || tmp == "A3" || tmp == "A4" || tmp == "C2" || tmp == "C3" || tmp == "C4" || tmp == "B1" || tmp == "B5")
                            {
                                giatienthucte += dsphim["Tarot"];
                            }
                            break;
                    }

                }
                string vitringoi = string.Join("\n", sogheedachon);
                MessageBox.Show(string.Format("Khách hàng: {2}\nPhim: {0}\nPhòng: {4}\nVị trí ngồi:{3}\nGiá: {1}", phimdachon, giatienthucte, txbhoten.Text, vitringoi,cbphong.Text));
            }
            
        }

        private string[] LayPhanTuDaChon()
        {
            List<string> phanTuDaChon = new List<string>();

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                string phanTu = itemChecked.ToString();
                phanTuDaChon.Add(phanTu);
            }

            return phanTuDaChon.ToArray();
        }
        private bool KiemTraTrung()
        {

            foreach (string ghe1 in sogheedachon)
            {
                bool isFound = false;
                foreach (string ghe2 in soghedachon2)
                {
                    if (ghe1 == ghe2)
                    {
                        isFound = true;
                        break;
                    }
                }

                if (isFound && !trung.Contains(ghe1)) // Kiểm tra xem phần tử đã tồn tại trong danh sách trùng chưa
                {
                    trung.Add(ghe1);
                }
            }

            return trung.Count > 0;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            
            comboBox1.Text = "";
            comboBox1.SelectedItem = null;
            soghedachon2 = sogheedachon;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            if (sogheedachon != null && sogheedachon.Length > 0)
            {
                soghedachon2 = sogheedachon;
            }
            sogheedachon = new string[0]; 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbphong.Items.Clear();
            string phimdachon = comboBox1.Text;
            if (phimdachon == "Đào, phở và piano")
            {
                cbphong.Items.Add("Phòng 1");
                cbphong.Items.Add("Phòng 2");
                cbphong.Items.Add("Phòng 3");

            }
            else if (phimdachon == "Mai")
            {
                cbphong.Items.Add("Phòng 2");
                cbphong.Items.Add("Phòng 3");
            }
            else if (phimdachon == "Gặp lại chị bầu")
            {
                cbphong.Items.Add("Phòng 1");
            }
            else if (phimdachon == "Tarot")
            {
                cbphong.Items.Add("Phòng 3");
            }
        }
    }
}
