using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsKeyPair
{
    [JsiiInterface(nativeType: typeof(IDataAwsKeyPairTimeouts), fullyQualifiedName: "aws.dataAwsKeyPair.DataAwsKeyPairTimeouts")]
    public interface IDataAwsKeyPairTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/key_pair#read DataAwsKeyPair#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsKeyPairTimeouts), fullyQualifiedName: "aws.dataAwsKeyPair.DataAwsKeyPairTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsKeyPair.IDataAwsKeyPairTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/key_pair#read DataAwsKeyPair#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
