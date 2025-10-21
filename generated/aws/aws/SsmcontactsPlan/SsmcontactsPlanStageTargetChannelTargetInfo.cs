using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmcontactsPlan.SsmcontactsPlanStageTargetChannelTargetInfo")]
    public class SsmcontactsPlanStageTargetChannelTargetInfo : aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetChannelTargetInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#contact_channel_id SsmcontactsPlan#contact_channel_id}.</summary>
        [JsiiProperty(name: "contactChannelId", typeJson: "{\"primitive\":\"string\"}")]
        public string ContactChannelId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#retry_interval_in_minutes SsmcontactsPlan#retry_interval_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retryIntervalInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetryIntervalInMinutes
        {
            get;
            set;
        }
    }
}
