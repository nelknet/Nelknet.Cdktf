using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceParametersS3), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersS3")]
    public interface IQuicksightDataSourceParametersS3
    {
        /// <summary>manifest_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#manifest_file_location QuicksightDataSource#manifest_file_location}
        /// </remarks>
        [JsiiProperty(name: "manifestFileLocation", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3ManifestFileLocation\"}")]
        aws.QuicksightDataSource.IQuicksightDataSourceParametersS3ManifestFileLocation ManifestFileLocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#role_arn QuicksightDataSource#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceParametersS3), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersS3")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSource.IQuicksightDataSourceParametersS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>manifest_file_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#manifest_file_location QuicksightDataSource#manifest_file_location}
            /// </remarks>
            [JsiiProperty(name: "manifestFileLocation", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3ManifestFileLocation\"}")]
            public aws.QuicksightDataSource.IQuicksightDataSourceParametersS3ManifestFileLocation ManifestFileLocation
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersS3ManifestFileLocation>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#role_arn QuicksightDataSource#role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
