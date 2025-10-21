using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsPath
{
    [JsiiByValue(fqn: "aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSource")]
    public class Ec2NetworkInsightsPathFilterAtSource : aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#destination_address Ec2NetworkInsightsPath#destination_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationAddress
        {
            get;
            set;
        }

        /// <summary>destination_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#destination_port_range Ec2NetworkInsightsPath#destination_port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceDestinationPortRange\"}", isOptional: true)]
        public aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSourceDestinationPortRange? DestinationPortRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#source_address Ec2NetworkInsightsPath#source_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceAddress
        {
            get;
            set;
        }

        /// <summary>source_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#source_port_range Ec2NetworkInsightsPath#source_port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceSourcePortRange\"}", isOptional: true)]
        public aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSourceSourcePortRange? SourcePortRange
        {
            get;
            set;
        }
    }
}
