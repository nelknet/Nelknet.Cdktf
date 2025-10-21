using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAnalyticsApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSources")]
    public class KinesisAnalyticsApplicationReferenceDataSources : aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSources
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#s3 KinesisAnalyticsApplication#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesS3\"}")]
        public aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesS3 S3
        {
            get;
            set;
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#schema KinesisAnalyticsApplication#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchema\"}")]
        public aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchema Schema
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#table_name KinesisAnalyticsApplication#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public string TableName
        {
            get;
            set;
        }
    }
}
