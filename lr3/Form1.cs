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
        //List<Computer> computers;
        private List<Computer> tasks1 = new List<Computer>();
        private List<Computer> tasks2 = new List<Computer>();
        private List<Computer> tasks3 = new List<Computer>();
        private List<Computer> tasks4 = new List<Computer>();
        private List<Computer> tasks5 = new List<Computer>();

        ComputerManager computerManager;

        public Form1()
        {
            InitializeComponent();
            computerManager = new ComputerManager();
            // computers = computerManager.computers;
            computerManager.computers.Add(new Computer("Computer1", tasks1, 0, true));
            computerManager.computers.Add(new Computer("Computer2", tasks2, 0, false));
            computerManager.computers.Add(new Computer("Computer3", tasks3, 0, true));
            computerManager.computers.Add(new Computer("Computer4", tasks4, 0, true));
            computerManager.computers.Add(new Computer("Computer5", tasks5, 0, true));
            
            initComboComp();
        }

        private void initComboComp()//обновление блока компьютеров
        {
            comboBoxComp.Items.Clear();
            foreach (Computer computer in computerManager.computers)
            {
                comboBoxComp.Items.Add(computer.compnames);
            }
            comboBoxComp.SelectedIndex = 0;

        }
        //void countcomputer()
        //{
        //    countcomp = computerManager.computers.Count;
        //}

        private void initComboTask()//обновление блока задач
        {
            comboBoxTasks.Items.Clear();
            foreach (Computer computer in computerManager.computers)
            {
                comboBoxTasks.Items.Add(computer.tasks);
            }
            comboBoxTasks.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e) //открыть форму добавления задач
        {
            AddTask newForm = new AddTask();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) //открыть форму добавления ПК
        {
            AddPC newForm = new AddPC();
            newForm.Show();
        }

        private void comboBoxComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(computerManager.computers[comboBoxComp.SelectedIndex].ready) 
            {
                readiness.Text = "готов";
            }
            else
            {
                readiness.Text = "не готов";
            }
            //readiness.Text = computerManager.computers[comboBoxComp.SelectedIndex].ready.ToString();
        }
        //public void wifi ()
        //{

        //}



        //label1.Text = String.Format("Вы выбрали: {0}", dateTimePicker1.Text);
        //для даты
    }
}
