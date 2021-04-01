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
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM HabilidadesDetalle where HabilidadId={habilidad.HabilidadId}");
                foreach (var anterior in habilidad.Detalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }
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
                habilidad = contexto.Habilidades.Include(e => e.Detalle).Where(p => p.HabilidadId == id).SingleOrDefault();
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

        public static List<Habilidades> GetRoles()
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
