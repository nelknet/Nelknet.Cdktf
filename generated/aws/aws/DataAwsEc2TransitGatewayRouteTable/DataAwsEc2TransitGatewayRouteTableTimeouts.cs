using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayRouteTable
{
    [JsiiByValue(fqn: "aws.dataAwsEc2TransitGatewayRouteTable.DataAwsEc2TransitGatewayRouteTableTimeouts")]
    public class DataAwsEc2TransitGatewayRouteTableTimeouts : aws.DataAwsEc2TransitGatewayRouteTable.IDataAwsEc2TransitGatewayRouteTableTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table#read DataAwsEc2TransitGatewayRouteTable#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
