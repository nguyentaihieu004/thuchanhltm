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
        }
        Dictionary<string, int> dsphim= new Dictionary<string, int>();
       
        string[] dsdadat;
        string[] sogheedachon;

        private void btxuatve_Click(object sender, EventArgs e)
        {
            

            dsphim.Add("Đào, phở và piano", 45000);
            dsphim.Add("Mai", 100000);
            dsphim.Add("Gặp lại chị bầu", 75000);
            dsphim.Add("Tarot",90000);
            string phimdachon=comboBox1.Text;
          CheckedListBox.CheckedItemCollection items = checkedListBox1.CheckedItems;
            string soghe = "";
            foreach (string item in items)
            {
                soghe += item + ",";
            }
            sogheedachon = soghe.Split(',');
            int giatienthucte=0;
            foreach (string tmp in sogheedachon)
            {
                int giave = 0;
                switch (phimdachon)
                {
                    case "Đào, phở và piano":
                        if(tmp =="A1" || tmp == "A5" || tmp == "C1" || tmp == "C5")
                        {
                            giatienthucte += dsphim["Đào, phở và piano"]/4;
                        }
                        else if (tmp == "B2" || tmp == "B3" || tmp == "B4")
                        {
                            giatienthucte += dsphim["Đào, phở và piano"]*2;
                        }
                        else if(tmp=="A2"||tmp=="A3"||tmp=="A4"|| tmp == "C2" || tmp == "C3" || tmp == "C4" || tmp == "B1" || tmp == "B5")
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
            string vitringoi = string.Join("\n",sogheedachon);
            MessageBox.Show(string.Format("Khách hàng: {2}\nPhim: {0}\nVị trí ngồi:\n{3}Giá: {1}", phimdachon, giatienthucte,txbhoten.Text,vitringoi));
        }

        
    }
}
