using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QbusinessApplication
{
    [JsiiInterface(nativeType: typeof(IQbusinessApplicationEncryptionConfiguration), fullyQualifiedName: "aws.qbusinessApplication.QbusinessApplicationEncryptionConfiguration")]
    public interface IQbusinessApplicationEncryptionConfiguration
    {
        /// <summary>The identifier of the AWS KMS key that is used to encrypt your data.</summary>
        /// <remarks>
        /// Amazon Q doesn't support asymmetric keys.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qbusiness_application#kms_key_id QbusinessApplication#kms_key_id}
        /// </remarks>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string KmsKeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQbusinessApplicationEncryptionConfiguration), fullyQualifiedName: "aws.qbusinessApplication.QbusinessApplicationEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.QbusinessApplication.IQbusinessApplicationEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The identifier of the AWS KMS key that is used to encrypt your data.</summary>
            /// <remarks>
            /// Amazon Q doesn't support asymmetric keys.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qbusiness_application#kms_key_id QbusinessApplication#kms_key_id}
            /// </remarks>
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KmsKeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
