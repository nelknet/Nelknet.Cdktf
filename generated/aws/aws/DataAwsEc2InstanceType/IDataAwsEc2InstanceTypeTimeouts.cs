using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2InstanceType
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2InstanceTypeTimeouts), fullyQualifiedName: "aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeTimeouts")]
    public interface IDataAwsEc2InstanceTypeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type#read DataAwsEc2InstanceType#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2InstanceTypeTimeouts), fullyQualifiedName: "aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2InstanceType.IDataAwsEc2InstanceTypeTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type#read DataAwsEc2InstanceType#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
