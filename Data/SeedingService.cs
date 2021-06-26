using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;

namespace VendasWebMVC.Data
{
    public class SeedingService
    {
        #region Propriedades
        //Registrar dependencia com o contexto
        private VendasWebMVCContext _contexto;
        #endregion


        #region Construtor
        public SeedingService (VendasWebMVCContext contexto)
        {
            _contexto = contexto;
        }
        #endregion


        #region Seed
        //Metodo responsável por popular a base de dados
        //Pode ser utilizado para popular tabelas padrões posteriormente
        public void Seed()
        {
            //Verifica as tabelas que necessitam ser populadas
            if (_contexto.Departamento.Any())
            {
                return; //se estiverem populadas para execução
            }

            Departamento d1 = new Departamento();

            //não terminei o seeding pois a aula esta fora de ordem.
            //qualquer coisa retorno depois e implemento ela

        }
        #endregion


    }
}