using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class ComputerManager
    {
        public List<Computer> computers;//список комп’ютерів
        //словник можливих задач (Hashtable/Dictionary, ключ – хеш-код)
        //загальна кількість комп’ютерів
        public int seats;//кількість робочих місць
        public bool wifi;//наявність wi-fi роутера
        public string wifipassword;//пароль на wi-fi

    }
}
