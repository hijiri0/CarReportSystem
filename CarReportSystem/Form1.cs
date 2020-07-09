using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {

        BindingList<CarReport> _CarReports = new BindingList<CarReport>();



        public Form1()
        {
            InitializeComponent();
            dgvCarData.DataSource = _CarReports;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            #region
            //var obj = new CarReport
            //{
            //    CreatedData = dtDay.Value,
            //    Author = cbAuthor.Text,
            //    Maker = GetCarMaker(),
            //    Name = cbName.Text,
            //    Report = tbMemo.Text,
            //    Picture = pbimge.Image,
            //};
            #endregion

            CarReport carr = new CarReport();

            carr.CreatedData = dtDay.Value;
            carr.Author = cbAuthor.Text;
            carr.Maker = GetCarMaker();
            carr.Name = cbName.Text;
            carr.Report = tbMemo.Text;
            carr.Picture = pbimge.Image;

            _CarReports.Add(carr);
            Clear();
        }

        CarMaker GetCarMaker()
        {
            if(rbtoyota.Checked==true)
            {
                return CarMaker.トヨタ;
            }
            if (rbnisan.Checked == true)
            {
                return CarMaker.日産;
            }
            if (rbhonda.Checked == true)
            {
                return CarMaker.ホンダ;
            }
            if (rbsubaru.Checked == true)
            {
                return CarMaker.スバル;
            }
            if (rbsonota.Checked == true)
            {
                return CarMaker.その他;
            }
            if (rbgaisya.Checked == true)
            {
                return CarMaker.外車;
            }

            return CarMaker.DEDAULT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                
                pbimge.Image = Image.FromFile(ofdOpenImage.FileName);

               
                pbimge.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pbimge.Image = null;   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _CarReports.RemoveAt(dgvCarData.CurrentRow.Index);
            dgvCarData.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarReport selectedCarr = _CarReports[dgvCarData.CurrentRow.Index];

            selectedCarr.CreatedData = dtDay.Value;
            selectedCarr.Name = cbName.Text;
            selectedCarr.Maker = GetCarMaker();
            selectedCarr.Report = tbMemo.Text;
            selectedCarr.Picture = pbimge.Image;
            selectedCarr.Author = cbAuthor.Text;

            dgvCarData.Refresh();  //データグリッドビューの再描画
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Clear()
        {
            cbName.Text = "";
            cbAuthor.Text = "";
            tbMemo.Text = "";

            pbimge.Image = null;

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
