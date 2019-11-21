using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramSubKlient
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        bool subscription = false;

        public Form1()
        {
            InitializeComponent();
        }

        void subscribeData()
        {
            using (var subSocket = new SubscriberSocket())
            {
                try
                {
                    subSocket.Connect("tcp://localhost:12345");
                }
                catch (SocketException se)
                {
                    MessageBox.Show(se.Message);
                    MethodInvoker methodInvoker = new MethodInvoker(() =>
                    {
                        btnStart.Enabled = true;
                        btnStop.Enabled = false;
                        subscription = false;
                        subCPU.Enabled = true;
                        subRAM.Enabled = true;
                        subDisk.Enabled = true;
                        btnStart.Enabled = true;
                    });
                    Invoke(methodInvoker);
                }

                if (subCPU.Checked)
                {
                    subSocket.Subscribe("CPU");
                }
                if (subRAM.Checked)
                {
                    subSocket.Subscribe("RAM");
                }
                if (subDisk.Checked)
                {
                    subSocket.Subscribe("DYSK");
                }

                while (subscription)
                {
                    string messageTopic = subSocket.ReceiveFrameString();
                    string messageReceive = subSocket.ReceiveFrameString();
                    MethodInvoker methodInvoker = () => receiveLogs(messageTopic, messageReceive);
                    Invoke(methodInvoker);
                }
            }
        }

        void receiveTopics()
        {
            try
            {
                if (askTime.Checked)
                {
                    using (var requestSocket = new RequestSocket(">tcp://localhost:5555"))
                    {
                        requestSocket.SendFrame("interval");
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysłano prośbę o interwał");
                        string requestMessage = requestSocket.ReceiveFrameString();
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebraną interwał: " + requestMessage + " sekund.");
                    }
                }
                if (askTopics.Checked)
                {
                    using (var requestSocket = new RequestSocket(">tcp://localhost:5555"))
                    {
                        requestSocket.SendFrame("CPU");
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysłano prośbę o temat CPU");
                        string requestMessage = requestSocket.ReceiveFrameString();
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebraną tematy: " + requestMessage);
                        requestSocket.SendFrame("RAM");
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysłano prośbę o temat RAM");
                        string request2Message = requestSocket.ReceiveFrameString();
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebraną tematy: " + request2Message);
                        requestSocket.SendFrame("DYSK");
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysłano prośbę o temat DYSKU");
                        string request3Message = requestSocket.ReceiveFrameString();
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebraną tematy: " + request3Message);
                    }
                }
                if (subCPU.Checked)
                {
                    using (var requestSocket = new RequestSocket(">tcp://localhost:5555"))
                    {
                        requestSocket.SendFrame("sentCPU");
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysłano prośbę o CPU");
                        string requestMessage = requestSocket.ReceiveFrameString();
                        float fCPU = float.Parse(requestMessage);
                        metroProgressCPU.Value = (int)fCPU;
                        labelCPU.Text = string.Format("{0:0.0}%", fCPU);
                        chart.Series["CPU"].Points.AddY(fCPU);
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebrano CPU: " + fCPU);
                    }
                }
                if (subRAM.Checked)
                {
                    using (var requestSocket = new RequestSocket(">tcp://localhost:5555"))
                    {
                        requestSocket.SendFrame("sentRAM");
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysłano prośbę o RAM");
                        string requestMessage = requestSocket.ReceiveFrameString();
                        float fRAM = float.Parse(requestMessage);
                        metroProgressRAM.Value = (int)fRAM;
                        labelRAM.Text = string.Format("{0:0.0}%", fRAM);
                        chart.Series["RAM"].Points.AddY(fRAM);
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebrano RAM: " + fRAM);
                    }
                }
                if (subDisk.Checked)
                {
                    using (var requestSocket = new RequestSocket(">tcp://localhost:5555"))
                    {
                        requestSocket.SendFrame("sentDYSK");
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysłano prośbę o DYSK");
                        string requestMessage = requestSocket.ReceiveFrameString();
                        float fDisk = float.Parse(requestMessage);
                        metroProgressDisk.Value = (int)fDisk;
                        labelDisk.Text = string.Format("{0:0.0}%", fDisk);
                        chart.Series["DYSK"].Points.AddY(fDisk);
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebrano DYSK: " + fDisk);
                    }
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        void receiveLogs(string messageTopic, string messageText)
        {
            switch (messageTopic)
            {
                case "CPU":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebranie CPU: " + messageText);
                    float fCPU = float.Parse(messageText);
                    metroProgressCPU.Value = (int)fCPU;
                    labelCPU.Text = string.Format("{0:0.0}%", fCPU);
                    chart.Series["CPU"].Points.AddY(fCPU);
                    break;
                case "RAM":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebranie RAM: " + messageText);
                    float fRAM = float.Parse(messageText);
                    metroProgressRAM.Value = (int)fRAM;
                    labelRAM.Text = string.Format("{0:0.0}%", fRAM);
                    chart.Series["RAM"].Points.AddY(fRAM);
                    break;
                case "DYSK":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebranie DYSK: " + messageText);
                    float fDisk = float.Parse(messageText);
                    metroProgressDisk.Value = (int)fDisk;
                    labelDisk.Text = string.Format("{0:0.0}%", fDisk);
                    chart.Series["DYSK"].Points.AddY(fDisk);
                    break;
            }
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            subCPU.Enabled = false;
            subRAM.Enabled = false;
            subDisk.Enabled = false;
            btnStart.Enabled = false;
            subscription = true;
            Task task = Task.Run(() => subscribeData());
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            subCPU.Enabled = true;
            subRAM.Enabled = true;
            subDisk.Enabled = true;
            btnStart.Enabled = true;
            subscription = false;
        }

        private void askServer_Click(object sender, EventArgs e)
        {
            receiveTopics();
        }

        private void textTime_TextChanged(object sender, EventArgs e)
        {
            timer1.Interval = Int32.Parse(textTime.Text) * 1000;
        }

        private void pickEvery_CheckedChanged(object sender, EventArgs e)
        {
            if (pickEvery.Checked)
            {
                try
                {
                    windowLogs.Items.Add("Wybrano opcje odświeżania co: " + textTime.Text + " sekund.");
                    timer1.Interval = Int32.Parse(textTime.Text) * 1000;
                    timer1.Start();
                }
                catch (FormatException fe)
                {
                    MessageBox.Show(fe.Message);
                    pickEvery.Checked = false;
                }

            }
            else
            {
                timer1.Stop();
            }
        }

        private void setRequest_Click(object sender, EventArgs e)
        {
            receiveTopics();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            receiveTopics();
        }
    }
}
