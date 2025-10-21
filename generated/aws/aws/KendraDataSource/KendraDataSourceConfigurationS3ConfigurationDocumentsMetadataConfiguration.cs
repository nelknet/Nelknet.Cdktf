using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceConfigurationS3ConfigurationDocumentsMetadataConfiguration")]
    public class KendraDataSourceConfigurationS3ConfigurationDocumentsMetadataConfiguration : aws.KendraDataSource.IKendraDataSourceConfigurationS3ConfigurationDocumentsMetadataConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#s3_prefix KendraDataSource#s3_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Prefix
        {
            get;
            set;
        }
    }
}
