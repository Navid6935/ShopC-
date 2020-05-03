using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace General.Models
{
    public class Company
    {
        #region CTOR
        public Company()
        {

        }
        #endregion
        #region Props
        //DatabaseGeneratedOption جهت آیدنتیتی نشدن 
        [Key,Required(ErrorMessage ="لطفاً آی دی را وارد نمایید"),
            DatabaseGenerated(DatabaseGeneratedOption.None)
            ,DisplayName("آی دی شرکت")]
        public int Id { get; set; }
        [Required(ErrorMessage = "لطفاً نام شرکت را وارد نمایید"),
            MaxLength(100),Column("CompanyName"
            ,TypeName ="NvarChar")
            , DisplayName("نام شرکت")]
        public string Title { get; set; }
        [Required(ErrorMessage = "لطفاً نام دسته بندی محصول را وارد نمایید"),
    MaxLength(100), Column("Category"
    , TypeName = "NvarChar")
    , DisplayName("نام دسته بندی محصول")]
        public string Category { get; set; }
            [DisplayName("نام و فعالیت شرکت")]
        public string DisplayName { get { string strResult = string.Format("{0}-{1}-{2}", Id, Title, Category);return strResult; } }
        #endregion
        #region Relations
        public virtual IList<Contact> Contact { get; set; }
        #endregion
    }
}