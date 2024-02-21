using System.ComponentModel.DataAnnotations;

namespace Technical_Task.Models
{
    public class TextBoxModel
    {
        public int Id { get; set; }

        [Display(Name = "Input Number")]
        public int InputNumber { get; set; }

        [Display(Name = "Is Selected")]
        public bool IsSelected { get; set; }
    }
}
