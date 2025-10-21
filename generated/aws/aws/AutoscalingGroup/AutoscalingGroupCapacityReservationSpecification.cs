using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupCapacityReservationSpecification")]
    public class AutoscalingGroupCapacityReservationSpecification : aws.AutoscalingGroup.IAutoscalingGroupCapacityReservationSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_reservation_preference AutoscalingGroup#capacity_reservation_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationPreference
        {
            get;
            set;
        }

        /// <summary>capacity_reservation_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_reservation_target AutoscalingGroup#capacity_reservation_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget
        {
            get;
            set;
        }
    }
}
