using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkInterface
{
    [JsiiByValue(fqn: "aws.dataAwsNetworkInterface.DataAwsNetworkInterfaceTimeouts")]
    public class DataAwsNetworkInterfaceTimeouts : aws.DataAwsNetworkInterface.IDataAwsNetworkInterfaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interface#read DataAwsNetworkInterface#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
