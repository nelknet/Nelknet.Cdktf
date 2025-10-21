using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterUpgradePolicy")]
    public class EksClusterUpgradePolicy : aws.EksCluster.IEksClusterUpgradePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#support_type EksCluster#support_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "supportType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SupportType
        {
            get;
            set;
        }
    }
}
