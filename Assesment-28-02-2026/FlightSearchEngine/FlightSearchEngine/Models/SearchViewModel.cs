using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FlightSearchEngine.Models
{
    public class SearchViewModel
    {
        [Required(ErrorMessage = "Please enter a Source.")]
        public string Source { get; set; } =string.Empty;
        [Required(ErrorMessage = "Please enter a Destination.")]
        public string Destination { get; set; }= string.Empty;
        [Required(ErrorMessage = "Mandatory number of passengers.")]
        [Range(1,100, ErrorMessage = "Number of passengers must be between 1 and 100.")]
        public int NumberOfPersons { get; set; }
        List<SelectList> SourceList { get; set; } = new();
        List<SelectList> DestinationList { get; set; } = new();

    }
}
