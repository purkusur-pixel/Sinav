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
            string portName = "COM7"; // Seri portun ad�n� buraya girin

            // Seri portu ba�lat
            port = new SerialPort(portName, 9600);
            port.DataReceived += Port_DataReceived;
            port.Open();

            // Timer'� ba�lat
            timer = new Timer();
            timer.Interval = 10; // 1 saniye
            timer.Tick += Timer_Tick;
            timer.Start();

            // Ard���k olarak veri okumak i�in bir thread ba�lat
            Thread readDataThread = new Thread(ReadData);
            readDataThread.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //while (restartTimer) {  }
            if (restartTimer)
            {
                TimeSpan elapsedTime = lastReadingTime - firstReadingTime;

                //   label_gogus.Text = "Ge�en s�re: " + elapsedTime.TotalSeconds.ToString("F2") + " s";

                label_skor.Text = "S�re: " + elapsedTime.TotalSeconds.ToString("F2") + " s";

                restartTimer = false;

            }


            if (durrr)
            {
                TimeSpan elapsedTime2 = DateTime.Now - firstReadingTime;
                label_gogus.Text = "Ge�en s�re: " + elapsedTime2.TotalSeconds.ToString("F2") + " s";

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
            //    // label_gogus.Text = "Ge�en s�re: " + elapsedTime.ToString(@"hh\:mm\:ss");
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
                        // �stedi�iniz i�lemleri burada yapabilirsiniz
                        
                    });
                }

                Thread.Sleep(1000); // ��lemciyi bir s�re uyut
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form kapat�ld���nda seri portu kapat
            if (port != null && port.IsOpen)
            {
                port.Close();
            }

            // Timer'� durdur
            timer.Stop();
            timer.Dispose();
        }

        private void button_barkod_Click(object sender, EventArgs e)
        {
           
            
            isFirstReading = true;
            isSecondReading = false;

            
            label_skor.Text = "S�re: 00.00";
            label_gogus.Text = "S�re: 00.00";
        }
    }
}
