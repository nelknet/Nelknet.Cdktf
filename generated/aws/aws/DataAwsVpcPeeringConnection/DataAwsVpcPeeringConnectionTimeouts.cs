using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcPeeringConnection
{
    [JsiiByValue(fqn: "aws.dataAwsVpcPeeringConnection.DataAwsVpcPeeringConnectionTimeouts")]
    public class DataAwsVpcPeeringConnectionTimeouts : aws.DataAwsVpcPeeringConnection.IDataAwsVpcPeeringConnectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#read DataAwsVpcPeeringConnection#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
