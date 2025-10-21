using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyDetectorFeature
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.guarddutyDetectorFeature.GuarddutyDetectorFeatureAdditionalConfiguration")]
    public class GuarddutyDetectorFeatureAdditionalConfiguration : aws.GuarddutyDetectorFeature.IGuarddutyDetectorFeatureAdditionalConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector_feature#name GuarddutyDetectorFeature#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector_feature#status GuarddutyDetectorFeature#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }
    }
}
