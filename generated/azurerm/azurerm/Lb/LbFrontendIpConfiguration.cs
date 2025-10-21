using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Lb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.lb.LbFrontendIpConfiguration")]
    public class LbFrontendIpConfiguration : azurerm.Lb.ILbFrontendIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#name Lb#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#gateway_load_balancer_frontend_ip_configuration_id Lb#gateway_load_balancer_frontend_ip_configuration_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gatewayLoadBalancerFrontendIpConfigurationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GatewayLoadBalancerFrontendIpConfigurationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#private_ip_address Lb#private_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#private_ip_address_allocation Lb#private_ip_address_allocation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddressAllocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIpAddressAllocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#private_ip_address_version Lb#private_ip_address_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddressVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIpAddressVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#public_ip_address_id Lb#public_ip_address_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicIpAddressId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicIpAddressId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#public_ip_prefix_id Lb#public_ip_prefix_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicIpPrefixId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicIpPrefixId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#subnet_id Lb#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb#zones Lb#zones}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Zones
        {
            get;
            set;
        }
    }
}
