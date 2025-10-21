using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcPeeringConnections
{
    [JsiiByValue(fqn: "aws.dataAwsVpcPeeringConnections.DataAwsVpcPeeringConnectionsTimeouts")]
    public class DataAwsVpcPeeringConnectionsTimeouts : aws.DataAwsVpcPeeringConnections.IDataAwsVpcPeeringConnectionsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connections#read DataAwsVpcPeeringConnections#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
