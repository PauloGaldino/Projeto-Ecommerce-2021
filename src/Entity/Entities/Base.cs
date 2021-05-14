using Entity.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Entity.Entities
{
    /// <summary>
    /// Classe repons´´avel por 
    /// propiedades genéircas
    /// </summary>

    public class Base : Notifiers
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

    }
}
