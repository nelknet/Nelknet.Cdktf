using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudGateway
{
    [JsiiInterface(nativeType: typeof(ISpringCloudGatewayQuota), fullyQualifiedName: "azurerm.springCloudGateway.SpringCloudGatewayQuota")]
    public interface ISpringCloudGatewayQuota
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#cpu SpringCloudGateway#cpu}.</summary>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cpu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#memory SpringCloudGateway#memory}.</summary>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Memory
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudGatewayQuota), fullyQualifiedName: "azurerm.springCloudGateway.SpringCloudGatewayQuota")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudGateway.ISpringCloudGatewayQuota
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#cpu SpringCloudGateway#cpu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cpu
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#memory SpringCloudGateway#memory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Memory
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
