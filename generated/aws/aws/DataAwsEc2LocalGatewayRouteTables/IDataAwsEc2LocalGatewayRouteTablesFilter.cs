using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2LocalGatewayRouteTables
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2LocalGatewayRouteTablesFilter), fullyQualifiedName: "aws.dataAwsEc2LocalGatewayRouteTables.DataAwsEc2LocalGatewayRouteTablesFilter")]
    public interface IDataAwsEc2LocalGatewayRouteTablesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_tables#name DataAwsEc2LocalGatewayRouteTables#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_tables#values DataAwsEc2LocalGatewayRouteTables#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2LocalGatewayRouteTablesFilter), fullyQualifiedName: "aws.dataAwsEc2LocalGatewayRouteTables.DataAwsEc2LocalGatewayRouteTablesFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2LocalGatewayRouteTables.IDataAwsEc2LocalGatewayRouteTablesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_tables#name DataAwsEc2LocalGatewayRouteTables#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_tables#values DataAwsEc2LocalGatewayRouteTables#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
