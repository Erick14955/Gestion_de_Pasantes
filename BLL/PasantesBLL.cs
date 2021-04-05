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
    public class PasantesBLL
    {
        public static bool Guardar(Pasantes pasantes)
        {
            if (!Existe(pasantes.PasanteId))
                return Insertar(pasantes);
            else
                return Modificar(pasantes);
        }

        private static bool Insertar(Pasantes pasantes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Pasantes.Add(pasantes);
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

        public static bool ExistePasante(int matricula)
        {
            bool encontrado = false;
            var contexto = new Contexto();

            try
            {
                encontrado = contexto.Pasantes.Any(e => e.Matricula == matricula);
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

        public static bool Modificar(Pasantes pasantes)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM HabilidadesDetalle where PasanteId={pasantes.PasanteId}");
                foreach (var anterior in pasantes.Detalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }
                contexto.Entry(pasantes).State = EntityState.Modified;
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
                var pasantes = contexto.Pasantes.Find(id);
                if (pasantes != null)
                {
                    contexto.Pasantes.Remove(pasantes);
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

        public static Pasantes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Pasantes pasante;

            try
            {
                pasante = contexto.Pasantes.Include(e => e.Detalle).Where(p => p.PasanteId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return pasante;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Pasantes.Any(e => e.PasanteId == id);
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
        public static List<Pasantes> GetPasantes()
        {
            Contexto contexto = new Contexto();
            List<Pasantes> lista = new List<Pasantes>();

            try
            {
                lista = contexto.Pasantes.ToList();

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
        public static List<Pasantes> GetList(Expression<Func<Pasantes, bool>> criterio)
        {
            List<Pasantes> lista = new List<Pasantes>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Pasantes.Where(criterio).ToList();
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
