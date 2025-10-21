using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueJob
{
    [JsiiByValue(fqn: "aws.glueJob.GlueJobNotificationProperty")]
    public class GlueJobNotificationProperty : aws.GlueJob.IGlueJobNotificationProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#notify_delay_after GlueJob#notify_delay_after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notifyDelayAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NotifyDelayAfter
        {
            get;
            set;
        }
    }
}
