using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace General.Models
{
    public class Customer
    {
        #region Ctor
        public Customer()
        {

        }
        #endregion
        #region Props
        //DatabaseGeneratedOption جهت آیدنتیتی نشدن 
        [Key, Required(ErrorMessage = "لطفاً آی دی خریداران را وارد نمایید"),
            DatabaseGenerated(DatabaseGeneratedOption.None)
            , DisplayName(" آی دی  خریداران")]
        public int Id { get; set; }
        [Required(ErrorMessage = "لطفاً نام   خریدار را وارد نمایید"),
            MaxLength(100), Column("Name"
            , TypeName = "NvarChar")    
            , DisplayName("نام   خریدار")]
        public string Title { get; set; } 
        [Required(ErrorMessage = "لطفاً توضیحات را وارد نمایید"),
    MaxLength(100), Column("Description"
    , TypeName = "NvarChar")
    , DisplayName("توضیحات")]
        public string Description { get; set; }
        [DisplayName(" نام و آی دی خریداران")]
        public string DisplayName { get { string strResult = string.Format("{0}-{1}", Id, Title); return strResult; } }
        #endregion
        #region Relations
        //دسته بندی خریداران
        public int CustomerTypeId { get; set; }
        public virtual CustomerType CustomerType { get; set; }
        //ارتباط یک به چند با کلاس کانتکت
        [DisplayName("اطلاعات تماس")]
        public virtual IList<Contact> Contact { get; set; }
        #endregion
        #region Configuration
        internal class Configuraion : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Customer>
        {
            public Configuraion()
            {
                //جهت کلاس CustomerTypeId   
                HasRequired(c => c.CustomerType)
                    .WithMany(ct => ct.Customers)
                    .HasForeignKey(c => c.CustomerTypeId)
                    .WillCascadeOnDelete(false);
            }
        }
        #endregion
    }
}