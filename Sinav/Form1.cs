using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Sinav
{
    public partial class Form1 : Form
    {
        private SerialPort port;
        private DateTime firstReadingTime;
        private DateTime lastReadingTime;
        private bool isFirstReading = true;
        private bool durrr = false;
        private bool isSecondReading = false;
        private bool restartTimer = false;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string portName = "COM7"; // Seri portun adýný buraya girin

            // Seri portu baþlat
            port = new SerialPort(portName, 9600);
            port.DataReceived += Port_DataReceived;
            port.Open();

            // Timer'ý baþlat
            timer = new Timer();
            timer.Interval = 10; // 1 saniye
            timer.Tick += Timer_Tick;
            timer.Start();

            // Ardýþýk olarak veri okumak için bir thread baþlat
            Thread readDataThread = new Thread(ReadData);
            readDataThread.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //while (restartTimer) {  }
            if (restartTimer)
            {
                TimeSpan elapsedTime = lastReadingTime - firstReadingTime;

                //   label_gogus.Text = "Geçen süre: " + elapsedTime.TotalSeconds.ToString("F2") + " s";

                label_skor.Text = "Süre: " + elapsedTime.TotalSeconds.ToString("F2") + " s";

                restartTimer = false;

            }


            if (durrr)
            {
                TimeSpan elapsedTime2 = DateTime.Now - firstReadingTime;
                label_gogus.Text = "Geçen süre: " + elapsedTime2.TotalSeconds.ToString("F2") + " s";

                if (isSecondReading)
                {
                    label_gogus.Text = label_skor.Text; // Modify this line to display the desired text when the second reading is made
                    durrr = false;
                    Form2 form2 = new Form2(label_gogus.Text);
                    form2.Show();
                }
            }





        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = port.ReadExisting();
           

            lastReadingTime = DateTime.Now;
            if (isFirstReading)
            {
                firstReadingTime = DateTime.Now;
                lastReadingTime = DateTime.Now;
                isFirstReading = false;
                durrr = true;
                
            }
            else
            {
                isSecondReading = true;
                // isSecondReading = true;
                restartTimer = true;
                

            }
            //else
            //{
            //    // label_gogus.Text = "Geçen süre: " + elapsedTime.ToString(@"hh\:mm\:ss");
            //   // restartTimer = true;
            //}
        }

        private void ReadData()
        {
            while (true)
            {
                if (port.IsOpen && port.BytesToRead > 0)
                {
                    string data = port.ReadExisting();
                    Invoke((MethodInvoker)delegate
                    {
                        // Ýstediðiniz iþlemleri burada yapabilirsiniz
                        
                    });
                }

                Thread.Sleep(1000); // Ýþlemciyi bir süre uyut
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form kapatýldýðýnda seri portu kapat
            if (port != null && port.IsOpen)
            {
                port.Close();
            }

            // Timer'ý durdur
            timer.Stop();
            timer.Dispose();
        }

        private void button_barkod_Click(object sender, EventArgs e)
        {
           
            
            isFirstReading = true;
            isSecondReading = false;

            
            label_skor.Text = "Süre: 00.00";
            label_gogus.Text = "Süre: 00.00";
        }
    }
}
