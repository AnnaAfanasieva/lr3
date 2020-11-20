using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class ComputerManager
    {
        public List<Computer> computers = new List<Computer>();//список комп’ютерів
        //словник можливих задач (Hashtable/Dictionary, ключ – хеш-код)
        public int countcomp;//computers.Count;//загальна кількість комп’ютерів
        public int seats;//кількість робочих місць
        public bool wifi=true;//наявність wi-fi роутера
        public string wifipassword;//пароль на wi-fi

        //public void addd()
        //{
        //    computers.Add
        //}
        


        //public void wifiadd ()
        //{
        //        wifipassword = "12345";  
        //}

        //void countcomputer ()
        //{
        //    countcomp=computers.Count;
        //}

    }
}
