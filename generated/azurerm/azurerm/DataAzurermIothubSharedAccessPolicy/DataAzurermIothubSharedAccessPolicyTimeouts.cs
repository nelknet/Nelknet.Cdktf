using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermIothubSharedAccessPolicy
{
    [JsiiByValue(fqn: "azurerm.dataAzurermIothubSharedAccessPolicy.DataAzurermIothubSharedAccessPolicyTimeouts")]
    public class DataAzurermIothubSharedAccessPolicyTimeouts : azurerm.DataAzurermIothubSharedAccessPolicy.IDataAzurermIothubSharedAccessPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_shared_access_policy#read DataAzurermIothubSharedAccessPolicy#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
