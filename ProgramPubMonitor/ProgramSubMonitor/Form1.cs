using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramSubMonitor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Task task1 = Task.Run(() => sendOnce());
            //Task task3 = Task.Run(() => sendServer());
        }

        void publicData() // wysyłanie danych jako publisher z wybraniem CPU, RAM itd.
        {
            using (var pubSocket = new PublisherSocket())
            {
                pubSocket.Bind("tcp://*:12345");
                while (true)
                {
                    if (pubCPU.Checked)
                    {
                        string messageTopic = "CPU";
                        float fCPU = perfCPU.NextValue();
                        string messageContent = fCPU.ToString();
                        pubSocket.SendMoreFrame(messageTopic).SendFrame(messageContent);
                        MethodInvoker methodInvoker = () => sendLogs(messageTopic, messageContent);
                        Invoke(methodInvoker);
                    }
                    if (pubRAM.Checked)
                    {
                        string messageTopic = "RAM";
                        float fRAM = perfRAM.NextValue();
                        string messageContent = fRAM.ToString();
                        pubSocket.SendMoreFrame(messageTopic).SendFrame(messageContent);
                        MethodInvoker methodInvoker = () => sendLogs(messageTopic, messageContent);
                        Invoke(methodInvoker);
                    }
                    if (pubDisk.Checked)
                    {
                        string messageTopic = "DYSK";
                        float fDisk = perfDisk.NextValue();
                        string messageContent = fDisk.ToString();
                        pubSocket.SendMoreFrame(messageTopic).SendFrame(messageContent);
                        MethodInvoker methodInvoker = () => sendLogs(messageTopic, messageContent);
                        Invoke(methodInvoker);
                    }
                    try
                    {
                        Thread.Sleep(Int32.Parse(timeText.Text) * 1000);
                    }
                    catch (FormatException fe)
                    {
                        MessageBox.Show(fe.Message);
                        string timeToSent = timeText.Text;
                        MethodInvoker mi = new MethodInvoker(() => timeToSent = "10");
                        Invoke(mi);
                    }
                }
            }
        }

        void sendOnce() // Sprawdzenie jakie są włączone pomiary
        {
            using (var responseSocket = new ResponseSocket("@tcp://*:5555"))
            {
                while (true)
                {
                    string response = responseSocket.ReceiveFrameString();
                    switch (response)
                    {
                        case "interval":
                            string timeToSent = timeText.Text;
                            responseSocket.SendFrame(timeToSent);
                            break;
                        case "CPU":
                            if (pubCPU.Checked)
                            {
                                responseSocket.SendFrame("Włączony pomiar CPU");
                            }
                            else
                            {
                                responseSocket.SendFrame("Wyłączony pomiar CPU");
                            }
                            break;
                        case "RAM":
                            if (pubRAM.Checked)
                            {
                                responseSocket.SendFrame("Włączony pomiar RAM");
                            }
                            else
                            {
                                responseSocket.SendFrame("Wyłączony pomiar RAM");
                            }
                            break;
                        case "DYSK":
                            if (pubDisk.Checked)
                            {
                                responseSocket.SendFrame("Włączony pomiar Dysku");
                            }
                            else
                            {
                                responseSocket.SendFrame("Wyłączony pomiar Dysku");
                            }
                            break;
                        case "sentCPU":
                            float fCPU = perfCPU.NextValue();
                            string fsCPU = fCPU.ToString();
                            responseSocket.SendFrame(fsCPU);
                            break;
                        case "sentRAM":
                            float fRAM = perfRAM.NextValue();
                            string fsRAM = fRAM.ToString();
                            responseSocket.SendFrame(fsRAM);
                            break;
                        case "sentDYSK":
                            float fDisk = perfDisk.NextValue();
                            string fsDisk = fDisk.ToString();
                            responseSocket.SendFrame(fsDisk);
                            break;
                    }
                    MethodInvoker methodInvoker = () => sendTopics(response);
                    Invoke(methodInvoker);
                }
            }
        }

        void sendTopics(string message) // logi do pomiaru
        {
            switch (message)
            {
                case "interval":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Pomyślnie otrzymaną prośbę o interwał");
                    break;
                case "CPU":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Pomyślnie otrzymaną prośbę o CPU");
                    break;
                case "RAM":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Pomyślnie otrzymaną prośbę o RAM");
                    break;
                case "DYSK":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Pomyślnie otrzymaną prośbę o DYSK");
                    break;
                case "sentCPU":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Pomyślnie otrzymaną prośbę o wysłanie CPU");
                    break;
                case "sentRAM":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Pomyślnie otrzymaną prośbę o wysłanie RAM");
                    break;
                case "sentDYSK":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Pomyślnie otrzymaną prośbę o wysłanie DYSK");
                    break;
            }
        }

        void sendLogs(string message, string messageText) //wysyłanie jako publisher danych
        {
            messageText = null;
            switch (message)
            {
                case "CPU":
                    float fCPU = perfCPU.NextValue();
                    messageText = fCPU.ToString();
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysyłanie danych CPU.");
                    break;
                case "RAM":
                    float fRAM = perfRAM.NextValue();
                    messageText = fRAM.ToString();
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysyłanie danych RAM.");
                    break;
                case "DYSK":
                    float fDisk = perfDisk.NextValue();
                    messageText = fDisk.ToString();
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysyłanie danych DYSK.");
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            settingBox.Enabled = false;
            Task task2 = Task.Run(() => publicData());
        }
    }
}
