using System.ComponentModel.DataAnnotations;//para usar [Required] y otras anotaciones

namespace Repaso.pagina.Models.Data.Models
{
    public class BaseEntity
    {
        //required para que no acepte nulos
        [Key] // primary key  
        [Required]  
        public string id { get; set; } 
        public string name { get; set; }


    }
}
