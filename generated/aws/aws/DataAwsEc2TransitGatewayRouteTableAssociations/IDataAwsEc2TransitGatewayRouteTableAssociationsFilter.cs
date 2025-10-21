using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayRouteTableAssociations
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2TransitGatewayRouteTableAssociationsFilter), fullyQualifiedName: "aws.dataAwsEc2TransitGatewayRouteTableAssociations.DataAwsEc2TransitGatewayRouteTableAssociationsFilter")]
    public interface IDataAwsEc2TransitGatewayRouteTableAssociationsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_associations#name DataAwsEc2TransitGatewayRouteTableAssociations#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_associations#values DataAwsEc2TransitGatewayRouteTableAssociations#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2TransitGatewayRouteTableAssociationsFilter), fullyQualifiedName: "aws.dataAwsEc2TransitGatewayRouteTableAssociations.DataAwsEc2TransitGatewayRouteTableAssociationsFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2TransitGatewayRouteTableAssociations.IDataAwsEc2TransitGatewayRouteTableAssociationsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_associations#name DataAwsEc2TransitGatewayRouteTableAssociations#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_associations#values DataAwsEc2TransitGatewayRouteTableAssociations#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
