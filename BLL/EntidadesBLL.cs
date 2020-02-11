using Microsoft.EntityFrameworkCore;
using PrimerParcial.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerParcial.BLL
{
    class EntidadesBLL
    {
        public static bool Guardar(Entidades entidades)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Entidades.Add(entidades) != null)
                    paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        internal static Entidades Buscar(int id)
        {
            throw new NotImplementedException();
        }
    }
            public static bool Eliminar(int Id)
            {
                bool paso = false;
                Contexto db = new Contexto();

                try
                {
                    var eliminar = db.Entidades.Find(Id);
                    db.Entry(eliminar).State = EntityState.Deleted;
                    paso = (db.SaveChanges() > 0);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    db.Dispose();
                }

                return paso;
            }
            public static BLL.EntidadesBLL Buscar(int Id)
            {
                BLL.EntidadesBLL E = new Entidades();
                Contexto db = new Contexto();

                try
                {
                    E = db.Entidades.Find(Id);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    db.Dispose();
                }
                return E;
            }

        }
    }
}
