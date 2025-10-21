using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkAcls
{
    [JsiiInterface(nativeType: typeof(IDataAwsNetworkAclsTimeouts), fullyQualifiedName: "aws.dataAwsNetworkAcls.DataAwsNetworkAclsTimeouts")]
    public interface IDataAwsNetworkAclsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_acls#read DataAwsNetworkAcls#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsNetworkAclsTimeouts), fullyQualifiedName: "aws.dataAwsNetworkAcls.DataAwsNetworkAclsTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsNetworkAcls.IDataAwsNetworkAclsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_acls#read DataAwsNetworkAcls#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
