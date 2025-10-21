using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamqueryScheduledQuery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMultiMeasureMappingsMultiMeasureAttributeMapping")]
    public class TimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMultiMeasureMappingsMultiMeasureAttributeMapping : aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryTargetConfigurationTimestreamConfigurationMultiMeasureMappingsMultiMeasureAttributeMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#measure_value_type TimestreamqueryScheduledQuery#measure_value_type}.</summary>
        [JsiiProperty(name: "measureValueType", typeJson: "{\"primitive\":\"string\"}")]
        public string MeasureValueType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#source_column TimestreamqueryScheduledQuery#source_column}.</summary>
        [JsiiProperty(name: "sourceColumn", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceColumn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#target_multi_measure_attribute_name TimestreamqueryScheduledQuery#target_multi_measure_attribute_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetMultiMeasureAttributeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetMultiMeasureAttributeName
        {
            get;
            set;
        }
    }
}
