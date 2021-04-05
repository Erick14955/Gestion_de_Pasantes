using Gestion_de_Pasantes.DAL;
using Gestion_de_Pasantes.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Pasantes.BLL
{
    public class HabilidadesBLL
    {
        public static bool ExisteNombre(string Nombre)
        {
            Contexto contexto = new Contexto();
            bool paso;

            try
            {
                paso = contexto.Habilidades.Any(e => e.Nombre.Equals(Nombre));
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
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                paso = contexto.Habilidades.Any(e => e.HabilidadId == id);
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
        private static bool Insertar(Habilidades habilidad)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Add(habilidad);
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

        private static bool Modificar(Habilidades habilidad)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(habilidad).State = EntityState.Modified;
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

        public static bool Guardar(Habilidades HabilidadId)
        {
            if (!Existe(HabilidadId.HabilidadId))
                return Insertar(HabilidadId);
            else
                return Modificar(HabilidadId);
        }

        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var HabilidadId = contexto.Habilidades.Find(id);
                if (HabilidadId != null)
                {
                    contexto.Entry(HabilidadId).State = EntityState.Deleted;
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

        public static Habilidades Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Habilidades habilidad;
            try
            {
                habilidad = contexto.Habilidades.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return habilidad;
        }

        public static List<Habilidades> GetHabilidades()
        {
            Contexto contexto = new Contexto();
            List<Habilidades> lista = new List<Habilidades>();

            try
            {
                lista = contexto.Habilidades.ToList();

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
        public static List<Habilidades> GetList(Expression<Func<Habilidades, bool>> criterio)
        {
            Contexto contexto = new Contexto();
            List<Habilidades> lista = new List<Habilidades>();

            try
            {
                lista = contexto.Habilidades.Where(criterio).ToList();
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
