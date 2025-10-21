using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkInterfaces
{
    [JsiiByValue(fqn: "aws.dataAwsNetworkInterfaces.DataAwsNetworkInterfacesTimeouts")]
    public class DataAwsNetworkInterfacesTimeouts : aws.DataAwsNetworkInterfaces.IDataAwsNetworkInterfacesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interfaces#read DataAwsNetworkInterfaces#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
