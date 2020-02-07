using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AllPurposeStats.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AllPurposeStats.ViewModels
{
    public class SearchViewModel
    {
        [Required(ErrorMessage = "You must enter a player's name")]
        [Display(Name = "Name of Player")]
        public string Name { get; set; }
        public PlayerPosition Position { get; set; }

        public StatCategory Category { get; set; }
        public Week WeekOf { get; set; }
        public List<SelectListItem> Categories { get; set; }//this property puts the choices for my dropdown items in a list
        public List<SelectListItem> Positions { get; set; }
        public List<SelectListItem> Weeks { get; set; }
        public SearchViewModel()
        {//this constructor will populate the list at runtime
            Categories = new List<SelectListItem>();//empty list is initialized
            Positions = new List<SelectListItem>();
            Weeks = new List<SelectListItem>();
            Categories.Add(new SelectListItem
            {
                Value = ((int)StatCategory.Yards).ToString(),
                Text = StatCategory.Yards.ToString()
            });
            Categories.Add(new SelectListItem
            {
                Value = ((int)StatCategory.Turnovers).ToString(),
                Text = StatCategory.Turnovers.ToString()
            });
            Categories.Add(new SelectListItem
            {
                Value = ((int)StatCategory.Touchdowns).ToString(),
                Text = StatCategory.Touchdowns.ToString()
            });
            Positions.Add(new SelectListItem
            {
                Value = ((int)PlayerPosition.QB).ToString(),
                Text = PlayerPosition.QB.ToString()

            });
            Positions.Add(new SelectListItem
            {
                Value = ((int)PlayerPosition.RB).ToString(),
                Text = PlayerPosition.RB.ToString()

            });
            Positions.Add(new SelectListItem
            {
                Value = ((int)PlayerPosition.TE).ToString(),
                Text = PlayerPosition.TE.ToString()

            });
            Positions.Add(new SelectListItem
            {
                Value = ((int)PlayerPosition.WR).ToString(),
                Text = PlayerPosition.WR.ToString()

            });
            Weeks.Add(new SelectListItem
            {
                Value = ((int)Week.One).ToString(),
                Text = Week.Two.ToString()

            });
            Weeks.Add(new SelectListItem
            {
                Value = ((int)Week.Two).ToString(),
                Text = Week.Two.ToString()

            });
            Weeks.Add(new SelectListItem
            {
                Value = ((int)Week.Three).ToString(),
                Text = Week.Three.ToString()

            });
            Weeks.Add(new SelectListItem
            {
                Value = ((int)Week.Four).ToString(),
                Text = Week.Four.ToString()

            });
            Weeks.Add(new SelectListItem
            {
                Value = ((int)Week.Five).ToString(),
                Text = Week.Five.ToString()

            });
           







        }
    }
}
