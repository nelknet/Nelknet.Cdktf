using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2ManagedPrefixList
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2ManagedPrefixList.Ec2ManagedPrefixListEntry")]
    public class Ec2ManagedPrefixListEntry : aws.Ec2ManagedPrefixList.IEc2ManagedPrefixListEntry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#cidr Ec2ManagedPrefixList#cidr}.</summary>
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
        public string Cidr
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#description Ec2ManagedPrefixList#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
