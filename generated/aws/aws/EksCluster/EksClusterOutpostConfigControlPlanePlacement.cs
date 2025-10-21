using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eksCluster.EksClusterOutpostConfigControlPlanePlacement")]
    public class EksClusterOutpostConfigControlPlanePlacement : aws.EksCluster.IEksClusterOutpostConfigControlPlanePlacement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#group_name EksCluster#group_name}.</summary>
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}")]
        public string GroupName
        {
            get;
            set;
        }
    }
}
