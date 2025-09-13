using System.ComponentModel.DataAnnotations;//para usar [Required] y otras anotaciones

namespace Repaso.pagina.Models.Data.Models
{
    public class ViewModelMeseros
    {
        //required para que no acepte nulos
        [Key] // primary key  
        [Required,StringLength(50)]
        public string id_mesero { get; set; }
        [Required,StringLength(50)]
        public string nombre_mesero { get; set; }
        [Required,StringLength(50)]
        public string apellido_mesero { get; set; }
    }
}
