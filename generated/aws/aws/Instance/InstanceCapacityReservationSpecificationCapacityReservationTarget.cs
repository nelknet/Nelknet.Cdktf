using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiByValue(fqn: "aws.instance.InstanceCapacityReservationSpecificationCapacityReservationTarget")]
    public class InstanceCapacityReservationSpecificationCapacityReservationTarget : aws.Instance.IInstanceCapacityReservationSpecificationCapacityReservationTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#capacity_reservation_id Instance#capacity_reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#capacity_reservation_resource_group_arn Instance#capacity_reservation_resource_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationResourceGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationResourceGroupArn
        {
            get;
            set;
        }
    }
}
