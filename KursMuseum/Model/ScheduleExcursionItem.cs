using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class ScheduleExcursionItem
    {
        //Номер экскурсии
        [DisplayName("ID Экскурсии")]
        public int IdScheduleExcursionItem { get; set; }
        [DisplayName("Тип экскурсии")]
        //Тип экскурсии     
        public string TypeExcursion { get; set; }
        [DisplayName("Время начала экскурсии")]
        //Время начала экскурсии
        public DateTime TimeStart { get; set; }
        [DisplayName("Время конца экскурсии")]
        //Время конца экскурсии
        public DateTime TimeFinish { get; set; }  
        [DisplayName("Возможное количество людей")]
        //Возможное количество людей
        public int PeopleCount { get; set; }
        //public List<TypeExcursion> TypeExcursions = new List<TypeExcursion>();
    }
}