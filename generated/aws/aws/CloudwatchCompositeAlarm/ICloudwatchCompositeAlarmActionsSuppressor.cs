using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchCompositeAlarm
{
    [JsiiInterface(nativeType: typeof(ICloudwatchCompositeAlarmActionsSuppressor), fullyQualifiedName: "aws.cloudwatchCompositeAlarm.CloudwatchCompositeAlarmActionsSuppressor")]
    public interface ICloudwatchCompositeAlarmActionsSuppressor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#alarm CloudwatchCompositeAlarm#alarm}.</summary>
        [JsiiProperty(name: "alarm", typeJson: "{\"primitive\":\"string\"}")]
        string Alarm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#extension_period CloudwatchCompositeAlarm#extension_period}.</summary>
        [JsiiProperty(name: "extensionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        double ExtensionPeriod
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#wait_period CloudwatchCompositeAlarm#wait_period}.</summary>
        [JsiiProperty(name: "waitPeriod", typeJson: "{\"primitive\":\"number\"}")]
        double WaitPeriod
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchCompositeAlarmActionsSuppressor), fullyQualifiedName: "aws.cloudwatchCompositeAlarm.CloudwatchCompositeAlarmActionsSuppressor")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchCompositeAlarm.ICloudwatchCompositeAlarmActionsSuppressor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#alarm CloudwatchCompositeAlarm#alarm}.</summary>
            [JsiiProperty(name: "alarm", typeJson: "{\"primitive\":\"string\"}")]
            public string Alarm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#extension_period CloudwatchCompositeAlarm#extension_period}.</summary>
            [JsiiProperty(name: "extensionPeriod", typeJson: "{\"primitive\":\"number\"}")]
            public double ExtensionPeriod
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#wait_period CloudwatchCompositeAlarm#wait_period}.</summary>
            [JsiiProperty(name: "waitPeriod", typeJson: "{\"primitive\":\"number\"}")]
            public double WaitPeriod
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
