using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSource.QuicksightDataSourceParametersS3")]
    public class QuicksightDataSourceParametersS3 : aws.QuicksightDataSource.IQuicksightDataSourceParametersS3
    {
        /// <summary>manifest_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#manifest_file_location QuicksightDataSource#manifest_file_location}
        /// </remarks>
        [JsiiProperty(name: "manifestFileLocation", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3ManifestFileLocation\"}")]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersS3ManifestFileLocation ManifestFileLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#role_arn QuicksightDataSource#role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleArn
        {
            get;
            set;
        }
    }
}
