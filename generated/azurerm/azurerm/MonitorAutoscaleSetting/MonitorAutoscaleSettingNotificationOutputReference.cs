using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    [JsiiClass(nativeType: typeof(azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingNotificationOutputReference), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MonitorAutoscaleSettingNotificationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MonitorAutoscaleSettingNotificationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorAutoscaleSettingNotificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorAutoscaleSettingNotificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEmail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationEmail\"}}]")]
        public virtual void PutEmail(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationEmail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationEmail)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebhook", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationWebhook\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWebhook(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationWebhook[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationWebhook).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationWebhook).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEmail")]
        public virtual void ResetEmail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebhook")]
        public virtual void ResetWebhook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationEmailOutputReference\"}")]
        public virtual azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingNotificationEmailOutputReference Email
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingNotificationEmailOutputReference>()!;
        }

        [JsiiProperty(name: "webhook", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationWebhookList\"}")]
        public virtual azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingNotificationWebhookList Webhook
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingNotificationWebhookList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationEmail\"}", isOptional: true)]
        public virtual azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationEmail? EmailInput
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationEmail?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webhookInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationWebhook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WebhookInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotification\"}", isOptional: true)]
        public virtual azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotification? InternalValue
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotification?>();
            set => SetInstanceProperty(value);
        }
    }
}
