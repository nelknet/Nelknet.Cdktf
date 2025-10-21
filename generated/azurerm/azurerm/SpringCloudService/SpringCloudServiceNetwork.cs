using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.springCloudService.SpringCloudServiceNetwork")]
    public class SpringCloudServiceNetwork : azurerm.SpringCloudService.ISpringCloudServiceNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#app_subnet_id SpringCloudService#app_subnet_id}.</summary>
        [JsiiProperty(name: "appSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string AppSubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#cidr_ranges SpringCloudService#cidr_ranges}.</summary>
        [JsiiProperty(name: "cidrRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CidrRanges
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#service_runtime_subnet_id SpringCloudService#service_runtime_subnet_id}.</summary>
        [JsiiProperty(name: "serviceRuntimeSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceRuntimeSubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#app_network_resource_group SpringCloudService#app_network_resource_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appNetworkResourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppNetworkResourceGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#outbound_type SpringCloudService#outbound_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outboundType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutboundType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#read_timeout_seconds SpringCloudService#read_timeout_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadTimeoutSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#service_runtime_network_resource_group SpringCloudService#service_runtime_network_resource_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceRuntimeNetworkResourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceRuntimeNetworkResourceGroup
        {
            get;
            set;
        }
    }
}
