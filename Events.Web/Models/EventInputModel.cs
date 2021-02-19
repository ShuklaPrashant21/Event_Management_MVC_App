using Events.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Events.Web.Models
{
    public class EventInputModel
    {
        [Required(ErrorMessage = "Event title is required.")]
        [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters long.", MinimumLength = 1)]
        [Display(Name = "Title *")]
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date and Time *")]
        public DateTime StartDateTime { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Location *")]
        public string Location { get; set; }

        public TimeSpan? Duration { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [MaxLength(500)]
        public string OtherDetails { get; set; }

        [Display(Name = "Is Public?")]
        public bool IsPublic { get; set; }

        public static EventInputModel CreateFromEvent(Event e)
        {
            return new EventInputModel()
            {
                Title = e.Title,
                StartDateTime = e.StartDateTime,
                Duration = e.Duration,
                Location = e.Location,
                Description = e.Description,
                OtherDetails = e.OtherDetails,
                IsPublic = e.IsPublic
            };
        }

    }
}