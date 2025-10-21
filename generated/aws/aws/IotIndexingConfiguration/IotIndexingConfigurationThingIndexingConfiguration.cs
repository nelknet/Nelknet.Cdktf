using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotIndexingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfiguration")]
    public class IotIndexingConfigurationThingIndexingConfiguration : aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#thing_indexing_mode IotIndexingConfiguration#thing_indexing_mode}.</summary>
        [JsiiProperty(name: "thingIndexingMode", typeJson: "{\"primitive\":\"string\"}")]
        public string ThingIndexingMode
        {
            get;
            set;
        }

        private object? _customField;

        /// <summary>custom_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#custom_field IotIndexingConfiguration#custom_field}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationCustomField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomField
        {
            get => _customField;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationCustomField[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationCustomField).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customField = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#device_defender_indexing_mode IotIndexingConfiguration#device_defender_indexing_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceDefenderIndexingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeviceDefenderIndexingMode
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#filter IotIndexingConfiguration#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationFilter\"}", isOptional: true)]
        public aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationFilter? Filter
        {
            get;
            set;
        }

        private object? _managedField;

        /// <summary>managed_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#managed_field IotIndexingConfiguration#managed_field}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationManagedField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ManagedField
        {
            get => _managedField;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationManagedField[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationManagedField).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _managedField = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#named_shadow_indexing_mode IotIndexingConfiguration#named_shadow_indexing_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namedShadowIndexingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamedShadowIndexingMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#thing_connectivity_indexing_mode IotIndexingConfiguration#thing_connectivity_indexing_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thingConnectivityIndexingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ThingConnectivityIndexingMode
        {
            get;
            set;
        }
    }
}
