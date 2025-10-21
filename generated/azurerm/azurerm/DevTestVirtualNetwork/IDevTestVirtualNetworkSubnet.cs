using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestVirtualNetwork
{
    [JsiiInterface(nativeType: typeof(IDevTestVirtualNetworkSubnet), fullyQualifiedName: "azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnet")]
    public interface IDevTestVirtualNetworkSubnet
    {
        /// <summary>shared_public_ip_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#shared_public_ip_address DevTestVirtualNetwork#shared_public_ip_address}
        /// </remarks>
        [JsiiProperty(name: "sharedPublicIpAddress", typeJson: "{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddress? SharedPublicIpAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#use_in_virtual_machine_creation DevTestVirtualNetwork#use_in_virtual_machine_creation}.</summary>
        [JsiiProperty(name: "useInVirtualMachineCreation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UseInVirtualMachineCreation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#use_public_ip_address DevTestVirtualNetwork#use_public_ip_address}.</summary>
        [JsiiProperty(name: "usePublicIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsePublicIpAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevTestVirtualNetworkSubnet), fullyQualifiedName: "azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnet")]
        internal sealed class _Proxy : DeputyBase, azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>shared_public_ip_address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#shared_public_ip_address DevTestVirtualNetwork#shared_public_ip_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sharedPublicIpAddress", typeJson: "{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddress\"}", isOptional: true)]
            public azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddress? SharedPublicIpAddress
            {
                get => GetInstanceProperty<azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddress?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#use_in_virtual_machine_creation DevTestVirtualNetwork#use_in_virtual_machine_creation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useInVirtualMachineCreation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UseInVirtualMachineCreation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#use_public_ip_address DevTestVirtualNetwork#use_public_ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usePublicIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsePublicIpAddress
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
