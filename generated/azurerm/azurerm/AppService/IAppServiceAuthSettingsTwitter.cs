using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppService
{
    [JsiiInterface(nativeType: typeof(IAppServiceAuthSettingsTwitter), fullyQualifiedName: "azurerm.appService.AppServiceAuthSettingsTwitter")]
    public interface IAppServiceAuthSettingsTwitter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#consumer_key AppService#consumer_key}.</summary>
        [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
        string ConsumerKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#consumer_secret AppService#consumer_secret}.</summary>
        [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}")]
        string ConsumerSecret
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceAuthSettingsTwitter), fullyQualifiedName: "azurerm.appService.AppServiceAuthSettingsTwitter")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppService.IAppServiceAuthSettingsTwitter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#consumer_key AppService#consumer_key}.</summary>
            [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ConsumerKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#consumer_secret AppService#consumer_secret}.</summary>
            [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}")]
            public string ConsumerSecret
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
