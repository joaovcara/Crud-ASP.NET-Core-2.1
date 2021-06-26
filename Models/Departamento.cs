using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VendasWebMVC.Models
{
    public class Departamento
    {
        #region Propriedades
        [Key]
        public int IdDepartamento { get; set; }
        public string Descricao { get; set; }
        #endregion

    }
}
