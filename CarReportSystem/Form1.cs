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

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> cars = new BindingList<CarReport>();
        FileStream fs = null;

        public Form1()
        {
            InitializeComponent();
            dgvCarDate.DataSource = cars;
            btsakuzyo.Enabled = false;
            btsyuusei.Enabled = false;
            btclr.Enabled = false;
            btsave.Enabled = false;
            rdtoyota.Checked = true;
        }
        //追加ボタン
        private void bttuika_Click(object sender, EventArgs e)
        {
            CarReport car = new CarReport
            {
                Date = dtpdate.Value,
                Author = cbkiroku.Text,
                Maker =  radioButton(),
                Text = tbrepot.Text,
                Name = cbcar.Text,
                ImgPicture = pbImage.Image
            };
            cars.Add(car);
            setComboBoxMakertext(cbkiroku.Text);
            setComboBoxMakerName(cbcar.Text);
            reset();
            Masc();
        }
        //コンボボックスの設定
        private void setComboBoxMakertext(string maker)
        {
            if (!cbkiroku.Items.Contains(maker))
            {
                //コンボボックスの候補に追加
                cbkiroku.Items.Add(maker);
            }
            //コンボボックスの設定
        }
        private void setComboBoxMakerName(string Name)
        {
            if (!cbcar.Items.Contains(Name))
            {
                //コンボボックスの候補に追加
                cbcar.Items.Add(Name);
            }

        }
        //修正ボタン
        private void btsyuusei_Click(object sender, EventArgs e)
        {
                if (dgvCarDate.CurrentRow != null)
                {
                    cars[dgvCarDate.CurrentRow.Index].Date = dtpdate.Value;
                    cars[dgvCarDate.CurrentRow.Index].Author = cbkiroku.Text;
                    cars[dgvCarDate.CurrentRow.Index].Maker = radioButton();
                    cars[dgvCarDate.CurrentRow.Index].Text = tbrepot.Text;
                    cars[dgvCarDate.CurrentRow.Index].Name = cbcar.Text;
                    cars[dgvCarDate.CurrentRow.Index].ImgPicture = pbImage.Image;
                btsyuusei.Enabled = false;
                btclr.Enabled = false;
                dgvCarDate.Refresh();
            }
            reset();


            }
        //削除ボタン
        private void btclr_Click(object sender, EventArgs e)
        {
            int i = dgvCarDate.CurrentRow.Index;

            cars.RemoveAt(i);
            dgvCarDate.Refresh();
            reset();
            Masc();
            btclr.Enabled = false;
            btsyuusei.Enabled = false;
        }
        //開くボタン
        private void bthiraku_Click(object sender, EventArgs e)
        {
            if (openImag.ShowDialog() == DialogResult.OK)
            {
                //「開く」ボタンが選択された時の処理
                pbImage.Image = Image.FromFile(openImag.FileName);//こんな感じで選択されたファイルのパスが取得できる
                pbImage.SizeMode = PictureBoxSizeMode.AutoSize;
                btsakuzyo.Enabled = true;
            }
        }
        //テキストのリセット
        private void reset()
        {
            cbkiroku.Text = null;
            rdtoyota.Checked = true;
            tbrepot.Text = null;
            cbcar.Text = null;
        }
        //画像削除ボタン
        private void btsakuzyo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に削除しますか？", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                pbImage.Image = null;
                btsakuzyo.Enabled = false;
            }
        }
       
       
        //データグリッドビューを選択時
        private void dgvCarDate_Click(object sender, EventArgs e)
        {
            if (dgvCarDate.CurrentRow != null)
            {
                CarReport selectedCar = cars[dgvCarDate.CurrentRow.Index];
                cbcar.Text = selectedCar.Name;
                rdselect(selectedCar.Maker);
                cbkiroku.Text = selectedCar.Author;
                pbImage.Image = selectedCar.ImgPicture;
                dtpdate.Value = selectedCar.Date;
                btclr.Enabled = true;
                btsyuusei.Enabled = true;
            }
        }
        private void Masc()
        {
            if (cars.Count == 0)
            {
                //ボタンを押せなくする
                btsave.Enabled = false;
            }
            else
            {
                //ボタンを押せるようにする
                btsave.Enabled = true;
            }
        }
        private CarReport.CarMaker radioButton()
        {
            string rdname = "";
            foreach (RadioButton rd in groupBox1.Controls)
                if(rd.Checked)
                rdname = rd.Text;
            switch (rdname)
            {
                case "トヨタ":
                    return CarReport.CarMaker.トヨタ;
                    break;
                case "日産":
                    return CarReport.CarMaker.日産;
                    break;
                case "ホンダ":
                    return CarReport.CarMaker.ホンダ;
                    break;
                case "スバル":
                    return CarReport.CarMaker.スバル;
                    break;
                case "外車":
                    return CarReport.CarMaker.外車;
                    break;
                case "その他":
                    return CarReport.CarMaker.その他;
                    break;
                default:
                    return CarReport.CarMaker.DEFAUL;
                    break;
            }


        }
        private void rdselect(CarReport.CarMaker i)
        {
            foreach (RadioButton rd in groupBox1.Controls)
            {
                if (rd.Text == i.ToString())
                    rd.Checked = true;
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //保存ボタン
        private void btsave_Click_1(object sender, EventArgs e)
        {
            if (sfdtext.ShowDialog() == DialogResult.OK)
            {


                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(sfdtext.FileName, FileMode.Create))
                    try
                    {
                        formatter.Serialize(fs, cars);
                    }
                    catch (SerializationException f)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + f.Message);
                        throw;
                    }
            }
        }
        //データグリッドビューの開くボタン
        private void btopen_Click_1(object sender, EventArgs e)
        {
            if (ofdtext.ShowDialog() == DialogResult.OK)
            {
                using ( fs = new FileStream(ofdtext.FileName, FileMode.Open))
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();


                        cars = (BindingList<CarReport>)formatter.Deserialize(fs);
                        dgvCarDate.DataSource = cars;
                        dgvCarDate_Click(sender, e);
                    }
                    catch (SerializationException f)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + f.Message);
                        throw;
                    }
                Masc();
            }
        }
        //新規入力
        private void 新規入力ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbkiroku.Text = null;
            rdtoyota.Checked = true;
            tbrepot.Text = null;
            cbcar.Text = null;
            dgvCarDate.CurrentCell = null;
             fs = null;
            cars.Clear();
            Masc();
            btclr.Enabled = false;
            btsyuusei.Enabled = false;

        }
        //名前を付けて保存
        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdtext.ShowDialog() == DialogResult.OK)
            {


                BinaryFormatter formatter = new BinaryFormatter();
                using ( fs = new FileStream(sfdtext.FileName, FileMode.Create))
                    try
                    {
                        formatter.Serialize(fs, cars);
                    }
                    catch (SerializationException f)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + f.Message);
                        throw;
                    }
            }
        }
        //上書き保存
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fs == null)
            {
                if (sfdtext.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (fs = new FileStream(sfdtext.FileName, FileMode.Create))
                        try
                        {
                            formatter.Serialize(fs, cars);
                        }
                        catch (SerializationException f)
                        {
                            Console.WriteLine("Failed to serialize. Reason: " + f.Message);
                            throw;
                        }
                }
            }
            else
            {
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    formatter.Serialize(fs, cars);
                }
                catch (SerializationException f)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + f.Message);
                    throw;
                }
            }    
        }
        //終了
        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //開く
        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdtext.ShowDialog() == DialogResult.OK)
            {
                using ( fs = new FileStream(ofdtext.FileName, FileMode.Open))
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();


                        cars = (BindingList<CarReport>)formatter.Deserialize(fs);
                        dgvCarDate.DataSource = cars;
                        dgvCarDate_Click(sender, e);
                    }
                    catch (SerializationException f)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + f.Message);
                        throw;
                    }
                Masc();
            }
        }
    }
    
}
