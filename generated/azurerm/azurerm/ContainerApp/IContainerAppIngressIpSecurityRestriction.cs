using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    [JsiiInterface(nativeType: typeof(IContainerAppIngressIpSecurityRestriction), fullyQualifiedName: "azurerm.containerApp.ContainerAppIngressIpSecurityRestriction")]
    public interface IContainerAppIngressIpSecurityRestriction
    {
        /// <summary>The action. Allow or Deny.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#action ContainerApp#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>The incoming IP address or range of IP addresses (in CIDR notation).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#ip_address_range ContainerApp#ip_address_range}
        /// </remarks>
        [JsiiProperty(name: "ipAddressRange", typeJson: "{\"primitive\":\"string\"}")]
        string IpAddressRange
        {
            get;
        }

        /// <summary>Name for the IP restriction rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#name ContainerApp#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Describe the IP restriction rule that is being sent to the container-app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#description ContainerApp#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppIngressIpSecurityRestriction), fullyQualifiedName: "azurerm.containerApp.ContainerAppIngressIpSecurityRestriction")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerApp.IContainerAppIngressIpSecurityRestriction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The action. Allow or Deny.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#action ContainerApp#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The incoming IP address or range of IP addresses (in CIDR notation).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#ip_address_range ContainerApp#ip_address_range}
            /// </remarks>
            [JsiiProperty(name: "ipAddressRange", typeJson: "{\"primitive\":\"string\"}")]
            public string IpAddressRange
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name for the IP restriction rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#name ContainerApp#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Describe the IP restriction rule that is being sent to the container-app.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#description ContainerApp#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
