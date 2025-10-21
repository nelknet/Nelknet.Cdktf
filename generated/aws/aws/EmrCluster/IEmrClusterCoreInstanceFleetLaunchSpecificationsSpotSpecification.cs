using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiInterface(nativeType: typeof(IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification), fullyQualifiedName: "aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification")]
    public interface IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#allocation_strategy EmrCluster#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string AllocationStrategy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#timeout_action EmrCluster#timeout_action}.</summary>
        [JsiiProperty(name: "timeoutAction", typeJson: "{\"primitive\":\"string\"}")]
        string TimeoutAction
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#timeout_duration_minutes EmrCluster#timeout_duration_minutes}.</summary>
        [JsiiProperty(name: "timeoutDurationMinutes", typeJson: "{\"primitive\":\"number\"}")]
        double TimeoutDurationMinutes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#block_duration_minutes EmrCluster#block_duration_minutes}.</summary>
        [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BlockDurationMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification), fullyQualifiedName: "aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#timeout_action EmrCluster#timeout_action}.</summary>
            [JsiiProperty(name: "timeoutAction", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeoutAction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#timeout_duration_minutes EmrCluster#timeout_duration_minutes}.</summary>
            [JsiiProperty(name: "timeoutDurationMinutes", typeJson: "{\"primitive\":\"number\"}")]
            public double TimeoutDurationMinutes
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#block_duration_minutes EmrCluster#block_duration_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BlockDurationMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
