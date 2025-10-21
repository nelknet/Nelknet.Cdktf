using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2InstanceTypeOffering
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2InstanceTypeOfferingTimeouts), fullyQualifiedName: "aws.dataAwsEc2InstanceTypeOffering.DataAwsEc2InstanceTypeOfferingTimeouts")]
    public interface IDataAwsEc2InstanceTypeOfferingTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#read DataAwsEc2InstanceTypeOffering#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2InstanceTypeOfferingTimeouts), fullyQualifiedName: "aws.dataAwsEc2InstanceTypeOffering.DataAwsEc2InstanceTypeOfferingTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2InstanceTypeOffering.IDataAwsEc2InstanceTypeOfferingTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#read DataAwsEc2InstanceTypeOffering#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
