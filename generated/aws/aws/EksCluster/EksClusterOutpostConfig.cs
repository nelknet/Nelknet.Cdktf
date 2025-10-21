using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eksCluster.EksClusterOutpostConfig")]
    public class EksClusterOutpostConfig : aws.EksCluster.IEksClusterOutpostConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#control_plane_instance_type EksCluster#control_plane_instance_type}.</summary>
        [JsiiProperty(name: "controlPlaneInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ControlPlaneInstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#outpost_arns EksCluster#outpost_arns}.</summary>
        [JsiiProperty(name: "outpostArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] OutpostArns
        {
            get;
            set;
        }

        /// <summary>control_plane_placement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#control_plane_placement EksCluster#control_plane_placement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "controlPlanePlacement", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfigControlPlanePlacement\"}", isOptional: true)]
        public aws.EksCluster.IEksClusterOutpostConfigControlPlanePlacement? ControlPlanePlacement
        {
            get;
            set;
        }
    }
}
