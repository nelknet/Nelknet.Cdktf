using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.finspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationPortRange")]
    public class FinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationPortRange : aws.FinspaceKxEnvironment.IFinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationPortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#from FinspaceKxEnvironment#from}.</summary>
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"number\"}")]
        public double From
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#to FinspaceKxEnvironment#to}.</summary>
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"number\"}")]
        public double To
        {
            get;
            set;
        }
    }
}
