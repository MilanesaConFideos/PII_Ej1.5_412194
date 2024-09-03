using FacturacionApp_412194.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionApp_412194.Repositories.Contracts
{
    public interface IFacturaRepository
    {
            bool AddOne(Factura factura);
            Factura GetOne(int nroFactura);
            List<Factura> GetAll();
    }
}
