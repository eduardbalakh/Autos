using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Autos.Data.Models
{
    public class Auto
    {
        public int? Id { get; set; }
        [Display(Name = "Название авто (марка)")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина имени должна быть не менее 5 символов")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Desc { get; set; }
        [Display(Name = "Путь к картинке в формате /img/*.jpg")]
        public string Image { get; set; }
        [Display(Name = "Номер машины формата А000АА111")]
        [StringLength(9)]
        [Required(ErrorMessage = "Длина имени должна быть не менее 8 символов")]
        public string Number { get; set; }
        public string AutoColour { get; set; }
        [Display(Name = "Год выпуска авто")]
        public ushort Year { get; set; }



    }
}
