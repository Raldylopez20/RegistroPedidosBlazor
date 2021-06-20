using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RegistroPedidosBlazor.Models;
using RegistroPedidosBlazor.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace RegistroPedidosBlazor.BLL
{
    public class SuplidoresBLL
    {
        public static List<Suplidores> GetList(Expression<Func<Suplidores, bool>> suplidores)
        {
            Contexto db = new Contexto();
            List<Suplidores> Lista = new List<Suplidores>();

            try
            {
                Lista = db.Suplidores.Where(suplidores).ToList();
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return Lista;
        }
    }
}