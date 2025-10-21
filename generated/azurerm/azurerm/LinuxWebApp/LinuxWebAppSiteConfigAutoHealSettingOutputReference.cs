using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingOutputReference), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxWebAppSiteConfigAutoHealSettingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxWebAppSiteConfigAutoHealSettingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxWebAppSiteConfigAutoHealSettingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxWebAppSiteConfigAutoHealSettingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingAction\"}}]")]
        public virtual void PutAction(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrigger", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTrigger\"}}]")]
        public virtual void PutTrigger(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTrigger @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTrigger)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAction")]
        public virtual void ResetAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrigger")]
        public virtual void ResetTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingActionOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingActionOutputReference Action
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingActionOutputReference>()!;
        }

        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerOutputReference Trigger
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingAction\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingAction? ActionInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTrigger\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTrigger? TriggerInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTrigger?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSetting\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSetting? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSetting?>();
            set => SetInstanceProperty(value);
        }
    }
}
