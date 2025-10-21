using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudGateway
{
    [JsiiInterface(nativeType: typeof(ISpringCloudGatewayLocalResponseCachePerRoute), fullyQualifiedName: "azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerRoute")]
    public interface ISpringCloudGatewayLocalResponseCachePerRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#size SpringCloudGateway#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Size
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#time_to_live SpringCloudGateway#time_to_live}.</summary>
        [JsiiProperty(name: "timeToLive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeToLive
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudGatewayLocalResponseCachePerRoute), fullyQualifiedName: "azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerRoute")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#size SpringCloudGateway#size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Size
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#time_to_live SpringCloudGateway#time_to_live}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeToLive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeToLive
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
