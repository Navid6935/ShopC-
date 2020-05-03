using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace General.Models
{
    public class Contact
    {
        #region Ctor
        public Contact()
        {

        }
        #endregion
        #region Props
        //DatabaseGeneratedOption جهت آیدنتیتی نشدن 
        [Key, Required(ErrorMessage = "لطفاً آی دی  مشخصات تماس را وارد نمایید"),
            DatabaseGenerated(DatabaseGeneratedOption.None)
            , DisplayName(" آی دی  مشخصات تماس")]
        public int Id { get; set; }
        [Required(ErrorMessage = "لطفاً نام   کشور را وارد نمایید"),
            MaxLength(100), Column("Name1"
            , TypeName = "NvarChar"), DisplayName("نام   کشور")]
        public string Country { get; set; }
        [Required(ErrorMessage = "لطفاً نام استان را وارد نمایید"),
         MaxLength(100), Column("Name2"
         , TypeName = "NvarChar"), DisplayName("نام   استان")]
        public string State { get; set; }
        [Required(ErrorMessage = "لطفاً نام شهر را وارد نمایید"),
         MaxLength(100), Column("Name"
         , TypeName = "NvarChar"), DisplayName("نام شهر")]
        public string City { get; set; }
        [Required(ErrorMessage = "لطفاً آدرس را وارد نمایید"),
    MaxLength(1000), Column("Description", TypeName = "NvarChar")
    , DisplayName("آدرس")]
        public string Address { get; set; }
        [Required(ErrorMessage = "لطفاً تلفن ثابت را وارد نمایید"),
        MaxLength(14), Column("Description", TypeName = "NvarChar")
        , DisplayName("تلفن ثابت")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "لطفاً تلفن همراه را وارد نمایید"),
        MaxLength(14), Column("Description", TypeName = "NvarChar")
        , DisplayName("تلفن همراه")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "لطفاً فکس را وارد نمایید"),
        MaxLength(1000), Column("Description", TypeName = "NvarChar")
        , DisplayName("فکس")]
        public string Fax { get; set; }
        [Required(ErrorMessage = "لطفاً ایمیل را وارد نمایید"),
        MaxLength(1000), Column("Description", TypeName = "NvarChar")
        , DisplayName("ایمیل")]
        public string Email { get; set; }

        #endregion
        #region Relation
        [DisplayName("آی دی خریداران")]
        public int CustomerID { get; set; }
        [DisplayName("خریداران")]
        public virtual Customer Customer { get; set; }
        [DisplayName("آی دی شرکت")]
        public int CompanyId { get; set; }
        [DisplayName("شرکت")]
        public virtual Company Company { get; set; }
        #endregion
        #region Configuration
        //internal class Configuraion : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Customer>
        //{
        //    public Configuraion()
        //    {
        //        //جهت کلاس Contact
        //        HasRequired(c => c.Company)
        //            .WithMany(ct => ct.con)
        //            .HasForeignKey(c => c.CustomerTypeId)
        //            .WillCascadeOnDelete(false);
        //    }
        //}
        #endregion
    }
}