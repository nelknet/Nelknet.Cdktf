using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceCredentials), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceCredentials")]
    public interface IQuicksightDataSourceCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#copy_source_arn QuicksightDataSource#copy_source_arn}.</summary>
        [JsiiProperty(name: "copySourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CopySourceArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>credential_pair block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#credential_pair QuicksightDataSource#credential_pair}
        /// </remarks>
        [JsiiProperty(name: "credentialPair", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceCredentialsCredentialPair\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSource.IQuicksightDataSourceCredentialsCredentialPair? CredentialPair
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#secret_arn QuicksightDataSource#secret_arn}.</summary>
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceCredentials), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceCredentials")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSource.IQuicksightDataSourceCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#copy_source_arn QuicksightDataSource#copy_source_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "copySourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CopySourceArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>credential_pair block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#credential_pair QuicksightDataSource#credential_pair}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentialPair", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceCredentialsCredentialPair\"}", isOptional: true)]
            public aws.QuicksightDataSource.IQuicksightDataSourceCredentialsCredentialPair? CredentialPair
            {
                get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceCredentialsCredentialPair?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#secret_arn QuicksightDataSource#secret_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
