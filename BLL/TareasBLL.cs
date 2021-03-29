using Gestion_de_Pasantes.DAL;
using Gestion_de_Pasantes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Pasantes.BLL
{
    public class TareasBLL
    {
        public static bool Guardar(Tareas tareas)
        {
            if (!Existe(tareas.TareaId))
                return Insertar(tareas);
            else
                return Modificar(tareas);
        }

        private static bool Insertar(Tareas tareas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Tareas.Add(tareas);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Tareas tareas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(tareas).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var tareas = contexto.Tareas.Find(id);
                if (tareas != null)
                {
                    contexto.Tareas.Remove(tareas);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Tareas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Tareas tareas;
            try
            {
                tareas = contexto.Tareas.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tareas;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Tareas.Any(e => e.TareaId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static List<Tareas> GetList(Expression<Func<Tareas, bool>> criterio)
        {
            List<Tareas> lista = new List<Tareas>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Tareas.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
