using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.appService.AppServiceAuthSettingsFacebook")]
    public class AppServiceAuthSettingsFacebook : azurerm.AppService.IAppServiceAuthSettingsFacebook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#app_id AppService#app_id}.</summary>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        public string AppId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#app_secret AppService#app_secret}.</summary>
        [JsiiProperty(name: "appSecret", typeJson: "{\"primitive\":\"string\"}")]
        public string AppSecret
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#oauth_scopes AppService#oauth_scopes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OauthScopes
        {
            get;
            set;
        }
    }
}
