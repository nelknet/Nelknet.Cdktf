using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2ManagedPrefixList
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEc2ManagedPrefixList.DataAwsEc2ManagedPrefixListFilter")]
    public class DataAwsEc2ManagedPrefixListFilter : aws.DataAwsEc2ManagedPrefixList.IDataAwsEc2ManagedPrefixListFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_list#name DataAwsEc2ManagedPrefixList#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_list#values DataAwsEc2ManagedPrefixList#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
