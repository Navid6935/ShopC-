using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace General.Models
{
    public class CustomerType
    {
        #region Ctor
        public CustomerType()
        {

        }
        #endregion
        #region Props
        //DatabaseGeneratedOption جهت آیدنتیتی نشدن 
        [Key, Required(ErrorMessage = "لطفاً آی دی دسته بندی خریداران را وارد نمایید"),
            DatabaseGenerated(DatabaseGeneratedOption.None)
            , DisplayName(" آی دی دسته بندی خریداران")]
        public int Id { get; set; }
        [Required(ErrorMessage = "لطفاً نام  دسته بندی خریدار را وارد نمایید"),
            MaxLength(100), Column("Name"
            , TypeName = "NvarChar")
            , DisplayName("نام  دسته بندی خریدار")]
        public string Title { get; set; }
        [Required(ErrorMessage = "لطفاً توضیحات را وارد نمایید"),
    MaxLength(100), Column("Description"
    , TypeName = "NvarChar")
    , DisplayName("توضیحات")]
        public string Description { get; set; }
        [DisplayName("نام و آی دی")]
        public string DisplayName { get { string strResult = string.Format("{0}-{1}", Id, Title); return strResult; } }
        #endregion
        #region Relations
        public virtual IList<Customer> Customers { get; set; }
        #endregion
    }
}