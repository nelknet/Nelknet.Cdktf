using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppSlot
{
    [JsiiInterface(nativeType: typeof(IFunctionAppSlotAuthSettingsFacebook), fullyQualifiedName: "azurerm.functionAppSlot.FunctionAppSlotAuthSettingsFacebook")]
    public interface IFunctionAppSlotAuthSettingsFacebook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#app_id FunctionAppSlot#app_id}.</summary>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        string AppId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#app_secret FunctionAppSlot#app_secret}.</summary>
        [JsiiProperty(name: "appSecret", typeJson: "{\"primitive\":\"string\"}")]
        string AppSecret
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#oauth_scopes FunctionAppSlot#oauth_scopes}.</summary>
        [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OauthScopes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionAppSlotAuthSettingsFacebook), fullyQualifiedName: "azurerm.functionAppSlot.FunctionAppSlotAuthSettingsFacebook")]
        internal sealed class _Proxy : DeputyBase, azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsFacebook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#app_id FunctionAppSlot#app_id}.</summary>
            [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
            public string AppId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#app_secret FunctionAppSlot#app_secret}.</summary>
            [JsiiProperty(name: "appSecret", typeJson: "{\"primitive\":\"string\"}")]
            public string AppSecret
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#oauth_scopes FunctionAppSlot#oauth_scopes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OauthScopes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
