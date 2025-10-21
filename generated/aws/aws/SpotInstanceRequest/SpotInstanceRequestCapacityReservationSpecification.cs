using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotInstanceRequest
{
    [JsiiByValue(fqn: "aws.spotInstanceRequest.SpotInstanceRequestCapacityReservationSpecification")]
    public class SpotInstanceRequestCapacityReservationSpecification : aws.SpotInstanceRequest.ISpotInstanceRequestCapacityReservationSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#capacity_reservation_preference SpotInstanceRequest#capacity_reservation_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationPreference
        {
            get;
            set;
        }

        /// <summary>capacity_reservation_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#capacity_reservation_target SpotInstanceRequest#capacity_reservation_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"fqn\":\"aws.spotInstanceRequest.SpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget\"}", isOptional: true)]
        public aws.SpotInstanceRequest.ISpotInstanceRequestCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget
        {
            get;
            set;
        }
    }
}
