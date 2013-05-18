using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using  Prototype1_1.Data;

namespace Prototype1_1.Data.EntityModel
{
    public class EntityModel
    {
         #region Attributes
        
        private static EntityModel _instance;
        public soen390Entities _soen390Entities;
        
        #endregion

        #region Constructor

        private EntityModel()
        {
            _soen390Entities = new soen390Entities();
        }

        public static EntityModel getInstance()
        {
            if (_instance == null)
            {
                _instance = new EntityModel();
            }

            return _instance;
        }

        public void save()
        {
            _soen390Entities.SaveChanges();
        }
        #endregion
    }
}
