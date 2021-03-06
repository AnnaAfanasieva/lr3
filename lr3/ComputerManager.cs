﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class ComputerManager
    {
        public static string wifipass = "0000";
        public List<Computer> computers = new List<Computer>();//список комп’ютерів
        public Dictionary<int, string> taskslist = new Dictionary<int, string>();//словник можливих задач (Hashtable/Dictionary, ключ – хеш-код)
        public int countcomp;//загальна кількість комп’ютерів
        public int seats;//кількість робочих місць
        public bool wifi=true;//наявність wi-fi роутера
        public string wifipassword="0000";//пароль на wi-fi

        public ComputerManager()
        {

            createlist();
        }

        public void createlist()
        {
            taskslist.Add(1, "Task1");
            taskslist.Add(2, "Task2");
            taskslist.Add(3, "Task3");
            taskslist.Add(4, "Task4");
            taskslist.Add(5, "Task5");
        }


            public void wifiChange (bool wifiIs)
        {
            wifi = wifiIs;
            if (wifi)
            {
                wifipassword = wifipass;
            }
        }
    }
}
