using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public class Opinia
    {
        [BindNever]
        public int ID { get; set; }
        [Required(ErrorMessage ="Wprowadz Nazwe gdyz jest wymagana ")]
        [StringLength(100,ErrorMessage ="Za długa nazwa uzytkownika")]
        public string NazwaUzytkownika { get; set; }
        [DataType(DataType.EmailAddress)]
        //[RegularExpression] jakies znaczki dla maila
        public string Email { get; set; }
        public string Wiadmosc { get; set; }
        public bool OczekujeOdpowiedzi { get; set; }
    }
}
