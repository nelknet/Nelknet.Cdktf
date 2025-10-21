using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SyntheticsCanary
{
    [JsiiInterface(nativeType: typeof(ISyntheticsCanaryArtifactConfigS3Encryption), fullyQualifiedName: "aws.syntheticsCanary.SyntheticsCanaryArtifactConfigS3Encryption")]
    public interface ISyntheticsCanaryArtifactConfigS3Encryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#encryption_mode SyntheticsCanary#encryption_mode}.</summary>
        [JsiiProperty(name: "encryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#kms_key_arn SyntheticsCanary#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISyntheticsCanaryArtifactConfigS3Encryption), fullyQualifiedName: "aws.syntheticsCanary.SyntheticsCanaryArtifactConfigS3Encryption")]
        internal sealed class _Proxy : DeputyBase, aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfigS3Encryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#encryption_mode SyntheticsCanary#encryption_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#kms_key_arn SyntheticsCanary#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
