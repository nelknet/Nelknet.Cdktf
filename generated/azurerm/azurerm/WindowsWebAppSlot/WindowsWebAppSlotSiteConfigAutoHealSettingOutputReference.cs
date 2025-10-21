using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiClass(nativeType: typeof(azurerm.WindowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingOutputReference), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WindowsWebAppSlotSiteConfigAutoHealSettingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WindowsWebAppSlotSiteConfigAutoHealSettingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WindowsWebAppSlotSiteConfigAutoHealSettingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsWebAppSlotSiteConfigAutoHealSettingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingAction\"}}]")]
        public virtual void PutAction(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrigger", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTrigger\"}}]")]
        public virtual void PutTrigger(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTrigger @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTrigger)}, new object[]{@value});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingActionOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingActionOutputReference Action
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingActionOutputReference>()!;
        }

        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerOutputReference Trigger
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingAction\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingAction? ActionInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTrigger\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTrigger? TriggerInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTrigger?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSetting\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSetting? InternalValue
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSetting?>();
            set => SetInstanceProperty(value);
        }
    }
}
