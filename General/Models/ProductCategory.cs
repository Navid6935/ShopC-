using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace General.Models
{
    public class ProductCategory
    {
        #region Ctors
        public ProductCategory()
        {

        }
        #endregion
        #region Props
        //DatabaseGeneratedOption جهت آیدنتیتی نشدن 
        [Key, Required(ErrorMessage = "لطفاً آی دی را وارد نمایید"),
            DatabaseGenerated(DatabaseGeneratedOption.None)
            , DisplayName("آی دی گروه محصول")]
        public int Id { get; set; }
        [Required(ErrorMessage = "لطفاً نام گروه محصول را وارد نمایید"),
            MaxLength(100), Column("CompanyName"
            , TypeName = "NvarChar")
            , DisplayName("نام گروه محصول")]
        public string Title { get; set; }
        #endregion
        #region Relations

        #endregion

    }
}