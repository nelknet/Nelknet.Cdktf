using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyMemberDetectorFeature
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.guarddutyMemberDetectorFeature.GuarddutyMemberDetectorFeatureAdditionalConfiguration")]
    public class GuarddutyMemberDetectorFeatureAdditionalConfiguration : aws.GuarddutyMemberDetectorFeature.IGuarddutyMemberDetectorFeatureAdditionalConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member_detector_feature#name GuarddutyMemberDetectorFeature#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member_detector_feature#status GuarddutyMemberDetectorFeature#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }
    }
}
