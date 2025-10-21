using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAnalyticsApplication
{
    [JsiiByValue(fqn: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationInputsSchemaRecordFormat")]
    public class KinesisAnalyticsApplicationInputsSchemaRecordFormat : aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationInputsSchemaRecordFormat
    {
        /// <summary>mapping_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#mapping_parameters KinesisAnalyticsApplication#mapping_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mappingParameters", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters\"}", isOptional: true)]
        public aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters? MappingParameters
        {
            get;
            set;
        }
    }
}
