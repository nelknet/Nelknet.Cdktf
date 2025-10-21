using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueTrigger
{
    [JsiiInterface(nativeType: typeof(IGlueTriggerActionsNotificationProperty), fullyQualifiedName: "aws.glueTrigger.GlueTriggerActionsNotificationProperty")]
    public interface IGlueTriggerActionsNotificationProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#notify_delay_after GlueTrigger#notify_delay_after}.</summary>
        [JsiiProperty(name: "notifyDelayAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NotifyDelayAfter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueTriggerActionsNotificationProperty), fullyQualifiedName: "aws.glueTrigger.GlueTriggerActionsNotificationProperty")]
        internal sealed class _Proxy : DeputyBase, aws.GlueTrigger.IGlueTriggerActionsNotificationProperty
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#notify_delay_after GlueTrigger#notify_delay_after}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notifyDelayAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NotifyDelayAfter
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
