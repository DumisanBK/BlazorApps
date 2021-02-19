using BancassuranceApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancaPortal.Utils
{
    public class DependantFormUtil
    {
        public static void Capitilize(ref DependantForm dependantForm)
        {
            dependantForm.FirstName = dependantForm.FirstName.ToUpper();
            dependantForm.SurName = dependantForm.SurName.ToUpper();
        }
    }
}
