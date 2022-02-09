using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Domain.Model.Entity
{
    public class Contact:BaseEntity
    {
        [Required] // bos ola bilmez not null  bularin name Annotations adlanir
        public string Name { get; set; }

        [Required]
        [EmailAddress] // ancaq email yaza bilsiner  amma database dusmur front yoxlanilir

        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Content { get; set; }

        public string Answer { get; set; } // kim terefinden cvb verilib

        public DateTime? AnswerdData { get; set; } // kim terefinden ne vaxt cvb verilib

        public int? AnswerByUserId { get; set; } // hansi id terefinden  kim terefinden cvb veriib
    }
}
