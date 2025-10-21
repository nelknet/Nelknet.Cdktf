using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersVirtualCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfo")]
    public class EmrcontainersVirtualClusterContainerProviderInfo : aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfo
    {
        /// <summary>eks_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster#eks_info EmrcontainersVirtualCluster#eks_info}
        /// </remarks>
        [JsiiProperty(name: "eksInfo", typeJson: "{\"fqn\":\"aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoEksInfo\"}")]
        public aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfoEksInfo EksInfo
        {
            get;
            set;
        }
    }
}
