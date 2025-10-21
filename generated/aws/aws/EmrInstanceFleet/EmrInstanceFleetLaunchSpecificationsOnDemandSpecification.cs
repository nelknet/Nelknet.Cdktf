using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrInstanceFleet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrInstanceFleet.EmrInstanceFleetLaunchSpecificationsOnDemandSpecification")]
    public class EmrInstanceFleetLaunchSpecificationsOnDemandSpecification : aws.EmrInstanceFleet.IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#allocation_strategy EmrInstanceFleet#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string AllocationStrategy
        {
            get;
            set;
        }
    }
}
