using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceConfigurationS3Configuration")]
    public class KendraDataSourceConfigurationS3Configuration : aws.KendraDataSource.IKendraDataSourceConfigurationS3Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#bucket_name KendraDataSource#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }

        /// <summary>access_control_list_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#access_control_list_configuration KendraDataSource#access_control_list_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessControlListConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationS3ConfigurationAccessControlListConfiguration\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceConfigurationS3ConfigurationAccessControlListConfiguration? AccessControlListConfiguration
        {
            get;
            set;
        }

        /// <summary>documents_metadata_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#documents_metadata_configuration KendraDataSource#documents_metadata_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "documentsMetadataConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationS3ConfigurationDocumentsMetadataConfiguration\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceConfigurationS3ConfigurationDocumentsMetadataConfiguration? DocumentsMetadataConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#exclusion_patterns KendraDataSource#exclusion_patterns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exclusionPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExclusionPatterns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#inclusion_patterns KendraDataSource#inclusion_patterns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inclusionPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? InclusionPatterns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#inclusion_prefixes KendraDataSource#inclusion_prefixes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inclusionPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? InclusionPrefixes
        {
            get;
            set;
        }
    }
}
