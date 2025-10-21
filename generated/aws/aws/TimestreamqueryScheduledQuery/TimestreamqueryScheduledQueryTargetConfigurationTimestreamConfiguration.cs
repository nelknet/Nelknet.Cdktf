using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamqueryScheduledQuery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfiguration")]
    public class TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfiguration : aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#database_name TimestreamqueryScheduledQuery#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#table_name TimestreamqueryScheduledQuery#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public string TableName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#time_column TimestreamqueryScheduledQuery#time_column}.</summary>
        [JsiiProperty(name: "timeColumn", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeColumn
        {
            get;
            set;
        }

        private object? _dimensionMapping;

        /// <summary>dimension_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#dimension_mapping TimestreamqueryScheduledQuery#dimension_mapping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimensionMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationDimensionMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DimensionMapping
        {
            get => _dimensionMapping;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationDimensionMapping[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationDimensionMapping).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dimensionMapping = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#measure_name_column TimestreamqueryScheduledQuery#measure_name_column}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "measureNameColumn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MeasureNameColumn
        {
            get;
            set;
        }

        private object? _mixedMeasureMapping;

        /// <summary>mixed_measure_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#mixed_measure_mapping TimestreamqueryScheduledQuery#mixed_measure_mapping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mixedMeasureMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MixedMeasureMapping
        {
            get => _mixedMeasureMapping;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMapping[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMapping).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mixedMeasureMapping = value;
            }
        }

        private object? _multiMeasureMappings;

        /// <summary>multi_measure_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#multi_measure_mappings TimestreamqueryScheduledQuery#multi_measure_mappings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "multiMeasureMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMultiMeasureMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MultiMeasureMappings
        {
            get => _multiMeasureMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMultiMeasureMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMultiMeasureMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _multiMeasureMappings = value;
            }
        }
    }
}
