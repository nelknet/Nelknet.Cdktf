using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiInterface(nativeType: typeof(IEmrClusterPlacementGroupConfig), fullyQualifiedName: "aws.emrCluster.EmrClusterPlacementGroupConfig")]
    public interface IEmrClusterPlacementGroupConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#instance_role EmrCluster#instance_role}.</summary>
        [JsiiProperty(name: "instanceRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#placement_strategy EmrCluster#placement_strategy}.</summary>
        [JsiiProperty(name: "placementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlacementStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterPlacementGroupConfig), fullyQualifiedName: "aws.emrCluster.EmrClusterPlacementGroupConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EmrCluster.IEmrClusterPlacementGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#instance_role EmrCluster#instance_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#placement_strategy EmrCluster#placement_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "placementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlacementStrategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
