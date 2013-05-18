using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.Data;

namespace Prototype1_1.Data.ReportModel
{
    class ReportAPI
    {

        public ReportAPI()
        {

        }

        public IEnumerable<client> GetClients()
        {
            return EntityModel.EntityModel.getInstance()._soen390Entities.client.ToList();
        }
    }
}
