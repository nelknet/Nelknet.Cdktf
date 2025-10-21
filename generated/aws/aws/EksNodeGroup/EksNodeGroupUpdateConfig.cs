using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    [JsiiByValue(fqn: "aws.eksNodeGroup.EksNodeGroupUpdateConfig")]
    public class EksNodeGroupUpdateConfig : aws.EksNodeGroup.IEksNodeGroupUpdateConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#max_unavailable EksNodeGroup#max_unavailable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUnavailable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#max_unavailable_percentage EksNodeGroup#max_unavailable_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnavailablePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUnavailablePercentage
        {
            get;
            set;
        }
    }
}
