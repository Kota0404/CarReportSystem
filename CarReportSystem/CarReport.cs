using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    [Serializable]
    class CarReport {
        [System.ComponentModel.DisplayName("日付")]
        //メーカー
        public  DateTime Date { get; set; }
        [System.ComponentModel.DisplayName("記録者")]
        //カテゴリー
        public string Author { get; set; }
        [System.ComponentModel.DisplayName("メーカー")]

        public CarMaker Maker { get; set; }
        [System.ComponentModel.DisplayName("車名")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("レポート")]
        public string Text { get; set; }
        [System.ComponentModel.DisplayName("画像")]
        public Image ImgPicture { get; set; }
        public enum CarMaker {
            DEFAUL,
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外車,
            その他
        }
    }
}
