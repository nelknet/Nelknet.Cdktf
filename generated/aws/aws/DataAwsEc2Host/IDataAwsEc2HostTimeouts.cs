using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2Host
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2HostTimeouts), fullyQualifiedName: "aws.dataAwsEc2Host.DataAwsEc2HostTimeouts")]
    public interface IDataAwsEc2HostTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_host#read DataAwsEc2Host#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2HostTimeouts), fullyQualifiedName: "aws.dataAwsEc2Host.DataAwsEc2HostTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2Host.IDataAwsEc2HostTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_host#read DataAwsEc2Host#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
