using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkAcls
{
    [JsiiByValue(fqn: "aws.dataAwsNetworkAcls.DataAwsNetworkAclsTimeouts")]
    public class DataAwsNetworkAclsTimeouts : aws.DataAwsNetworkAcls.IDataAwsNetworkAclsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_acls#read DataAwsNetworkAcls#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
