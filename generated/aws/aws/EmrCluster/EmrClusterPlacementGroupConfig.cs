using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiByValue(fqn: "aws.emrCluster.EmrClusterPlacementGroupConfig")]
    public class EmrClusterPlacementGroupConfig : aws.EmrCluster.IEmrClusterPlacementGroupConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#instance_role EmrCluster#instance_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#placement_strategy EmrCluster#placement_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlacementStrategy
        {
            get;
            set;
        }
    }
}
