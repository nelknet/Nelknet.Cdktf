using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Subnet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.subnet.SubnetDelegation")]
    public class SubnetDelegation : azurerm.Subnet.ISubnetDelegation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#name Subnet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>service_delegation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#service_delegation Subnet#service_delegation}
        /// </remarks>
        [JsiiProperty(name: "serviceDelegation", typeJson: "{\"fqn\":\"azurerm.subnet.SubnetDelegationServiceDelegation\"}")]
        public azurerm.Subnet.ISubnetDelegationServiceDelegation ServiceDelegation
        {
            get;
            set;
        }
    }
}
