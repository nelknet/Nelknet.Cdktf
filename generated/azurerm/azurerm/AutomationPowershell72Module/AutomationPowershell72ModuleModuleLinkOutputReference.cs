using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationPowershell72Module
{
    [JsiiClass(nativeType: typeof(azurerm.AutomationPowershell72Module.AutomationPowershell72ModuleModuleLinkOutputReference), fullyQualifiedName: "azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLinkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutomationPowershell72ModuleModuleLinkOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutomationPowershell72ModuleModuleLinkOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutomationPowershell72ModuleModuleLinkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomationPowershell72ModuleModuleLinkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHash", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLinkHash\"}}]")]
        public virtual void PutHash(azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLinkHash @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLinkHash)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHash")]
        public virtual void ResetHash()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "hash", typeJson: "{\"fqn\":\"azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLinkHashOutputReference\"}")]
        public virtual azurerm.AutomationPowershell72Module.AutomationPowershell72ModuleModuleLinkHashOutputReference Hash
        {
            get => GetInstanceProperty<azurerm.AutomationPowershell72Module.AutomationPowershell72ModuleModuleLinkHashOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hashInput", typeJson: "{\"fqn\":\"azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLinkHash\"}", isOptional: true)]
        public virtual azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLinkHash? HashInput
        {
            get => GetInstanceProperty<azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLinkHash?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLink\"}", isOptional: true)]
        public virtual azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLink? InternalValue
        {
            get => GetInstanceProperty<azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLink?>();
            set => SetInstanceProperty(value);
        }
    }
}
