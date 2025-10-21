using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2ManagedPrefixLists
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEc2ManagedPrefixLists.DataAwsEc2ManagedPrefixListsFilter")]
    public class DataAwsEc2ManagedPrefixListsFilter : aws.DataAwsEc2ManagedPrefixLists.IDataAwsEc2ManagedPrefixListsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_lists#name DataAwsEc2ManagedPrefixLists#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_lists#values DataAwsEc2ManagedPrefixLists#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
