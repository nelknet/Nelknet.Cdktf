using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2ManagedPrefixLists
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2ManagedPrefixListsFilter), fullyQualifiedName: "aws.dataAwsEc2ManagedPrefixLists.DataAwsEc2ManagedPrefixListsFilter")]
    public interface IDataAwsEc2ManagedPrefixListsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_lists#name DataAwsEc2ManagedPrefixLists#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_lists#values DataAwsEc2ManagedPrefixLists#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2ManagedPrefixListsFilter), fullyQualifiedName: "aws.dataAwsEc2ManagedPrefixLists.DataAwsEc2ManagedPrefixListsFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2ManagedPrefixLists.IDataAwsEc2ManagedPrefixListsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_lists#name DataAwsEc2ManagedPrefixLists#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_lists#values DataAwsEc2ManagedPrefixLists#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
