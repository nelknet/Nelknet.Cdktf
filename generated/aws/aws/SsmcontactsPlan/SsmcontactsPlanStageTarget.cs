using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsPlan
{
    [JsiiByValue(fqn: "aws.ssmcontactsPlan.SsmcontactsPlanStageTarget")]
    public class SsmcontactsPlanStageTarget : aws.SsmcontactsPlan.ISsmcontactsPlanStageTarget
    {
        /// <summary>channel_target_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#channel_target_info SsmcontactsPlan#channel_target_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "channelTargetInfo", typeJson: "{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTargetChannelTargetInfo\"}", isOptional: true)]
        public aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetChannelTargetInfo? ChannelTargetInfo
        {
            get;
            set;
        }

        /// <summary>contact_target_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#contact_target_info SsmcontactsPlan#contact_target_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contactTargetInfo", typeJson: "{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTargetContactTargetInfo\"}", isOptional: true)]
        public aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetContactTargetInfo? ContactTargetInfo
        {
            get;
            set;
        }
    }
}
