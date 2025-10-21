using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSecurityGroups
{
    [JsiiByValue(fqn: "aws.dataAwsSecurityGroups.DataAwsSecurityGroupsTimeouts")]
    public class DataAwsSecurityGroupsTimeouts : aws.DataAwsSecurityGroups.IDataAwsSecurityGroupsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_groups#read DataAwsSecurityGroups#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
