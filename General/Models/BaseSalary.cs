using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace General.Models
{
    public class BaseSalary
    {
        #region Ctor
        //سازنده پیش فرض
        public BaseSalary()
        {

        }
        #endregion
        #region Props
        [Key]
        public int ID { get; set; }
        public int YearID { get; set; }
        /// <summary>
        /// ارتباط یک به یک با جدول سال
        /// </summary>
        [Required(ErrorMessage = "سال را وارد نمایید")]
        [DisplayName("سال")]
        public Models.Utilities.Year Year { get; set; }
        public int SalaryID { get; set; }
        /// <summary>
        /// ارتباط یک به یک با جدول حقوق
        /// </summary>
        [Required(ErrorMessage = "سال را وارد نمایید")]
        [DisplayName("سال")]
        public Models.Salary Salary { get; set; }
        [Required(ErrorMessage ="پایه حقوق یک روز را وارد نمایید")]
        [DisplayName("پایه حقوق یک روز")]
        [DisplayFormat(ApplyFormatInEditMode =false,DataFormatString ="{0:#,##0 ريال}")]
        public double BaseSalaryDaily { get; set; }
        [Required(ErrorMessage = "حق مسکن را وارد نمایید")]
        [DisplayName("حق مسکن")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        public double HomeSalary { get; set; }
        [Required(ErrorMessage = "حق ایاب و ذهاب را وارد نمایید")]
        [DisplayName("حق ایاب و ذهاب")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        public double NovSalary { get; set; }
        [Required(ErrorMessage = "حق بن کارگری را وارد نمایید")]
        [DisplayName("حق بن کارگری")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        public double BonSalary { get; set; }
        [Required(ErrorMessage = "مبلغ اضافه کار ساعتی را وارد نمایید")]
        [DisplayName("مبلغ اضافه کار ساعتی")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        public double EzafehTimeSalary { get; set; }
        [Required(ErrorMessage = "حق مرخصی را وارد نمایید")]
        [DisplayName("حق مرخصی")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        public double RestSalary { get; set; }
        [Required(ErrorMessage = "کسر مرخصی را وارد نمایید")]
        [DisplayName("کسر مرخصی")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        public double KasrGheybat { get; set; }
        [Required(ErrorMessage = "مبلغ سفته را وارد نمایید")]
        [DisplayName("مبلغ سفته")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        public double SaftePrice { get; set; }
        //جهت تعریف انواع حقوق از پایه تا کارشناسی و مدیریت
        [Required(ErrorMessage = "سطح درآمد را وارد نمایید")]
        [DisplayName("سطح درآمد")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        public string LevelPrice { get; set; }
        #endregion
    }
}