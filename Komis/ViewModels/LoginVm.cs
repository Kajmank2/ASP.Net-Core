using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.ViewModels
{
    public class LoginVm //View Model dane tylko dla widoku Nie ma sensu Upgradeować całej databbasy gdyz jest nam to porzebne tylko dla widowku
    {
        [Required]
        [Display(Name= "Nazwa użytkownika")]
        public string UserName { get; set; }
        [Required]
        [Display(Name="Haslo")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
