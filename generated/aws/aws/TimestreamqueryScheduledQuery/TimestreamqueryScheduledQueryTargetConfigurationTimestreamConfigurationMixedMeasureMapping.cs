using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamqueryScheduledQuery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMapping")]
    public class TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMapping : aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#measure_value_type TimestreamqueryScheduledQuery#measure_value_type}.</summary>
        [JsiiProperty(name: "measureValueType", typeJson: "{\"primitive\":\"string\"}")]
        public string MeasureValueType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#measure_name TimestreamqueryScheduledQuery#measure_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "measureName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MeasureName
        {
            get;
            set;
        }

        private object? _multiMeasureAttributeMapping;

        /// <summary>multi_measure_attribute_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#multi_measure_attribute_mapping TimestreamqueryScheduledQuery#multi_measure_attribute_mapping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "multiMeasureAttributeMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMappingMultiMeasureAttributeMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MultiMeasureAttributeMapping
        {
            get => _multiMeasureAttributeMapping;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMappingMultiMeasureAttributeMapping[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMappingMultiMeasureAttributeMapping).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _multiMeasureAttributeMapping = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#source_column TimestreamqueryScheduledQuery#source_column}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceColumn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceColumn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#target_measure_name TimestreamqueryScheduledQuery#target_measure_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetMeasureName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetMeasureName
        {
            get;
            set;
        }
    }
}
