using System.ComponentModel.DataAnnotations;//para usar [Required] y otras anotaciones

namespace Repaso.pagina.Models.Data.Models
{
    public class ViewModelClientes
    {
        //required para que no acepte nulos
        [Key] // primary key  
        [Required,StringLength(50)]
        public string id_cliente { get; set; }
        [Required,StringLength(50)]
        public string nombre_cliente { get; set; }
        [Required,StringLength(50)]
        public string id_mesero { get; set; }   

    }
}
