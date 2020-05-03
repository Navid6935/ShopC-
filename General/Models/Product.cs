using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace General.Models
{
    public class Product
    {
        #region Ctors
        public Product()
        {

        }
        #endregion
        #region Props
        //DatabaseGeneratedOption جهت آیدنتیتی نشدن 
        [Key, Required(ErrorMessage = "لطفاً آی دی محصولات را وارد نمایید"),
            DatabaseGenerated(DatabaseGeneratedOption.None)
            , DisplayName(" آی دی  محصولات")]
        public int Id { get; set; }
        [Required(ErrorMessage = "لطفاً بارکد را وارد نمایید"),
    MaxLength(13)
    , DisplayName("بارکد")]
        public Int64 Barcode { get; set; }
        [Required(ErrorMessage = "لطفاً نام   محصول را وارد نمایید"),
    MaxLength(100), Column("Name"
    , TypeName = "NvarChar")
    , DisplayName("نام   محصول")]
        public string Title { get; set; }
        [Required(ErrorMessage = "لطفاً وزن محصول را وارد نمایید")
        , DisplayName("وزن محصول")]
        public int Weight { get; set; }
        [Required(ErrorMessage = "لطفاً تعداد محصول را وارد نمایید")
        , DisplayName("تعداد   محصول")]
        public int CountNumber { get; set; }
        #endregion
        #region Relations

        #endregion
        #region Configurations

        #endregion
    }
}