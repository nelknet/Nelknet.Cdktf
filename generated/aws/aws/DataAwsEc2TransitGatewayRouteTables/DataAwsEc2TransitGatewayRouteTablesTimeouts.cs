using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayRouteTables
{
    [JsiiByValue(fqn: "aws.dataAwsEc2TransitGatewayRouteTables.DataAwsEc2TransitGatewayRouteTablesTimeouts")]
    public class DataAwsEc2TransitGatewayRouteTablesTimeouts : aws.DataAwsEc2TransitGatewayRouteTables.IDataAwsEc2TransitGatewayRouteTablesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_tables#read DataAwsEc2TransitGatewayRouteTables#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
