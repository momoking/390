using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Data.NoteModel
{
    public class NoteAPI
    {
         private soen390Entities _soen390Entities;

         public NoteAPI()
        {
            _soen390Entities = EntityModel.EntityModel.getInstance()._soen390Entities;
        }
        
    }
}
