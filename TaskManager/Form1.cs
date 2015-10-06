using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.PerformanceData;
using System.Diagnostics;
using System.IO.Pipes;
using System.IO.IsolatedStorage;
using System.IO.Ports;
using System.IO;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProc();
        }

        private void завершитьПроцессToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    int CurrentProcess = Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                    try
                    {
                        Process p = Process.GetProcessById(CurrentProcess);
                        p.Kill();
                    }
                    catch (Win32Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                    ListProc();
                }
            }
        }
        private void ListProc()
        {
            listView1.Items.Clear();
            Process[] proc = System.Diagnostics.Process.GetProcesses();
            List<Process> l = proc.ToList<Process>();
            SortedList<String, Process> sl = new SortedList<string, Process>();
            int it = 0;
            foreach (Process p in proc)
            {
                if (sl.ContainsKey(p.ProcessName))
                    sl.Add(p.ProcessName + it.ToString(), p);
                else sl.Add(p.ProcessName, p);
                it++;
            }
            foreach (KeyValuePair<String, Process> pr in sl.ToList<KeyValuePair<String, Process>>())
            {
                ListViewItem lvi = new ListViewItem(pr.Value.ProcessName);
                lvi.SubItems.Add(pr.Value.BasePriority.ToString());
                lvi.SubItems.Add(pr.Value.Id.ToString());
                lvi.SubItems.Add(pr.Value.WorkingSet64.ToString());
                listView1.Items.Add(lvi);
            }
            toolStripStatusLabel1.Text = "Процессов: " + proc.Count<Process>().ToString();
            int count = 0;
            foreach (Process p in proc)
            {
                count += p.Threads.Count;
            }
            toolStripStatusLabel2.Text = "Потоков: " + count.ToString();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListProc();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = "c:\\";
            fd.Filter = "Только приложения (*.exe)|*.exe";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = fd.FileName;
                try
                {
                    proc.Start();
                }
                catch (Win32Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void информацияОПроцессеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    int CurrentProcess = Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                    Info inf =new Info(Process.GetProcessById(CurrentProcess));
                    inf.ShowDialog();
                }
            }
        }

        private void реальногоВремениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ИзменениеПриоритета(6);
        }
        private void ИзменениеПриоритета(int priority)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    int CurrentProcess = Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                    Process p = Process.GetProcessById(CurrentProcess);
                    try
                    {
                        switch (priority)
                        {
                            case 6:
                                p.PriorityClass = ProcessPriorityClass.RealTime; break;
                            case 5:
                                p.PriorityClass = ProcessPriorityClass.High; break;
                            case 4:
                                p.PriorityClass = ProcessPriorityClass.AboveNormal; break;
                            case 3:
                                p.PriorityClass = ProcessPriorityClass.Normal; break;
                            case 2:
                                p.PriorityClass = ProcessPriorityClass.BelowNormal; break;
                            case 1:
                                p.PriorityClass = ProcessPriorityClass.Idle; break;
                            default:
                                p.PriorityClass = ProcessPriorityClass.Normal; break;
                        }
                    }
                    catch (Win32Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
            }
        }

        private void высокийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ИзменениеПриоритета(5);
            ListProc();
        }

        private void оченьВысокийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ИзменениеПриоритета(4);
            ListProc();
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ИзменениеПриоритета(3);
            ListProc();
        }

        private void оченьНизкийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ИзменениеПриоритета(2);
            ListProc();
        }

        private void низкийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ИзменениеПриоритета(1);
            ListProc();
        }
    }
}
