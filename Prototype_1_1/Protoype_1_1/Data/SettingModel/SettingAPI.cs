using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype1_1.Data.SettingModel
{
    class SettingAPI
    {

        private soen390Entities _soen390Entities;

        public SettingAPI(){
            _soen390Entities = EntityModel.EntityModel.getInstance()._soen390Entities;
        }

        public string getPriority(string title)
        {
            
            try
            {
                flagtype aFlagtype = _soen390Entities.flagtype.First(r => r.FlagTitle == title);
                
                if (aFlagtype == null)
                {
                    return "";
                }
                else
                {
                    return aFlagtype.FlagPriority.ToString();
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                throw (new Exception(dbEx.ToString()));
            }
        }


        // not used
        public string getPostalCodePrefix(string region)
        {

            try
            {
                region aRegion = _soen390Entities.region.First(r => r.RegionName == region);
                if (aRegion == null)
                {
                    return "";
                }
                else
                {
                    return aRegion.ForwardSortationArea.ToString();
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                throw (new Exception(dbEx.ToString()));
            }
        }

        public string getRegionNameByCodePrefix(string code)
        {

            try
            {
                region aRegion = _soen390Entities.region.First(r => r.ForwardSortationArea == code);
                if (aRegion == null)
                {
                    return "";
                }
                else
                {
                    return aRegion.RegionName.ToString();
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                throw (new Exception(dbEx.ToString()));
            }
        }
    }
}
