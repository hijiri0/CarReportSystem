using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//_CarReports.Clear();

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

            if (cbAuthor.Text == "")
            {
                MessageBox.Show("記録者の入力をしてください。");
                return;
            }

            CarReport carr = new CarReport();

            carr.CreatedData = dtDay.Value;
            carr.Author = cbAuthor.Text;
            carr.Maker = GetCarMaker();
            carr.Name = cbName.Text;
            carr.Report = tbMemo.Text;
            carr.Picture = pbimge.Image;

            _CarReports.Add(carr);
            setConboBoxAuthor(cbAuthor.Text);
            setConboBoxName(cbName.Text);
            Errorchecking();

            Clear();
        }
        private void setConboBoxAuthor(string Author)
        {
            if (!cbAuthor.Items.Contains(Author))
            {
                //コンボボックスの候補に追加
                cbAuthor.Items.Add(Author);
            }
        }

        private void setConboBoxName(string Name)
        {
            if (!cbName.Items.Contains(Name))
            {
                //コンボボックスの候補に追加
                cbName.Items.Add(Name);
            }
        }




        CarMaker GetCarMaker()
        {
            if (rbtoyota.Checked == true)
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
                btImageclear.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pbimge.Image = null;
            btImageclear.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            _CarReports.RemoveAt(dgvCarData.CurrentRow.Index);
            dgvCarData.ClearSelection();
            Errorchecking();
        }

        private void btcChange_Click(object sender, EventArgs e)
        {
            CarReport selectedCarr = _CarReports[dgvCarData.CurrentRow.Index];

            selectedCarr.CreatedData = dtDay.Value;
            selectedCarr.Name = cbName.Text;
            selectedCarr.Maker = GetCarMaker();
            selectedCarr.Report = tbMemo.Text;
            selectedCarr.Picture = pbimge.Image;
            selectedCarr.Author = cbAuthor.Text;

            Clear();

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
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                BinaryFormatter formatter = new BinaryFormatter();

                //ファイルストリームを生成
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    try
                    {
                        formatter.Serialize(fs, _CarReports);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }

            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            #region
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
            //    {
            //        try
            //        {
            //            BinaryFormatter formatter = new BinaryFormatter();

            //            _CarReports = (BindingList<CarReport>)formatter.Deserialize(fs);
            //            dgvCarData.DataSource = _CarReports;

            //        }
            //        catch (SerializationException se)
            //        {
            //            Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
            //            throw;
            //        }
            //    }
            //}
            #endregion

            this.carReportTableAdapter.Fill(this.infosys202031DataSet.CarReport);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202031DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.carReportTableAdapter.Fill(this.infosys202031DataSet.CarReport);
           

            btImageclear.Enabled = false;
            btcChange.Enabled = false;
            btClear.Enabled = false;
        }
        void Errorchecking()
        {
            if (_CarReports.Count == 0)
            {
               
                btcChange.Enabled = false;
                btClear.Enabled = false;
            }
            else
            {
                
                btcChange.Enabled = true;
                btClear.Enabled = true;

            }
        }

        private void dgvCarData_Click(object sender, EventArgs e)
        {
            var test = dgvCarData.CurrentRow.Cells[1].Value;

            ////if (dgvCarData.CurrentRow == null)
            ////    return;

            //////選択したレコードを取り出す
            //////データグリッドビューの選択した行のインデックス
            //////BindingListのデータ取得する
            ////CarReport selectedCarr = _CarReports[dgvCarData.CurrentRow.Index];

            ////cbName.Text = selectedCarr.Name;
            ////cbAuthor.Text = selectedCarr.Author;
            ////pbimge.Image = selectedCarr.Picture;
            ////tbMemo.Text = selectedCarr.Report;
           
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202031DataSet);

        }

        private void carReportBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202031DataSet);

        }

     
        
    }
}
