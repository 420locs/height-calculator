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

namespace HighCount {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        bool IsValid() {
            if (textBox1.Text.Trim().Length == 0) {
                MessageBox.Show("bạn không thể đéo nhập gì cả nhé.");
                return false;
            }
            if (!Regex.IsMatch(textBox1.Text.Trim(), @"^[0-9]+$")) {
                MessageBox.Show("bạn phải nhập SỐ chứ???.");
                return false;
            }
            int height = int.Parse(textBox1.Text);
            if (height < 50) {
                MessageBox.Show("làm đéo gì thấp thế dude??? lừa vl.");
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

            int height = int.Parse(textBox1.Text);
            if(textBox1.Text.Length == 3) {
                string m = textBox1.Text.Substring(0, 1);
                string cm = textBox1.Text.Substring(1);
                MessageBox.Show("Chiều cao của bạn là " + m + "m" + cm);
            } else if(textBox1.Text.Length == 2) {
                MessageBox.Show("Chiều cao của bạn là " + height + "cm" );
            }

            if (height < 150) {
                MessageBox.Show("Bạn thấp vl :)");
            } 
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
