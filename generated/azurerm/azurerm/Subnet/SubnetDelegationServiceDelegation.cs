using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Subnet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.subnet.SubnetDelegationServiceDelegation")]
    public class SubnetDelegationServiceDelegation : azurerm.Subnet.ISubnetDelegationServiceDelegation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#name Subnet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#actions Subnet#actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Actions
        {
            get;
            set;
        }
    }
}
