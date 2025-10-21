using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEbsDefaultKmsKey
{
    [JsiiInterface(nativeType: typeof(IDataAwsEbsDefaultKmsKeyTimeouts), fullyQualifiedName: "aws.dataAwsEbsDefaultKmsKey.DataAwsEbsDefaultKmsKeyTimeouts")]
    public interface IDataAwsEbsDefaultKmsKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_default_kms_key#read DataAwsEbsDefaultKmsKey#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEbsDefaultKmsKeyTimeouts), fullyQualifiedName: "aws.dataAwsEbsDefaultKmsKey.DataAwsEbsDefaultKmsKeyTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEbsDefaultKmsKey.IDataAwsEbsDefaultKmsKeyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_default_kms_key#read DataAwsEbsDefaultKmsKey#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
