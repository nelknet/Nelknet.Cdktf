using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiInterface(nativeType: typeof(IInstanceCapacityReservationSpecificationCapacityReservationTarget), fullyQualifiedName: "aws.instance.InstanceCapacityReservationSpecificationCapacityReservationTarget")]
    public interface IInstanceCapacityReservationSpecificationCapacityReservationTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#capacity_reservation_id Instance#capacity_reservation_id}.</summary>
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityReservationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#capacity_reservation_resource_group_arn Instance#capacity_reservation_resource_group_arn}.</summary>
        [JsiiProperty(name: "capacityReservationResourceGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityReservationResourceGroupArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceCapacityReservationSpecificationCapacityReservationTarget), fullyQualifiedName: "aws.instance.InstanceCapacityReservationSpecificationCapacityReservationTarget")]
        internal sealed class _Proxy : DeputyBase, aws.Instance.IInstanceCapacityReservationSpecificationCapacityReservationTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#capacity_reservation_id Instance#capacity_reservation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityReservationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#capacity_reservation_resource_group_arn Instance#capacity_reservation_resource_group_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationResourceGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityReservationResourceGroupArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
