using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    [JsiiInterface(nativeType: typeof(ISpringCloudServiceTrace), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceTrace")]
    public interface ISpringCloudServiceTrace
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#connection_string SpringCloudService#connection_string}.</summary>
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#sample_rate SpringCloudService#sample_rate}.</summary>
        [JsiiProperty(name: "sampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SampleRate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudServiceTrace), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceTrace")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudService.ISpringCloudServiceTrace
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#connection_string SpringCloudService#connection_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#sample_rate SpringCloudService#sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SampleRate
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
