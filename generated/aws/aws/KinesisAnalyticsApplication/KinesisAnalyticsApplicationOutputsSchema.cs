using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAnalyticsApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationOutputsSchema")]
    public class KinesisAnalyticsApplicationOutputsSchema : aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#record_format_type KinesisAnalyticsApplication#record_format_type}.</summary>
        [JsiiProperty(name: "recordFormatType", typeJson: "{\"primitive\":\"string\"}")]
        public string RecordFormatType
        {
            get;
            set;
        }
    }
}
