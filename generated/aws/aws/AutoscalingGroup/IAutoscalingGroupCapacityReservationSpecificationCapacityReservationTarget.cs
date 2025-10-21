using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget")]
    public interface IAutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_reservation_ids AutoscalingGroup#capacity_reservation_ids}.</summary>
        [JsiiProperty(name: "capacityReservationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CapacityReservationIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_reservation_resource_group_arns AutoscalingGroup#capacity_reservation_resource_group_arns}.</summary>
        [JsiiProperty(name: "capacityReservationResourceGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CapacityReservationResourceGroupArns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingGroup.IAutoscalingGroupCapacityReservationSpecificationCapacityReservationTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_reservation_ids AutoscalingGroup#capacity_reservation_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CapacityReservationIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_reservation_resource_group_arns AutoscalingGroup#capacity_reservation_resource_group_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationResourceGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CapacityReservationResourceGroupArns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
