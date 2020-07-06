using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> cars = new BindingList<CarReport>();
        public Form1()
        {
            InitializeComponent();
            dgvCarDate.DataSource = cars;
        }
        //追加ボタン
        private void bttuika_Click(object sender, EventArgs e)
        {
            CarReport car = new CarReport
            {
                Date = dtpdate.Value,
                Author = cbkiroku.Text,
                Maker =  ,
                Text = tbrepot.Text,
                Name = cbcar.Text,
                ImgPicture = pbImage.Image
            };
            cars.Add(car);
            setComboBoxMakertext(cbkiroku.Text);
            setComboBoxMakerName(cbcar.Text);
            reset();
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
                    cars[dgvCarDate.CurrentRow.Index].Maker = ??.Text;
                    cars[dgvCarDate.CurrentRow.Index].Text = tbrepot.Text;
                    cars[dgvCarDate.CurrentRow.Index].Name = cbcar.Text;
                    cars[dgvCarDate.CurrentRow.Index].ImgPicture = pbImage.Image;
                }
            reset();


            }
        //削除ボタン
        private void btclr_Click(object sender, EventArgs e)
        {
            int i = dgvCarDate.CurrentRow.Index;

            cars.RemoveAt(i);
            reset();
        }
        //開くボタン
        private void bthiraku_Click(object sender, EventArgs e)
        {
            if (openImag.ShowDialog() == DialogResult.OK)
            {
                //「開く」ボタンが選択された時の処理
                pbImage.Image = Image.FromFile(openImag.FileName);//こんな感じで選択されたファイルのパスが取得できる
                pbImage.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }
        private void reset()
        {
            dtpdate.Value = null;
            cbkiroku.Text = null;
            Maker??
            tbrepot.Text = null;
            cbcar.Text = null;
            pbImage.Image = null;
        }
        //画像削除ボタン
        private void btsakuzyo_Click(object sender, EventArgs e)
        {

        }
    }
    
}
