using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamqueryScheduledQuery
{
    [JsiiInterface(nativeType: typeof(ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMapping), fullyQualifiedName: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMapping")]
    public interface ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#measure_value_type TimestreamqueryScheduledQuery#measure_value_type}.</summary>
        [JsiiProperty(name: "measureValueType", typeJson: "{\"primitive\":\"string\"}")]
        string MeasureValueType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#measure_name TimestreamqueryScheduledQuery#measure_name}.</summary>
        [JsiiProperty(name: "measureName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MeasureName
        {
            get
            {
                return null;
            }
        }

        /// <summary>multi_measure_attribute_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#multi_measure_attribute_mapping TimestreamqueryScheduledQuery#multi_measure_attribute_mapping}
        /// </remarks>
        [JsiiProperty(name: "multiMeasureAttributeMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMappingMultiMeasureAttributeMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MultiMeasureAttributeMapping
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#source_column TimestreamqueryScheduledQuery#source_column}.</summary>
        [JsiiProperty(name: "sourceColumn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceColumn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#target_measure_name TimestreamqueryScheduledQuery#target_measure_name}.</summary>
        [JsiiProperty(name: "targetMeasureName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetMeasureName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMapping), fullyQualifiedName: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMapping")]
        internal sealed class _Proxy : DeputyBase, aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#measure_value_type TimestreamqueryScheduledQuery#measure_value_type}.</summary>
            [JsiiProperty(name: "measureValueType", typeJson: "{\"primitive\":\"string\"}")]
            public string MeasureValueType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#measure_name TimestreamqueryScheduledQuery#measure_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "measureName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MeasureName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>multi_measure_attribute_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#multi_measure_attribute_mapping TimestreamqueryScheduledQuery#multi_measure_attribute_mapping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "multiMeasureAttributeMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMixedMeasureMappingMultiMeasureAttributeMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MultiMeasureAttributeMapping
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#source_column TimestreamqueryScheduledQuery#source_column}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceColumn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceColumn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#target_measure_name TimestreamqueryScheduledQuery#target_measure_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetMeasureName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetMeasureName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
