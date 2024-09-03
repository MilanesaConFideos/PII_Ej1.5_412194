using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturacionApp_412194.Entities;

namespace FacturacionApp_412194.Repositories.Contracts
{
    public interface IFormaPagoRepository   
    {
        List<FormaPago> GetAll();
        FormaPago GetOne(int id);
    }
}
