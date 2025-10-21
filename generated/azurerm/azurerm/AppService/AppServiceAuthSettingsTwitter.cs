using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.appService.AppServiceAuthSettingsTwitter")]
    public class AppServiceAuthSettingsTwitter : azurerm.AppService.IAppServiceAuthSettingsTwitter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#consumer_key AppService#consumer_key}.</summary>
        [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ConsumerKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#consumer_secret AppService#consumer_secret}.</summary>
        [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}")]
        public string ConsumerSecret
        {
            get;
            set;
        }
    }
}
