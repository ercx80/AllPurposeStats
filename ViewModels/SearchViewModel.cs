using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AllPurposeStats.Models;

namespace AllPurposeStats.ViewModels
{
    public class SearchViewModel
    {
        [Required]
        [Display(Name ="Name of Player")]
        public string Name { get; set; }
        public PlayerPosition Position { get; set; }
        

    }
}
