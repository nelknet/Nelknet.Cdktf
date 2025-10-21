using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotInstanceRequest
{
    [JsiiByValue(fqn: "aws.spotInstanceRequest.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget")]
    public class SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget : aws.SpotInstanceRequest.ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#capacity_reservation_id SpotInstanceRequest#capacity_reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#capacity_reservation_resource_group_arn SpotInstanceRequest#capacity_reservation_resource_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationResourceGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationResourceGroupArn
        {
            get;
            set;
        }
    }
}
