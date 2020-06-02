using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp2
{
    class MoneuEntry
    {
        private double _amount;

        /// <summary>
        /// Стандартный конструктор
        /// </summary>
        public MoneuEntry()
        {
            _amount = 0;
            EntryDate = DateTime.Now;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="amount">Сумма записи</param>
        /// <param name="date">Дата записи</param>
        public MoneuEntry(double amount, DateTime date)
        {
            _amount = amount;
            EntryDate = date;
        }

        /// <summary>
        /// Инициализирует объект с помощью строк
        /// </summary>
        /// <param name="amount">Сумма записи</param>
        /// <param name="date">Дата записи</param>
        public void InitWithString(string amount, string date)
        {
            Double.TryParse(amount, out _amount);

            DateTime dt;
            DateTime.TryParse(date, out dt);
            EntryDate = dt;
        }
                
        public override string ToString()
        {
            return string.Format("{0} от {1}", _amount, EntryDate.Date);
        }


        /// <summary>
        /// Определяет, является ли запись доходом
        /// </summary>
        public bool IsDebit
        {
            get
            {
                return (_amount >= 0);
            }

            set
            {
                if (value && _amount < 0)
                    _amount = -_amount;
            }
        }
            

        /// <summary>
        /// Сумма записи
        /// </summary>
        public double amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime EntryDate { get; set; }
    }
}
