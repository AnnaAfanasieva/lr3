using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class Computer
    {
        public string compnames;//название компьютера
        public List<Computer> tasks;//список призначених задач
        public int counttasks;//кількість призначених задач
        public bool ready;//готовність до роботи
        

        public Computer(string compnames, List<Computer> tasks, int counttasks, bool ready)
        {
            this.compnames = compnames;
            this.tasks = tasks;
            this.counttasks = counttasks;
            this.ready = ready;
        }


    }

   

}
