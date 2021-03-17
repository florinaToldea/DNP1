using System.ComponentModel.DataAnnotations;

namespace Models {
    public class Person {
    
        [Range(1, int.MaxValue, ErrorMessage ="Please enter a value bigger than{1}")]
        public int Id { get; set; }
        
        [Range(0, 100)]
        public string FirstName { get; set; }
        
        [Range(0, 100)]
        public string LastName { get; set; }
        
        [Range(0, 100)]
        public string HairColor { get; set; }
        
        [Range(0, 100)]
        public string EyeColor { get; set; }
        
        [Range(1, int.MaxValue, ErrorMessage ="Please enter a value bigger than{1}")]
        public int Age { get; set; }
        
        [Range(1, int.MaxValue, ErrorMessage ="Please enter a value bigger than{1}")]
        public float Weight { get; set; }
        
        [Range(1, int.MaxValue, ErrorMessage ="Please enter a value bigger than{1}")]
        public int Height { get; set; }
        public string Sex { get; set; }
    }


}