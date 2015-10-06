using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace TaskManager
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        public Info(Process prc)
        {
            InitializeComponent();
            label1.Text = "Имя процесса: " + prc.ProcessName;
            label2.Text = "ИД процесса: " + prc.Id;
            label3.Text = "Занятый объем памяти: " + prc.WorkingSet64;
            label4.Text = "Приоритет процесса: " + prc.BasePriority;
            label5.Text = "Число дескрипторов, открытых процессом: " + prc.HandleCount;
            label6.Text = "Кол-во потоков: " + prc.Threads.Count;
            try
            {
                foreach (ProcessModule p in prc.Modules)
                {
                    ListViewItem lvi = new ListViewItem(p.ModuleName);
                    try
                    {
                        lvi.SubItems.Add(p.FileVersionInfo.FileVersion);
                    }
                    catch (System.IO.FileNotFoundException exp)
                    {
                        lvi.SubItems.Add("");
                    }
                    lvi.SubItems.Add(p.FileName);
                    listView1.Items.Add(lvi);
                }
            }
            catch (Win32Exception exp)
            {
                listView1.Visible = false;
            }
           
        }
    }
}
