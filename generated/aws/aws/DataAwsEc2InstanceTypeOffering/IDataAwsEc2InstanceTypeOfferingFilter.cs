using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2InstanceTypeOffering
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2InstanceTypeOfferingFilter), fullyQualifiedName: "aws.dataAwsEc2InstanceTypeOffering.DataAwsEc2InstanceTypeOfferingFilter")]
    public interface IDataAwsEc2InstanceTypeOfferingFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#name DataAwsEc2InstanceTypeOffering#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#values DataAwsEc2InstanceTypeOffering#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2InstanceTypeOfferingFilter), fullyQualifiedName: "aws.dataAwsEc2InstanceTypeOffering.DataAwsEc2InstanceTypeOfferingFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2InstanceTypeOffering.IDataAwsEc2InstanceTypeOfferingFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#name DataAwsEc2InstanceTypeOffering#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#values DataAwsEc2InstanceTypeOffering#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
