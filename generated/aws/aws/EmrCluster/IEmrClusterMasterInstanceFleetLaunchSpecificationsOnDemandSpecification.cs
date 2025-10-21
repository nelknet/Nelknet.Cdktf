using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiInterface(nativeType: typeof(IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification), fullyQualifiedName: "aws.emrCluster.EmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification")]
    public interface IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#allocation_strategy EmrCluster#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string AllocationStrategy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification), fullyQualifiedName: "aws.emrCluster.EmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.EmrCluster.IEmrClusterMasterInstanceFleetLaunchSpecificationsOnDemandSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#allocation_strategy EmrCluster#allocation_strategy}.</summary>
            [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string AllocationStrategy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
