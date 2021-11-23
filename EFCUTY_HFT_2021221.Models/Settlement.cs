﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCUTY_HFT_2021221.Models
{
    [Table("Settlements")]
    public class Settlement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SettlementID { get; set; }

        public string SettlementName { get; set; }

        public int Population { get; set; }

        public double HDI { get; set; }

        [NotMapped]
        public virtual Country Country { get; set; }

        [NotMapped]
        public virtual ICollection<Citizen> Citizens { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryID { get; set; }
    }
}
