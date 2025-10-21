using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotIndexingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfiguration")]
    public class IotIndexingConfigurationThingGroupIndexingConfiguration : aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#thing_group_indexing_mode IotIndexingConfiguration#thing_group_indexing_mode}.</summary>
        [JsiiProperty(name: "thingGroupIndexingMode", typeJson: "{\"primitive\":\"string\"}")]
        public string ThingGroupIndexingMode
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
        [JsiiProperty(name: "customField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationCustomField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfigurationCustomField[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfigurationCustomField).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customField = value;
            }
        }

        private object? _managedField;

        /// <summary>managed_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#managed_field IotIndexingConfiguration#managed_field}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationManagedField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfigurationManagedField[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfigurationManagedField).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _managedField = value;
            }
        }
    }
}
