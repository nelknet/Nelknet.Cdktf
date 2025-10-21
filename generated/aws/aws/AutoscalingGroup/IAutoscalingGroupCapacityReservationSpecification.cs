using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupCapacityReservationSpecification), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupCapacityReservationSpecification")]
    public interface IAutoscalingGroupCapacityReservationSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_reservation_preference AutoscalingGroup#capacity_reservation_preference}.</summary>
        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityReservationPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>capacity_reservation_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_reservation_target AutoscalingGroup#capacity_reservation_target}
        /// </remarks>
        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AutoscalingGroup.IAutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupCapacityReservationSpecification), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupCapacityReservationSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingGroup.IAutoscalingGroupCapacityReservationSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_reservation_preference AutoscalingGroup#capacity_reservation_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityReservationPreference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>capacity_reservation_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_reservation_target AutoscalingGroup#capacity_reservation_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true)]
            public aws.AutoscalingGroup.IAutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget
            {
                get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget?>();
            }
        }
    }
}
