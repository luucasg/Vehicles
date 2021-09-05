﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Data.Entities
{
    public class History
    {
        public int Id { get; set; }

        [Display(Name = "Vehículo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Vehicle Vehicle { get; set; }

        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime Date { get; set; }

        //[Display(Name = "Fecha")]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        //public DateTime DateLocal => Date.ToLocalTime();

        [Display(Name = "Kilometraje")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int Mileage { get; set; }

        [Display(Name = "Observación")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

    }
}