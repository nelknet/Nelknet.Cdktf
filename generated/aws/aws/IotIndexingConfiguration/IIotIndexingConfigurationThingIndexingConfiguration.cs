using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotIndexingConfiguration
{
    [JsiiInterface(nativeType: typeof(IIotIndexingConfigurationThingIndexingConfiguration), fullyQualifiedName: "aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfiguration")]
    public interface IIotIndexingConfigurationThingIndexingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#thing_indexing_mode IotIndexingConfiguration#thing_indexing_mode}.</summary>
        [JsiiProperty(name: "thingIndexingMode", typeJson: "{\"primitive\":\"string\"}")]
        string ThingIndexingMode
        {
            get;
        }

        /// <summary>custom_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#custom_field IotIndexingConfiguration#custom_field}
        /// </remarks>
        [JsiiProperty(name: "customField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationCustomField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomField
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#device_defender_indexing_mode IotIndexingConfiguration#device_defender_indexing_mode}.</summary>
        [JsiiProperty(name: "deviceDefenderIndexingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeviceDefenderIndexingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#filter IotIndexingConfiguration#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationFilter? Filter
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
        [JsiiProperty(name: "managedField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationManagedField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManagedField
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#named_shadow_indexing_mode IotIndexingConfiguration#named_shadow_indexing_mode}.</summary>
        [JsiiProperty(name: "namedShadowIndexingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamedShadowIndexingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#thing_connectivity_indexing_mode IotIndexingConfiguration#thing_connectivity_indexing_mode}.</summary>
        [JsiiProperty(name: "thingConnectivityIndexingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ThingConnectivityIndexingMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotIndexingConfigurationThingIndexingConfiguration), fullyQualifiedName: "aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#thing_indexing_mode IotIndexingConfiguration#thing_indexing_mode}.</summary>
            [JsiiProperty(name: "thingIndexingMode", typeJson: "{\"primitive\":\"string\"}")]
            public string ThingIndexingMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>custom_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#custom_field IotIndexingConfiguration#custom_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationCustomField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomField
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#device_defender_indexing_mode IotIndexingConfiguration#device_defender_indexing_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deviceDefenderIndexingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeviceDefenderIndexingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#filter IotIndexingConfiguration#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationFilter\"}", isOptional: true)]
            public aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationFilter? Filter
            {
                get => GetInstanceProperty<aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationFilter?>();
            }

            /// <summary>managed_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#managed_field IotIndexingConfiguration#managed_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationManagedField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ManagedField
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#named_shadow_indexing_mode IotIndexingConfiguration#named_shadow_indexing_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namedShadowIndexingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamedShadowIndexingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#thing_connectivity_indexing_mode IotIndexingConfiguration#thing_connectivity_indexing_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thingConnectivityIndexingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ThingConnectivityIndexingMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
