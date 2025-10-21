using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Subnet
{
    [JsiiInterface(nativeType: typeof(ISubnetDelegation), fullyQualifiedName: "azurerm.subnet.SubnetDelegation")]
    public interface ISubnetDelegation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#name Subnet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>service_delegation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#service_delegation Subnet#service_delegation}
        /// </remarks>
        [JsiiProperty(name: "serviceDelegation", typeJson: "{\"fqn\":\"azurerm.subnet.SubnetDelegationServiceDelegation\"}")]
        azurerm.Subnet.ISubnetDelegationServiceDelegation ServiceDelegation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISubnetDelegation), fullyQualifiedName: "azurerm.subnet.SubnetDelegation")]
        internal sealed class _Proxy : DeputyBase, azurerm.Subnet.ISubnetDelegation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#name Subnet#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>service_delegation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet#service_delegation Subnet#service_delegation}
            /// </remarks>
            [JsiiProperty(name: "serviceDelegation", typeJson: "{\"fqn\":\"azurerm.subnet.SubnetDelegationServiceDelegation\"}")]
            public azurerm.Subnet.ISubnetDelegationServiceDelegation ServiceDelegation
            {
                get => GetInstanceProperty<azurerm.Subnet.ISubnetDelegationServiceDelegation>()!;
            }
        }
    }
}
