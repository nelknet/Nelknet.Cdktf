using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2ManagedPrefixList
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2ManagedPrefixListTimeouts), fullyQualifiedName: "aws.dataAwsEc2ManagedPrefixList.DataAwsEc2ManagedPrefixListTimeouts")]
    public interface IDataAwsEc2ManagedPrefixListTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_list#read DataAwsEc2ManagedPrefixList#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2ManagedPrefixListTimeouts), fullyQualifiedName: "aws.dataAwsEc2ManagedPrefixList.DataAwsEc2ManagedPrefixListTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2ManagedPrefixList.IDataAwsEc2ManagedPrefixListTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_list#read DataAwsEc2ManagedPrefixList#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
