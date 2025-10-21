using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification")]
    public class EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification : aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#allocation_strategy EmrCluster#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string AllocationStrategy
        {
            get;
            set;
        }
    }
}
