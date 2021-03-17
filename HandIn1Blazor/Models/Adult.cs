using System.ComponentModel.DataAnnotations;
using Models;

namespace HandIn1Blazor.Models
{
    public class Adult : Person
    {
    [Range(1, int.MaxValue, ErrorMessage ="Please enter a value bigger than{1}")]
        public string JobTitle { get; set; }
       
       
    }
}