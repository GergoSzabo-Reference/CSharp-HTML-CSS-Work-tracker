using System;
using System.ComponentModel.DataAnnotations;

namespace Autoszerelo_Shared
{
    public class Munka
    {
        public int MunkaId { get; set; }
        public int UgyfelId { get; set; }

        [Required(ErrorMessage = "A rendszám megadása kötelező.")]
        [RegularExpression(@"[A-Za-z][A-Za-z][A-Za-z]-\d\d\d")]
        public string Rendszam { get; set; }

        [Required(ErrorMessage = "A gyártási év megadása kötelező.")]
        [Range(1900, 2025, ErrorMessage = "A gyártási évnek 1900 és 2025 között kell lennie.")]
        public int GyartasiEv { get; set; }

        [Required(ErrorMessage = "A munka kategória megadása kötelező.")]
        public MunkaKategoria Kategoria { get; set; }

        [Required(ErrorMessage = "A hibaleírás megadása kötelező.")]
        [StringLength(1000, ErrorMessage = "A hibaleírás legfeljebb 1000 karakterből állhat.")]
        public string HibaLeiras { get; set; }

        [Required(ErrorMessage = "A hiba súlyosságának megadása kötleező.")]
        [Range(1, 10, ErrorMessage = "A hiba súlyossága 1 és 10 közötti érték lehet.")]
        public int HibaSulyossaga { get; set; }

        [Required(ErrorMessage = "A munka állapot megadása kötelező.")]
        public MunkaAllapot Allapot { get; set; }
    }
}
