using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidateDataLibrary;

namespace HeightCounter {
    public partial class ProgramForm : Form {
        public ProgramForm() {
            InitializeComponent();
        }

        bool IsValid() {
            if (Validator.IsEmpty(txtHeight.Text)) {
                MessageBox.Show("bạn không thể không nhập gì cả nhé.");
                return false;
            }
            if (!Validator.IsNumberic(txtHeight.Text)) {
                MessageBox.Show("bạn phải nhập SỐ chứ???.");
                return false;
            }
            int height = int.Parse(txtHeight.Text);
            if (height <= 0) {
                MessageBox.Show("nhập clgt thế dude??? lừa à?");
                return false;
            } else if (height > 240) {
                MessageBox.Show("bạn cao thế :), đi lấy kỷ lục guiness đi.");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e) {
            if (!IsValid()) {
                return;
            }

            int height = int.Parse(txtHeight.Text);
            if(txtHeight.Text.Length == 3) {
                string m = txtHeight.Text.Substring(0, 1);
                string cm = txtHeight.Text.Substring(1);
                MessageBox.Show("Chiều cao của bạn là " + m + "m" + cm);
            } else if(txtHeight.Text.Length == 2) {
                MessageBox.Show("Chiều cao của bạn là " + height + "cm" );
            }

            if (height < 150) {
                MessageBox.Show("Bạn thấp vl :)");
            } else if(height >= 180) {
                MessageBox.Show("Nice! Tớ thích những người cao như cậu :3.");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
