using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2TransitGatewayMulticastDomain
{
    [JsiiByValue(fqn: "aws.ec2TransitGatewayMulticastDomain.Ec2TransitGatewayMulticastDomainTimeouts")]
    public class Ec2TransitGatewayMulticastDomainTimeouts : aws.Ec2TransitGatewayMulticastDomain.IEc2TransitGatewayMulticastDomainTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain#create Ec2TransitGatewayMulticastDomain#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain#delete Ec2TransitGatewayMulticastDomain#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
