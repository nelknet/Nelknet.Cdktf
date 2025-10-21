using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchCompositeAlarm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchCompositeAlarm.CloudwatchCompositeAlarmActionsSuppressor")]
    public class CloudwatchCompositeAlarmActionsSuppressor : aws.CloudwatchCompositeAlarm.ICloudwatchCompositeAlarmActionsSuppressor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#alarm CloudwatchCompositeAlarm#alarm}.</summary>
        [JsiiProperty(name: "alarm", typeJson: "{\"primitive\":\"string\"}")]
        public string Alarm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#extension_period CloudwatchCompositeAlarm#extension_period}.</summary>
        [JsiiProperty(name: "extensionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public double ExtensionPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#wait_period CloudwatchCompositeAlarm#wait_period}.</summary>
        [JsiiProperty(name: "waitPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public double WaitPeriod
        {
            get;
            set;
        }
    }
}
