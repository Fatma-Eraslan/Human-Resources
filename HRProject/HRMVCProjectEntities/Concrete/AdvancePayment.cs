using Core.Entities;
using HRMVCProjectEntities.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVCProjectEntities.Concrete
{
    public class AdvancePayment:BaseEntity
    {
        [Display(Name ="Açıklama")]
        [StringLength(250, MinimumLength = 10, ErrorMessage = "10 karakterden az, 250 karakterden fazla giremezsiniz.")]
        [Required(ErrorMessage ="Lütfen açıklama giriniz")]
        public string Description { get; set; }
        [Display(Name = "Tutar")]
        [Required(ErrorMessage = "Lütfen tutar giriniz")]
        public double Amount { get; set; }
        [Display(Name = "Talep Tarihi")]
        public DateTime RequestDate { get; set; } = DateTime.Now;
        [Display(Name = "Cevaplanma Tarihi")]
        public DateTime ReplyDate { get; set; }
        [Display(Name = "Onay Durumu")]
        public ReplyState ReplyState { get; set; }

        public int EmployeeId { get; set; }    
        public Employee Employee { get; set; }    
    }
}
