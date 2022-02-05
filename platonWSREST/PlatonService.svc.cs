using platonWSREST.Dominio;
using platonWSREST.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace platonWSREST
{
    [System.ServiceModel.ServiceBehavior(IncludeExceptionDetailInFaults =true)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PlatonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PlatonService.svc or PlatonService.svc.cs at the Solution Explorer and start debugging.
    public class PlatonService : IPlatonService
    {
        private platonEntities db = new platonEntities();
        public horario CrearHorario(horario horarioACrear)
        {
            db.horario.Add(horarioACrear);
            db.SaveChanges();
            horario horario = ObtenerHorario(horarioACrear.codhorario);
            return horario;
        }

        public void EliminarHorario(string codhorario)
        {
            horario horario = ObtenerHorario(codhorario);
            db.horario.Remove(horario);
            db.SaveChanges();
        }

        public List<ciclo> ListarCiclo()
        {
            return db.ciclo.ToList();
        }

        public List<curso> ListarCurso()
        {
            return db.curso.ToList();
        }

        public List<Horarios> ListarHorario()
        {
            var query = from a in db.horario
                        join b in db.ciclo on a.codciclo equals b.codciclo
                        join c in db.curso on a.codcurso equals c.codcurso
                        join d in db.seccion on a.codseccion equals d.codseccion
                        select new Horarios
                        {
                            id = a.id,
                            codhorario = a.codhorario,
                            codciclo = a.codciclo,
                            desciclo = b.desciclo,
                            codcurso = a.codcurso,
                            descurso = c.descurso,
                            codseccion = a.codseccion,
                            desseccion = d.desseccion,
                            finicio = a.finicio,
                            ffinal = a.ffinal,
                            estado = a.estado
                        };
            return query.ToList();

        }

        public List<seccion> ListarSeccion()
        {
            return db.seccion.ToList();
        }

        public horario ModificarHorario(horario horarioAModificar)
        {
            db.Entry(horarioAModificar).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            horario horario = ObtenerHorario(horarioAModificar.codhorario);
            return horario;

        }

        public horario ObtenerHorario(string codhorario)
        {
            var query = from horario in db.horario.Where(x => (x.codhorario == codhorario))
                        select horario;
            horario resultado = query.First();
            return resultado;

        }
    }
}
