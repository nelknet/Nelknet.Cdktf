using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesAlarmSpecification")]
    public interface IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#alarms AutoscalingGroup#alarms}.</summary>
        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Alarms
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesAlarmSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#alarms AutoscalingGroup#alarms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Alarms
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
