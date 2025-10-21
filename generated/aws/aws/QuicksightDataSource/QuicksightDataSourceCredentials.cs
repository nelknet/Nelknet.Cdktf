using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiByValue(fqn: "aws.quicksightDataSource.QuicksightDataSourceCredentials")]
    public class QuicksightDataSourceCredentials : aws.QuicksightDataSource.IQuicksightDataSourceCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#copy_source_arn QuicksightDataSource#copy_source_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copySourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CopySourceArn
        {
            get;
            set;
        }

        /// <summary>credential_pair block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#credential_pair QuicksightDataSource#credential_pair}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "credentialPair", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceCredentialsCredentialPair\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceCredentialsCredentialPair? CredentialPair
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#secret_arn QuicksightDataSource#secret_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretArn
        {
            get;
            set;
        }
    }
}
