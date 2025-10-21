using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEbsEncryptionByDefault
{
    [JsiiInterface(nativeType: typeof(IDataAwsEbsEncryptionByDefaultTimeouts), fullyQualifiedName: "aws.dataAwsEbsEncryptionByDefault.DataAwsEbsEncryptionByDefaultTimeouts")]
    public interface IDataAwsEbsEncryptionByDefaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_encryption_by_default#read DataAwsEbsEncryptionByDefault#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEbsEncryptionByDefaultTimeouts), fullyQualifiedName: "aws.dataAwsEbsEncryptionByDefault.DataAwsEbsEncryptionByDefaultTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEbsEncryptionByDefault.IDataAwsEbsEncryptionByDefaultTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_encryption_by_default#read DataAwsEbsEncryptionByDefault#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
