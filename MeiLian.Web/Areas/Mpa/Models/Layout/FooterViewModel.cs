using MeiLian.Sessions.Dto;

namespace MeiLian.Web.Areas.Mpa.Models.Layout
{
    public class FooterViewModel
    {
        public GetCurrentLoginInformationsOutput LoginInformations { get; set; }

        public string GetProductNameWithEdition()
        {
            var productName = "MeiLian";

            if (LoginInformations.Tenant != null && LoginInformations.Tenant.EditionDisplayName != null)
            {
                productName += " " + LoginInformations.Tenant.EditionDisplayName;
            }

            return productName;
        }
    }
}
