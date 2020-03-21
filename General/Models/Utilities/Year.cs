using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace General.Models.Utilities
{
    public class Year
    {
        #region Ctor
        public Year()
        {

        }
        #endregion
        #region Props
        public int ID { get; set; }
        public string Years { get; set; }
        public int BaseSalaryID { get; set; }
        /// <summary>
        /// ارتباط یک به چند با کلاس پایه حقوق
        /// برای هر رده کاری یک پایه حقوق داریم
        /// </summary>
        public virtual System.Collections.Generic.IList<BaseSalary> BaseSalaries  { get; set; }
        #endregion
    }
}