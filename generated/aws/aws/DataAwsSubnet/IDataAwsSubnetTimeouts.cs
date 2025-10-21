using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSubnet
{
    [JsiiInterface(nativeType: typeof(IDataAwsSubnetTimeouts), fullyQualifiedName: "aws.dataAwsSubnet.DataAwsSubnetTimeouts")]
    public interface IDataAwsSubnetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#read DataAwsSubnet#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsSubnetTimeouts), fullyQualifiedName: "aws.dataAwsSubnet.DataAwsSubnetTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsSubnet.IDataAwsSubnetTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#read DataAwsSubnet#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
