using Grand.Core.Plugins;
using Grand.Services.Discounts;
using Grand.Core.Domain.Discounts;
using Grand.Core;

namespace Grand.Plugin.DiscountAmount.Sample
{
    public class DiscountAmountSample : BasePlugin, IDiscountAmountProvider
    {
        private readonly IWebHelper _webHelper;
        public DiscountAmountSample(IWebHelper webHelper)
        {
            this._webHelper = webHelper;
        }

        public decimal DiscountAmount(Discount discount, decimal amount)
        {
            return 1;
        }
        public override string GetConfigurationPageUrl()
        {
            return $"{_webHelper.GetStoreLocation()}Admin/DiscountAmountSample/Configure";
        }
        public override void Install()
        {
            base.Install();
        }

        public override void Uninstall()
        {
            //locales
            base.Uninstall();
        }
    }
}
