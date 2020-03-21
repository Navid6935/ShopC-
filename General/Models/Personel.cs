using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace General.Models
{
    public class Personel
    {
        #region CTOR
        //سازنده پیش فرض
        public Personel()
        {

        }
        #endregion
        #region Props
        //تعریف پراپرتی ها
        [Key]
        [Required]
        [DisplayName("شماره")]
        public int Id { get; set; }
        [DisplayName("شماره پرسنلی")]
        public int PId { get; set; }
        [DisplayName("کد ملی")]
        public int NId { get; set; }
        [Required(ErrorMessage = "نام و نام خانوادگی را وارد نمایید")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        [TypeConverter("Nvarchar(121)")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "رایانامه را وارد نمایید")]
        [TypeConverter("Nvarchar(121)")]
        [DisplayName("رایانامه")]
        [StringLength(100, ErrorMessage = "این فیلد باید حداکثر 100 کاراکتر باشد")]
        public string Email { get; set; }
        [Required(ErrorMessage = "تاریخ تولد را وارد نمایید")]
        [DisplayName("تاریخ تولد")]
        public Nullable<System.DateTime> BirthDate { get; set; }
        [Required(ErrorMessage = "موبایل را وارد نمایید")]
        [StringLength(100, ErrorMessage = "این فیلد باید حداکثر 100 کاراکتر باشد")]
        [DisplayName("موبایل")]
        public string Mobile { get; set; }

        public string BankID { get; set; }

        #endregion

    }
}