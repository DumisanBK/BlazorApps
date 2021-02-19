using BancassuranceApi.ViewModels;

namespace BancaPortal.Utils
{
    public class PolicyFormUtils
    {
        public static void Capitalize(ref PolicyForm policyForm)
        {
            policyForm.Title = policyForm.Title.ToUpper();
            policyForm.FirstName = policyForm.FirstName.ToUpper();
            policyForm.SurName = policyForm.SurName.ToUpper();
            policyForm.CustomerName = policyForm.CustomerName.ToUpper();
        }
    }
}
