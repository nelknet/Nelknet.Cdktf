using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlot
{
    [JsiiInterface(nativeType: typeof(IAppServiceSlotAuthSettingsFacebook), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotAuthSettingsFacebook")]
    public interface IAppServiceSlotAuthSettingsFacebook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#app_id AppServiceSlot#app_id}.</summary>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        string AppId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#app_secret AppServiceSlot#app_secret}.</summary>
        [JsiiProperty(name: "appSecret", typeJson: "{\"primitive\":\"string\"}")]
        string AppSecret
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#oauth_scopes AppServiceSlot#oauth_scopes}.</summary>
        [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OauthScopes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceSlotAuthSettingsFacebook), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotAuthSettingsFacebook")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsFacebook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#app_id AppServiceSlot#app_id}.</summary>
            [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
            public string AppId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#app_secret AppServiceSlot#app_secret}.</summary>
            [JsiiProperty(name: "appSecret", typeJson: "{\"primitive\":\"string\"}")]
            public string AppSecret
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#oauth_scopes AppServiceSlot#oauth_scopes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OauthScopes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
