using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSecurityGroup
{
    [JsiiByValue(fqn: "aws.dataAwsSecurityGroup.DataAwsSecurityGroupTimeouts")]
    public class DataAwsSecurityGroupTimeouts : aws.DataAwsSecurityGroup.IDataAwsSecurityGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_group#read DataAwsSecurityGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
