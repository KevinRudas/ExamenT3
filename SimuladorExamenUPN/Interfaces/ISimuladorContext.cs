using SimuladorExamenUPN.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorExamenUPN.Interfaces
{
   public  interface ISimuladorContext
    {
        IDbSet<Tema> Temas { get; set; }
        IDbSet<Pregunta> Preguntas { get; set; }
        IDbSet<Alternativa> Alternativas { get; set; }

      IDbSet<Categoria> Categorias { get; set; }

        IDbSet<Examen> Examenes { get; set; }
       IDbSet<ExamenPregunta> ExamenPreguntas { get; set; }
        IDbSet<TemaCategoria> TemaCategorias { get; set; }

        IDbSet<Usuario> Usuarios { get; set; }
        int SaveChanges();
    }
}
