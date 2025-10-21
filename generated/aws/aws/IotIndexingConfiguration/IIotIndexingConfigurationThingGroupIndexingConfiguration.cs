using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotIndexingConfiguration
{
    [JsiiInterface(nativeType: typeof(IIotIndexingConfigurationThingGroupIndexingConfiguration), fullyQualifiedName: "aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfiguration")]
    public interface IIotIndexingConfigurationThingGroupIndexingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#thing_group_indexing_mode IotIndexingConfiguration#thing_group_indexing_mode}.</summary>
        [JsiiProperty(name: "thingGroupIndexingMode", typeJson: "{\"primitive\":\"string\"}")]
        string ThingGroupIndexingMode
        {
            get;
        }

        /// <summary>custom_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#custom_field IotIndexingConfiguration#custom_field}
        /// </remarks>
        [JsiiProperty(name: "customField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationCustomField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomField
        {
            get
            {
                return null;
            }
        }

        /// <summary>managed_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#managed_field IotIndexingConfiguration#managed_field}
        /// </remarks>
        [JsiiProperty(name: "managedField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationManagedField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManagedField
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotIndexingConfigurationThingGroupIndexingConfiguration), fullyQualifiedName: "aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#thing_group_indexing_mode IotIndexingConfiguration#thing_group_indexing_mode}.</summary>
            [JsiiProperty(name: "thingGroupIndexingMode", typeJson: "{\"primitive\":\"string\"}")]
            public string ThingGroupIndexingMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>custom_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#custom_field IotIndexingConfiguration#custom_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationCustomField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomField
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>managed_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#managed_field IotIndexingConfiguration#managed_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationManagedField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ManagedField
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
