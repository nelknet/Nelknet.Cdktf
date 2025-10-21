using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedaccessEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.verifiedaccessEndpoint.VerifiedaccessEndpointLoadBalancerOptionsPortRange")]
    public class VerifiedaccessEndpointLoadBalancerOptionsPortRange : aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointLoadBalancerOptionsPortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#from_port VerifiedaccessEndpoint#from_port}.</summary>
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}")]
        public double FromPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#to_port VerifiedaccessEndpoint#to_port}.</summary>
        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}")]
        public double ToPort
        {
            get;
            set;
        }
    }
}
