using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    [JsiiInterface(nativeType: typeof(ISpringCloudServiceNetwork), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceNetwork")]
    public interface ISpringCloudServiceNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#app_subnet_id SpringCloudService#app_subnet_id}.</summary>
        [JsiiProperty(name: "appSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        string AppSubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#cidr_ranges SpringCloudService#cidr_ranges}.</summary>
        [JsiiProperty(name: "cidrRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CidrRanges
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#service_runtime_subnet_id SpringCloudService#service_runtime_subnet_id}.</summary>
        [JsiiProperty(name: "serviceRuntimeSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRuntimeSubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#app_network_resource_group SpringCloudService#app_network_resource_group}.</summary>
        [JsiiProperty(name: "appNetworkResourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppNetworkResourceGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#outbound_type SpringCloudService#outbound_type}.</summary>
        [JsiiProperty(name: "outboundType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutboundType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#read_timeout_seconds SpringCloudService#read_timeout_seconds}.</summary>
        [JsiiProperty(name: "readTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadTimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#service_runtime_network_resource_group SpringCloudService#service_runtime_network_resource_group}.</summary>
        [JsiiProperty(name: "serviceRuntimeNetworkResourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceRuntimeNetworkResourceGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudServiceNetwork), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceNetwork")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudService.ISpringCloudServiceNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#app_subnet_id SpringCloudService#app_subnet_id}.</summary>
            [JsiiProperty(name: "appSubnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string AppSubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#cidr_ranges SpringCloudService#cidr_ranges}.</summary>
            [JsiiProperty(name: "cidrRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CidrRanges
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#service_runtime_subnet_id SpringCloudService#service_runtime_subnet_id}.</summary>
            [JsiiProperty(name: "serviceRuntimeSubnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRuntimeSubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#app_network_resource_group SpringCloudService#app_network_resource_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "appNetworkResourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppNetworkResourceGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#outbound_type SpringCloudService#outbound_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outboundType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutboundType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#read_timeout_seconds SpringCloudService#read_timeout_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadTimeoutSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#service_runtime_network_resource_group SpringCloudService#service_runtime_network_resource_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceRuntimeNetworkResourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceRuntimeNetworkResourceGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
