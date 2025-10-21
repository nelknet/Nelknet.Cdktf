using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.functionAppSlot.FunctionAppSlotAuthSettingsTwitter")]
    public class FunctionAppSlotAuthSettingsTwitter : azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsTwitter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#consumer_key FunctionAppSlot#consumer_key}.</summary>
        [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ConsumerKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#consumer_secret FunctionAppSlot#consumer_secret}.</summary>
        [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}")]
        public string ConsumerSecret
        {
            get;
            set;
        }
    }
}
