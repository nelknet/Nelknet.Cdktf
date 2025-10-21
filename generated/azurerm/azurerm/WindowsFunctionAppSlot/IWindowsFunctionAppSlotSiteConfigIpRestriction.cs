using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsFunctionAppSlotSiteConfigIpRestriction), fullyQualifiedName: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigIpRestriction")]
    public interface IWindowsFunctionAppSlotSiteConfigIpRestriction
    {
        /// <summary>The action to take. Possible values are `Allow` or `Deny`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#action WindowsFunctionAppSlot#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>The description of the IP restriction rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#description WindowsFunctionAppSlot#description}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#headers WindowsFunctionAppSlot#headers}.</summary>
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigIpRestrictionHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Headers
        {
            get
            {
                return null;
            }
        }

        /// <summary>The CIDR notation of the IP or IP Range to match.</summary>
        /// <remarks>
        /// For example: <c>10.0.0.0/24</c> or <c>192.168.10.1/32</c> or <c>fe80::/64</c> or <c>13.107.6.152/31,13.107.128.0/22</c>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#ip_address WindowsFunctionAppSlot#ip_address}
        /// </remarks>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name which should be used for this `ip_restriction`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#name WindowsFunctionAppSlot#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>The priority value of this `ip_restriction`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#priority WindowsFunctionAppSlot#priority}
        /// </remarks>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Service Tag used for this IP Restriction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#service_tag WindowsFunctionAppSlot#service_tag}
        /// </remarks>
        [JsiiProperty(name: "serviceTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#virtual_network_subnet_id WindowsFunctionAppSlot#virtual_network_subnet_id}
        /// </remarks>
        [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualNetworkSubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsFunctionAppSlotSiteConfigIpRestriction), fullyQualifiedName: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigIpRestriction")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotSiteConfigIpRestriction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The action to take. Possible values are `Allow` or `Deny`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#action WindowsFunctionAppSlot#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The description of the IP restriction rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#description WindowsFunctionAppSlot#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#headers WindowsFunctionAppSlot#headers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfigIpRestrictionHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Headers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The CIDR notation of the IP or IP Range to match.</summary>
            /// <remarks>
            /// For example: <c>10.0.0.0/24</c> or <c>192.168.10.1/32</c> or <c>fe80::/64</c> or <c>13.107.6.152/31,13.107.128.0/22</c>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#ip_address WindowsFunctionAppSlot#ip_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name which should be used for this `ip_restriction`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#name WindowsFunctionAppSlot#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The priority value of this `ip_restriction`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#priority WindowsFunctionAppSlot#priority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The Service Tag used for this IP Restriction.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#service_tag WindowsFunctionAppSlot#service_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceTag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#virtual_network_subnet_id WindowsFunctionAppSlot#virtual_network_subnet_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualNetworkSubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
