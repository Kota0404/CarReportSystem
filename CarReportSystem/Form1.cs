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

        private void bttuika_Click(object sender, EventArgs e)
        {
            CarReport car = new CarReport
            {
                Date  ,
                Author = cbkiroku.Text,
                Maker =  ,
                Text = tbrepot.Text,
                Name = cbcar.Text,
                ImgPicture = pbImage.Image
            };
            setComboBoxMakertext(cbkiroku.Text);
            setComboBoxMakerName(cbcar.Text);
        }
        private void setComboBoxMakertext(string maker)
        {
            if (!cbkiroku.Items.Contains(maker))
            {
                //コンボボックスの候補に追加
                cbkiroku.Items.Add(maker);
            }

        }
        private void setComboBoxMakerName(string Name)
        {
            if (!cbcar.Items.Contains(Name))
            {
                //コンボボックスの候補に追加
                cbcar.Items.Add(Name);
            }

        }
    }
}
