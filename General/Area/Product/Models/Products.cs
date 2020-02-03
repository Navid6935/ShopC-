using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace General.Area.Product.Models
{
    public class Products
    {
        #region Ctor
        public Products()
        {

        }
        /// <summary>
        /// سازنده با دو ورودی
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="name"></param>
        public Products(int pid,string name)
        {
            this.PId = pid;
            this.Name = name;
        }
        #endregion
        #region Props
        [Key]
        public int PId { get; set; }

        public string Name { get; set; }
        #endregion
        #region Relation

        #endregion
    }
}