using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Data.FlagModel
{
    public class FlagAPI
    {
        private soen390Entities _soen390Entities;

         public FlagAPI()
        {
            _soen390Entities = EntityModel.EntityModel.getInstance()._soen390Entities;
        }

        public List<flag> getAllFlags()
        {
            return _soen390Entities.flag.ToList();
        }
          
    }
}
