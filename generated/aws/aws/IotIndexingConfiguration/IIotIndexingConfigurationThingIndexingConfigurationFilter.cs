using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotIndexingConfiguration
{
    [JsiiInterface(nativeType: typeof(IIotIndexingConfigurationThingIndexingConfigurationFilter), fullyQualifiedName: "aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationFilter")]
    public interface IIotIndexingConfigurationThingIndexingConfigurationFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#named_shadow_names IotIndexingConfiguration#named_shadow_names}.</summary>
        [JsiiProperty(name: "namedShadowNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NamedShadowNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotIndexingConfigurationThingIndexingConfigurationFilter), fullyQualifiedName: "aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationFilter")]
        internal sealed class _Proxy : DeputyBase, aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#named_shadow_names IotIndexingConfiguration#named_shadow_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namedShadowNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NamedShadowNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
