using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class Task
    {
        public int hour;
        public int minutes;
        public int sec;//час виконання??????????????
        DateTime datedoing = new DateTime(); //дата виконання
        public string taskname;//название задачи
        public bool done=false;//виконано
        //додаткова інформація (назва програми чи ОС)

        public Task() //конструктор по замовченню
        {

        }

        public Task(Task obj)
        {
            this.hour = hour;
            this.minutes = minutes;
            this.sec = sec;
            this.taskname = taskname;
            this.done = done;
        }
        public void dotask1 ()
        {
            //окрас блока
            DateTime datedone = datedoing.AddHours(hour);
            datedone = datedoing.AddMinutes(minutes);
            datedone = datedoing.AddSeconds(sec);
            if (DateTime.Now==datedone )
            {
                //окрас блока!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                done = true;
                //удалить блок!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
        }

        public void dotask2()
        {
            //окрас блока
            DateTime datedone = datedoing.AddHours(hour);
            datedone = datedoing.AddMinutes(minutes);
            datedone = datedoing.AddSeconds(sec);
            if (DateTime.Now == datedone)
            {
                //окрас блока!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                done = true;
                //удалить блок!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
        }

    }
}
