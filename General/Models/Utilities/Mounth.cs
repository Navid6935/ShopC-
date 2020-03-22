using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace General.Models.Utilities
{
    public class Mounth
    {
        #region Ctor
        public Mounth()
        {

        }
        #endregion
        #region Props
        public int ID { get; set; }
        public string Mounths { get; set; }
        /// <summary>
        /// ارتباط یک به چند با جدول حقوق
        /// </summary>
        public virtual System.Collections.Generic.IList<Salary> Salaries { get; set; }
        #endregion
    }
}