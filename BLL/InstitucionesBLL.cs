using Gestion_de_Pasantes.Entidades;
using Gestion_de_Pasantes.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Gestion_de_Pasantes.BLL
{
    public class InstitucionesBLL
    {
        public static bool Guardar(Instituciones instituciones)
        {
            if (!Existe(instituciones.InstitucionId))
                return Insertar(instituciones);

            else
                return Modificar(instituciones);
        }
        private static bool Insertar(Instituciones instituciones)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Instituciones.Add(instituciones);
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

        public static bool Modificar(Instituciones instituciones)
        {

            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Entry(instituciones).State = EntityState.Modified;
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
                var instituciones = contexto.Instituciones.Find(id);

                if (instituciones != null)
                {
                    contexto.Instituciones.Remove(instituciones);
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
        public static Instituciones Buscar(int id)
        {
            Instituciones cliente;
            Contexto context = new Contexto();

            try
            {
                cliente = context.Instituciones.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }
            return cliente;

        }
        public static bool Existe(int id)
        {

            Contexto context = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = context.Instituciones.Find(id) != null;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }

            return encontrado;

        }

        public static List<Instituciones> GetList(Expression<Func<Instituciones, bool>> criterio)
        {
            List<Instituciones> lista = new List<Instituciones>();
            Contexto context = new Contexto();

            try
            {
                lista = context.Instituciones.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }
            return lista;

        }
    }
}
