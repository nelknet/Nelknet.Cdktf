using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eksNodeGroup.EksNodeGroupScalingConfig")]
    public class EksNodeGroupScalingConfig : aws.EksNodeGroup.IEksNodeGroupScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#desired_size EksNodeGroup#desired_size}.</summary>
        [JsiiProperty(name: "desiredSize", typeJson: "{\"primitive\":\"number\"}")]
        public double DesiredSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#max_size EksNodeGroup#max_size}.</summary>
        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#min_size EksNodeGroup#min_size}.</summary>
        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        public double MinSize
        {
            get;
            set;
        }
    }
}
