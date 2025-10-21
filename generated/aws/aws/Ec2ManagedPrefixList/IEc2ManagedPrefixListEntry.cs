using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2ManagedPrefixList
{
    [JsiiInterface(nativeType: typeof(IEc2ManagedPrefixListEntry), fullyQualifiedName: "aws.ec2ManagedPrefixList.Ec2ManagedPrefixListEntry")]
    public interface IEc2ManagedPrefixListEntry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#cidr Ec2ManagedPrefixList#cidr}.</summary>
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
        string Cidr
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#description Ec2ManagedPrefixList#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2ManagedPrefixListEntry), fullyQualifiedName: "aws.ec2ManagedPrefixList.Ec2ManagedPrefixListEntry")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2ManagedPrefixList.IEc2ManagedPrefixListEntry
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#cidr Ec2ManagedPrefixList#cidr}.</summary>
            [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
            public string Cidr
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#description Ec2ManagedPrefixList#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
