using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2CoipPool
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2CoipPoolTimeouts), fullyQualifiedName: "aws.dataAwsEc2CoipPool.DataAwsEc2CoipPoolTimeouts")]
    public interface IDataAwsEc2CoipPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pool#read DataAwsEc2CoipPool#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2CoipPoolTimeouts), fullyQualifiedName: "aws.dataAwsEc2CoipPool.DataAwsEc2CoipPoolTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2CoipPool.IDataAwsEc2CoipPoolTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pool#read DataAwsEc2CoipPool#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
