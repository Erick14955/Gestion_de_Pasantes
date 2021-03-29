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
    public class PasantesBLL
    {
        public static bool Guardar(Pasantes pasantes)
        {
            if (!Existe(pasantes.Id))
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

        public static bool ExisteUsuario(string email, string clave)
        {
            bool encontrado = false;
            var contexto = new Contexto();

            try
            {
                encontrado = contexto.Pasantes.Any(e => e.Email == email && e.Clave == clave);
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
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(pasantes).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
            Pasantes pasantes;
            try
            {
                pasantes = contexto.Pasantes.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return pasantes;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Pasantes.Any(e => e.Id == id);
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
