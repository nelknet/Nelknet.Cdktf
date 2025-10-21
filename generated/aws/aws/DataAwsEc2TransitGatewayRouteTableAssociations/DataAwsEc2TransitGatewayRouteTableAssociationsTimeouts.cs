using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayRouteTableAssociations
{
    [JsiiByValue(fqn: "aws.dataAwsEc2TransitGatewayRouteTableAssociations.DataAwsEc2TransitGatewayRouteTableAssociationsTimeouts")]
    public class DataAwsEc2TransitGatewayRouteTableAssociationsTimeouts : aws.DataAwsEc2TransitGatewayRouteTableAssociations.IDataAwsEc2TransitGatewayRouteTableAssociationsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_associations#read DataAwsEc2TransitGatewayRouteTableAssociations#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
