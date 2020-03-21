using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace General.Models
{
    public class Salary
    {
        #region CTOR
        //سازنده پیش فرض
        public Salary()
        {

        }
        #endregion
        #region Props
        [Key]
        public Guid ID { get; set; }

        [Required(ErrorMessage = "تعداد ساعت اضافه کار را وارد نمایید")]
        [DisplayName("تعداد ساعت  اضافه کار")]
        [TypeConverter("smallint")]
        public int EzafeKar { get; set; }
        [Required(ErrorMessage = "تعداد روز کاری را وارد نمایید")]
        [DisplayName("روز کاری ")]
        [TypeConverter("smallint")]
        public int WorkDay { get; set; }
        [Required(ErrorMessage = "تعداد روز کاری فعال را وارد نمایید")]
        [DisplayName("روز کاری فعال ")]
        [TypeConverter("smallint")]
        public int ActiveWorkDay { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [Required(ErrorMessage = "مبلغ پاداش را وارد نمایید")]
        [DisplayName("پاداش")]
        public double Giftsalary { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [Required(ErrorMessage = "مبلغ مزایا را وارد نمایید")]
        [DisplayName("مبلغ مزایا")]
        public double RewardSalary { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [Required(ErrorMessage = "مبلغ مزایا را وارد نمایید")]
        [DisplayName("مبلغ مزایا")]
        public double Porsant { get; set; }
        [Required(ErrorMessage = "ساعت مرخصی را وارد نمایید")]
        [DisplayName("ساعت مرخصی")]
        public double RestTime { get; set; }
        [Required(ErrorMessage = "روز مرخصی را وارد نمایید")]
        [DisplayName("روز مرخصی")]
        public double RestDay { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [Required(ErrorMessage = "مبلغ مساعده را وارد نمایید")]
        [DisplayName("مبلغ مساعده")]
        public double HelpSalary { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [Required(ErrorMessage = "مبلغ جریمه را وارد نمایید")]
        [DisplayName("مبلغ جریمه")]
        public double PenaltySalary { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [Required(ErrorMessage = "مبلغ  سفته را وارد نمایید")]
        [DisplayName("مبلغ  سفته")]
        public double SaftehPrice { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [Required(ErrorMessage = "مبلغ بدهی سفته را وارد نمایید")]
        [DisplayName("مبلغ بدهی سفته")]
        public double SaftehBedehi { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [Required(ErrorMessage = "مبلغ بدهی را وارد نمایید")]
        [DisplayName("مبلغ بدهی")]
        public double Bedehi { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [Required(ErrorMessage = "بن کالا را وارد نمایید")]
        [DisplayName("بن کالا")]
        public double PBon { get; set; }
        [DisplayName("توضیحات")]
        public double Description { get; set; }
        #region Relation

        //جهت دسترسی به آی دی ماه
        //در ویو پاکش می کنیم
        public int MounthID { get; set; }
        /// <summary>
        /// ارتباط یک به چند با جدول ماه
        /// </summary>
        [Required(ErrorMessage = "ماه را وارد نمایید")]
        [DisplayName("ماه")]
        public Models.Utilities.Mounth Mounth { get; set; }
        public int PersonelID { get; set; }
        /// <summary>
        /// ارتباط یک به چند با جدول پرسنل
        /// </summary>
        [Required(ErrorMessage = "شماره پرسنلی را وارد نمایید")]
        [DisplayName("شماره پرسنل")]
        public Models.Personel Personel { get; set; }
        public int BaseSalaryID { get; set; }
        /// <summary>
        /// ارتباط یک به چند با جدول پایه حقوق
        /// </summary>
        [Required(ErrorMessage = "حقوق پایه را وارد نمایید")]
        [DisplayName("حقوق پایه")]
        public Models.BaseSalary BaseSalary { get; set; }

        #endregion Relation
        #region Calculator
        /// <summary>
        /// محاسبه پایه حقوق
        /// پایه حقوق یک روز در سال 94 مبلغ 2347475 ريال می باشد
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [DisplayName("پایه حقوق")]
        public double? CalcBaseSalary
        {
            get
            {
                double? dblResult = ((WorkDay * BaseSalary.BaseSalaryDaily));
                return dblResult;
            }
        }
        /// <summary>
        /// محاسبه ایاب و ذهاب
        /// 
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [DisplayName("ایاب و ذهاب")]
        public double? CalcNavSalary
        {
            get
            {
                double? dblResult = ((BaseSalary.NovSalary)*ActiveWorkDay);
                return dblResult;
            }
        }
        /// <summary>
        /// محاسبه مطالبات مرخصی
        /// 
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [DisplayName("مطالبات مرخصی")]
        public double? CalcMMorakhasi1
        {
            get
            {
                double? dblResult = ((BaseSalary.RestSalary -(RestDay*237474)-(237474/8*RestTime));
                return dblResult;
            }
        }
        /// <summary>
        /// محاسبه ایاب و ذهاب
        /// 
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [DisplayName("محاسبه اضافه کار")]
        public double? CalcEzafeKar1
        {
            get
            {
                double? dblResult = ((BaseSalary.EzafehTimeSalary) * EzafeKar);
                return dblResult;
            }
        }
        /// <summary>
        /// محاسبه حق مسکن
        /// 
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [DisplayName("محاسبه حق مسکن")]
        public double? CalcHomeSalary
        {
            get
            {
                double? dblResult = (BaseSalary.HomeSalary);
                return dblResult;
            }
        }
        /// <summary>
        /// محاسبه غیبت و کسر از حقوق
        /// 
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [DisplayName("محاسبه غیبت و کسر از حقوق")]
        public double? CalcGheibat
        {
            get
            {
                double? dblResult = ((WorkDay - ActiveWorkDay)*BaseSalary.KasrGheybat);
                return dblResult;
            }
        }
        /// <summary>
        /// مانده سفته
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [DisplayName("محاسبه مانده سفته")]
        public double? CalcMandehSafteh
        {
            get
            {
                double? dblResult = (SaftehPrice - SaftehBedehi);
                return dblResult;
            }
        }
        /// <summary>
        /// محاسبه کسورات
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [DisplayName("محاسبه کسورات")]
        public double? CalcKosorat
        {
            get
            {
                double? dblResult = (PBon + CalcGheibat + CalcMandehSafteh + PenaltySalary + HelpSalary);
                return dblResult;
            }
        }
        /// <summary>
        /// محاسبه کسورات
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        [DisplayName("محاسبه پرداخت ها")]
        public double? CalcPayments
        {
            get
            {
                double? dblResult = (Porsant  + Giftsalary + BaseSalary.BonSalary + CalcNavSalary + RewardSalary
                    + BaseSalary.HomeSalary + CalcBaseSalary + CalcEzafeKar1);
                return dblResult;
            }
        }
        #endregion
    }
#endregion

}