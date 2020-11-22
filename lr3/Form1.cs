using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr3
{
    public partial class Form1 : Form
    {

        ComputerManager computerManager;

        public Form1()
        {
        
        InitializeComponent();
            computerManager = new ComputerManager();
            //computers = computerManager.computers;
            computerManager.computers.Add(new Computer("Computer1", new Dictionary<int, string>(), 0, true));
            computerManager.computers.Add(new Computer("Computer2", new Dictionary<int, string>(), 0, false));
            computerManager.computers.Add(new Computer("Computer3", new Dictionary<int, string>(), 0, true));
            computerManager.computers.Add(new Computer("Computer4", new Dictionary<int, string>(), 0, true));
            computerManager.computers.Add(new Computer("Computer5", new Dictionary<int, string>(), 0, true));
            computerManager.computers[0].tasks[0] = computerManager.taskslist[2];
            computerManager.computers[1].tasks[0] = computerManager.taskslist[1];
            computerManager.computers[1].tasks[1] = computerManager.taskslist[2];
            computerManager.computers[2].tasks[0] = computerManager.taskslist[3];
            computerManager.computers[3].tasks[0] = computerManager.taskslist[4];
            computerManager.computers[4].tasks[0] = computerManager.taskslist[3];
            computerManager.computers[4].tasks[1] = computerManager.taskslist[1];

            initForm();
        }

        private void initForm()
        {
            listBoxComp.Items.Clear();
            int i = 0;
            foreach (Computer computer in computerManager.computers)
            {
                listBoxComp.Items.Insert(i,computer.compnames);
                i++;
            }
           listBoxComp.SelectedIndex = 0;
            i = 0;
            
            i = 0;
            initTasks();
            
            wifipassword.Text = computerManager.wifipassword;
            //////////////////
            countcomp.Text = computerManager.computers.Count.ToString();
        }

        private void initTasks()
        {
            int i = 0;
            listBoxTasks.Items.Clear();
            for (int j = 0; j < computerManager.computers[listBoxComp.SelectedIndex].tasks.Count; j++)
            {
                listBoxTasks.Items.Insert(i, computerManager.computers[listBoxComp.SelectedIndex].tasks[j]);// Для тасков добавить
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e) //открыть форму добавления задач
        {
            AddTask newForm = new AddTask();
            newForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //открыть форму добавления ПК
        {

            computerManager.computers.Add(new Computer());
            AddPC newForm = new AddPC(computerManager.computers[computerManager.computers.Count - 1]);
            newForm.ShowDialog();
            computerManager.computers[computerManager.computers.Count - 1].tasks = new Dictionary<int, string>();
            initForm();
        }

        private void wifiChange_Click(object sender, EventArgs e)
        {
            ChangeWifi changeWifi = new ChangeWifi();
            changeWifi.ShowDialog();

            wifiDelete.Visible = true;
            wifi.Visible = true;
            wifipassword.Visible = true;

            computerManager.wifiChange(true);
            initForm();
        }

        private void wifiDelete_Click(object sender, EventArgs e)
        {
            wifiDelete.Visible = false;
            computerManager.wifiChange(false);
            wifi.Visible = false;
            wifipassword.Visible = false;
            MessageBox.Show("Сеть была удалена","Message");
        }

        private void listBoxComp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (computerManager.computers[listBoxComp.SelectedIndex].ready)
            {
                readiness.Text = "готов";
            }
            else
            {
                readiness.Text = "не готов";
            }
            initTasks();
            //int i = 0;
            //listBoxTasks.Items.Clear();
            // for (int j = 0; j < computerManager.computers[listBoxComp.SelectedIndex].tasks.Count; j++)
            //    {
            //        listBoxTasks.Items.Insert(i, computerManager.computers[listBoxComp.SelectedIndex].tasks[j]);// Для тасков добавить
            //        i++;
            //    }
            //    i = 0;


        }

        //label1.Text = String.Format("Вы выбрали: {0}", dateTimePicker1.Text);
        //для даты
    }
}
