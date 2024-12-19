using System.ComponentModel.DataAnnotations;

namespace İKProjesi.Models.VMs
{
    public class CreateVM
    {
        
        public string Title { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }
        public int Salary { get; set; }
    }
}
