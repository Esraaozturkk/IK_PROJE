using System.ComponentModel.DataAnnotations;

namespace IK_PROJE.MVC.Models.VMs
{
    public class JobPostVM
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [MinLength(3, ErrorMessage = "En az 3 karakter olmalıdır")]
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter olmalıdır")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [MinLength(3, ErrorMessage = "En az 3 karakter olmalıdır")]
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter olmalıdır")]
        public string Description { get; set; }

       
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [MinLength(3, ErrorMessage = "En az 3 karakter olmalıdır")]
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter olmalıdır")]
        public string Requirements { get; set; }
       
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; } 



    }

}