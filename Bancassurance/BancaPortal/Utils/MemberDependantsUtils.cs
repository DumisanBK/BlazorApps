using BancassuranceApi.Utils;
using BancassuranceLib.Models;
using System;
using System.Linq;

namespace BancaPortal.Utils
{
    public class MemberDependantsUtils
    {
        public static int GetSpouseCount(MainMemberDetails member)
        {
            int count =  member.Dependents.Where(d => d.Normal == 2).Count();

            return count;
        }

        public static int GetNormalDependantsCount(MainMemberDetails member)
        {
            int count = member.Dependents.Where(d => d.Normal == 1).Count();

            return count;
        }

        public static int GetPremiumCount(MainMemberDetails member)
        {
            int count = member.Dependents.Where(d => d.Normal == 0).Count();

            return count;
        }

        public static bool CanAddSpouse(MainMemberDetails member, IConfigReader configReader)
        {
            int max = Convert.ToInt32(configReader.Read("MaxSpouseDependants"));

            return GetSpouseCount(member) < max;
        }

        public static bool CanAddNormal(MainMemberDetails member, IConfigReader configReader)
        {
            int max = Convert.ToInt32(configReader.Read("MaxNormalDependants"));

            return GetNormalDependantsCount(member) <= max;
        }

        public static bool CanAddPremium(MainMemberDetails member, IConfigReader configReader)
        {
            int max = Convert.ToInt32(configReader.Read("MaxPremiumDependants"));

            return GetNormalDependantsCount(member) <= max;
        }


    }
}
