using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.WindowsWebApp.WindowsWebAppSiteConfigAutoHealSettingActionOutputReference), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WindowsWebAppSiteConfigAutoHealSettingActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WindowsWebAppSiteConfigAutoHealSettingActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WindowsWebAppSiteConfigAutoHealSettingActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsWebAppSiteConfigAutoHealSettingActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingActionCustomAction\"}}]")]
        public virtual void PutCustomAction(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingActionCustomAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingActionCustomAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomAction")]
        public virtual void ResetCustomAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumProcessExecutionTime")]
        public virtual void ResetMinimumProcessExecutionTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customAction", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingActionCustomActionOutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppSiteConfigAutoHealSettingActionCustomActionOutputReference CustomAction
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppSiteConfigAutoHealSettingActionCustomActionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customActionInput", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingActionCustomAction\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingActionCustomAction? CustomActionInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingActionCustomAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumProcessExecutionTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MinimumProcessExecutionTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumProcessExecutionTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinimumProcessExecutionTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingAction\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingAction? InternalValue
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
