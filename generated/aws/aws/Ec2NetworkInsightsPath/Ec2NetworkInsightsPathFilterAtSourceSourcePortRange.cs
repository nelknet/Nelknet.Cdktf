using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsPath
{
    [JsiiByValue(fqn: "aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceSourcePortRange")]
    public class Ec2NetworkInsightsPathFilterAtSourceSourcePortRange : aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSourceSourcePortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#from_port Ec2NetworkInsightsPath#from_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FromPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#to_port Ec2NetworkInsightsPath#to_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ToPort
        {
            get;
            set;
        }
    }
}
