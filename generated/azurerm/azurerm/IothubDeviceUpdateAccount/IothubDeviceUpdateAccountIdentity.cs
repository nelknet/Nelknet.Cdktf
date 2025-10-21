using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.IothubDeviceUpdateAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.iothubDeviceUpdateAccount.IothubDeviceUpdateAccountIdentity")]
    public class IothubDeviceUpdateAccountIdentity : azurerm.IothubDeviceUpdateAccount.IIothubDeviceUpdateAccountIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account#type IothubDeviceUpdateAccount#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account#identity_ids IothubDeviceUpdateAccount#identity_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IdentityIds
        {
            get;
            set;
        }
    }
}
