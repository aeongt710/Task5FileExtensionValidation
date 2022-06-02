using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using Task5FileExtensionValidation.Models.ValidationAttributes;

namespace Task5FileExtensionValidation.Models
{
    public class FileVM
    {
        [Required]
        [FileExtens(".txt", ".docx")]
        [Display(Name = "Single File Upload")]
        public IFormFile SingleFile { get; set; }


        [Required]
        [FileExtens(".txt", ".docx")]
        [Display(Name = "Multiple File Upload")]
        public IFormFile[] MultipleFiles { get; set; }
    }
}
