using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTimer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Timer timer;
        
        private void GetMessage_Click(object sender, EventArgs e)
        {
            

            int time = SetTime(SetTimer.Text);
            if (time == -1) { MessageBox.Show("Некорректное значение"); return; }
            
            timer = new Timer();
            timer.Tick += new EventHandler(ShowMessage);
            timer.Interval = time;
            timer.Start();
            
            
        }
        
        private int SetTime(string text)
        {
            const int sec = 1000;
            const int min = 60;
            if (!int.TryParse(text, out int time)) { SetTimer.Text = "0"; return -1; }
            else return time*sec*min;
        }

        private async void ShowMessage(object myObject, EventArgs myEventArgs)
        {
            TopMost = true;
            timer.Stop();
            MessageBox.Show("Время пришло!");
            TopMost = false;
        }
    }
}
