using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EconomiaDomestica.Models
{
    public class Registro
    {

        private int Id_Registro;
        private string Fecha;
        private string Concepto;
        private int Importe;

        [DisplayName("Id Registro")]
        public int IdRegistro {
            get => Id_Registro;
            set => Id_Registro = value;
        }

        [DisplayName("Fecha")]
        [Required(ErrorMessage ="La fecha es requerida.")]
        [StringLength(10, ErrorMessage ="EL formarto fecha es dd\\mm\\aaaa")]
        public string FechaRegistro {
            get => Fecha;
            set => Fecha = value;
        }

        [DisplayName("Concepto")]
        [Required(ErrorMessage = "El concepto es requerido.")]
        [StringLength(100)]
        public string ConceptoRegistro {
            get => Concepto;
            set => Concepto = value;
        }

        [DisplayName("Regsitro")]
        [Required(ErrorMessage = "El registro es requerido.")]
        [StringLength(10, ErrorMessage = "EL formarto es nn.nnn,nn")]
        public int ImporteRegistro {
            get => Importe;
            set => Importe = value;
        }
    }
}
