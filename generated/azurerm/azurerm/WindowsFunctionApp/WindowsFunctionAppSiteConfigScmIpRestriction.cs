using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionApp
{
    [JsiiByValue(fqn: "azurerm.windowsFunctionApp.WindowsFunctionAppSiteConfigScmIpRestriction")]
    public class WindowsFunctionAppSiteConfigScmIpRestriction : azurerm.WindowsFunctionApp.IWindowsFunctionAppSiteConfigScmIpRestriction
    {
        /// <summary>The action to take. Possible values are `Allow` or `Deny`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#action WindowsFunctionApp#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }

        /// <summary>The description of the IP restriction rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#description WindowsFunctionApp#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _headers;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#headers WindowsFunctionApp#headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsFunctionApp.WindowsFunctionAppSiteConfigScmIpRestrictionHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Headers
        {
            get => _headers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.WindowsFunctionApp.IWindowsFunctionAppSiteConfigScmIpRestrictionHeaders[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsFunctionApp.IWindowsFunctionAppSiteConfigScmIpRestrictionHeaders).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _headers = value;
            }
        }

        /// <summary>The CIDR notation of the IP or IP Range to match.</summary>
        /// <remarks>
        /// For example: <c>10.0.0.0/24</c> or <c>192.168.10.1/32</c> or <c>fe80::/64</c> or <c>13.107.6.152/31,13.107.128.0/22</c>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#ip_address WindowsFunctionApp#ip_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpAddress
        {
            get;
            set;
        }

        /// <summary>The name which should be used for this `ip_restriction`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#name WindowsFunctionApp#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>The priority value of this `ip_restriction`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#priority WindowsFunctionApp#priority}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>The Service Tag used for this IP Restriction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#service_tag WindowsFunctionApp#service_tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceTag
        {
            get;
            set;
        }

        /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#virtual_network_subnet_id WindowsFunctionApp#virtual_network_subnet_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualNetworkSubnetId
        {
            get;
            set;
        }
    }
}
