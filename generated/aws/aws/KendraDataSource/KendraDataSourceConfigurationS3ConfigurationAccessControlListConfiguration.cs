using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceConfigurationS3ConfigurationAccessControlListConfiguration")]
    public class KendraDataSourceConfigurationS3ConfigurationAccessControlListConfiguration : aws.KendraDataSource.IKendraDataSourceConfigurationS3ConfigurationAccessControlListConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#key_path KendraDataSource#key_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyPath
        {
            get;
            set;
        }
    }
}
