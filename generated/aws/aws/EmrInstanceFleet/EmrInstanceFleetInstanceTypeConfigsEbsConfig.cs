using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrInstanceFleet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrInstanceFleet.EmrInstanceFleetInstanceTypeConfigsEbsConfig")]
    public class EmrInstanceFleetInstanceTypeConfigsEbsConfig : aws.EmrInstanceFleet.IEmrInstanceFleetInstanceTypeConfigsEbsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#size EmrInstanceFleet#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public double Size
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#type EmrInstanceFleet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#iops EmrInstanceFleet#iops}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Iops
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_fleet#volumes_per_instance EmrInstanceFleet#volumes_per_instance}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumesPerInstance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VolumesPerInstance
        {
            get;
            set;
        }
    }
}
