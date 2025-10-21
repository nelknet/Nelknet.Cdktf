using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayMulticastDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEc2TransitGatewayMulticastDomain.DataAwsEc2TransitGatewayMulticastDomainFilter")]
    public class DataAwsEc2TransitGatewayMulticastDomainFilter : aws.DataAwsEc2TransitGatewayMulticastDomain.IDataAwsEc2TransitGatewayMulticastDomainFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_multicast_domain#name DataAwsEc2TransitGatewayMulticastDomain#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_multicast_domain#values DataAwsEc2TransitGatewayMulticastDomain#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
