using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.finspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfiguration")]
    public class FinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfiguration : aws.FinspaceKxEnvironment.IFinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#cidr_block FinspaceKxEnvironment#cidr_block}.</summary>
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public string CidrBlock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#protocol FinspaceKxEnvironment#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#rule_action FinspaceKxEnvironment#rule_action}.</summary>
        [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#rule_number FinspaceKxEnvironment#rule_number}.</summary>
        [JsiiProperty(name: "ruleNumber", typeJson: "{\"primitive\":\"number\"}")]
        public double RuleNumber
        {
            get;
            set;
        }

        /// <summary>icmp_type_code block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#icmp_type_code FinspaceKxEnvironment#icmp_type_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "icmpTypeCode", typeJson: "{\"fqn\":\"aws.finspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationIcmpTypeCode\"}", isOptional: true)]
        public aws.FinspaceKxEnvironment.IFinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationIcmpTypeCode? IcmpTypeCode
        {
            get;
            set;
        }

        /// <summary>port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#port_range FinspaceKxEnvironment#port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portRange", typeJson: "{\"fqn\":\"aws.finspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationPortRange\"}", isOptional: true)]
        public aws.FinspaceKxEnvironment.IFinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfigurationPortRange? PortRange
        {
            get;
            set;
        }
    }
}
