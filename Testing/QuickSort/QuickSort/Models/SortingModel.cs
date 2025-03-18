using System.ComponentModel.DataAnnotations;

namespace QuickSort.Models
{
    public class SortingModel
    {
        [Required(ErrorMessage = "Please enter numbers to sort")]
        [Display(Name = "Numbers (comma separated)")]
        public string Numbers { get; set; }

        [Required(ErrorMessage = "Please select a sorting algorithm")]
        [Display(Name = "Sorting Algorithm")]
        public string Algorithm { get; set; }
    }
}
