using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationModule
{
    [JsiiClass(nativeType: typeof(azurerm.AutomationModule.AutomationModuleModuleLinkOutputReference), fullyQualifiedName: "azurerm.automationModule.AutomationModuleModuleLinkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutomationModuleModuleLinkOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutomationModuleModuleLinkOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutomationModuleModuleLinkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomationModuleModuleLinkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHash", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automationModule.AutomationModuleModuleLinkHash\"}}]")]
        public virtual void PutHash(azurerm.AutomationModule.IAutomationModuleModuleLinkHash @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomationModule.IAutomationModuleModuleLinkHash)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHash")]
        public virtual void ResetHash()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "hash", typeJson: "{\"fqn\":\"azurerm.automationModule.AutomationModuleModuleLinkHashOutputReference\"}")]
        public virtual azurerm.AutomationModule.AutomationModuleModuleLinkHashOutputReference Hash
        {
            get => GetInstanceProperty<azurerm.AutomationModule.AutomationModuleModuleLinkHashOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hashInput", typeJson: "{\"fqn\":\"azurerm.automationModule.AutomationModuleModuleLinkHash\"}", isOptional: true)]
        public virtual azurerm.AutomationModule.IAutomationModuleModuleLinkHash? HashInput
        {
            get => GetInstanceProperty<azurerm.AutomationModule.IAutomationModuleModuleLinkHash?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.automationModule.AutomationModuleModuleLink\"}", isOptional: true)]
        public virtual azurerm.AutomationModule.IAutomationModuleModuleLink? InternalValue
        {
            get => GetInstanceProperty<azurerm.AutomationModule.IAutomationModuleModuleLink?>();
            set => SetInstanceProperty(value);
        }
    }
}
