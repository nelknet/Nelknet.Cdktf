using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2LocalGatewayRouteTables
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2LocalGatewayRouteTablesTimeouts), fullyQualifiedName: "aws.dataAwsEc2LocalGatewayRouteTables.DataAwsEc2LocalGatewayRouteTablesTimeouts")]
    public interface IDataAwsEc2LocalGatewayRouteTablesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_tables#read DataAwsEc2LocalGatewayRouteTables#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2LocalGatewayRouteTablesTimeouts), fullyQualifiedName: "aws.dataAwsEc2LocalGatewayRouteTables.DataAwsEc2LocalGatewayRouteTablesTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2LocalGatewayRouteTables.IDataAwsEc2LocalGatewayRouteTablesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_tables#read DataAwsEc2LocalGatewayRouteTables#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
