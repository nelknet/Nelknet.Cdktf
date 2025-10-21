using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppSlot
{
    [JsiiInterface(nativeType: typeof(IFunctionAppSlotAuthSettingsTwitter), fullyQualifiedName: "azurerm.functionAppSlot.FunctionAppSlotAuthSettingsTwitter")]
    public interface IFunctionAppSlotAuthSettingsTwitter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#consumer_key FunctionAppSlot#consumer_key}.</summary>
        [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
        string ConsumerKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#consumer_secret FunctionAppSlot#consumer_secret}.</summary>
        [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}")]
        string ConsumerSecret
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionAppSlotAuthSettingsTwitter), fullyQualifiedName: "azurerm.functionAppSlot.FunctionAppSlotAuthSettingsTwitter")]
        internal sealed class _Proxy : DeputyBase, azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsTwitter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#consumer_key FunctionAppSlot#consumer_key}.</summary>
            [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ConsumerKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#consumer_secret FunctionAppSlot#consumer_secret}.</summary>
            [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}")]
            public string ConsumerSecret
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
