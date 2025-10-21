using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationRunbook
{
    [JsiiClass(nativeType: typeof(azurerm.AutomationRunbook.AutomationRunbookPublishContentLinkOutputReference), fullyQualifiedName: "azurerm.automationRunbook.AutomationRunbookPublishContentLinkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutomationRunbookPublishContentLinkOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutomationRunbookPublishContentLinkOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutomationRunbookPublishContentLinkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomationRunbookPublishContentLinkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHash", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookPublishContentLinkHash\"}}]")]
        public virtual void PutHash(azurerm.AutomationRunbook.IAutomationRunbookPublishContentLinkHash @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomationRunbook.IAutomationRunbookPublishContentLinkHash)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHash")]
        public virtual void ResetHash()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "hash", typeJson: "{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookPublishContentLinkHashOutputReference\"}")]
        public virtual azurerm.AutomationRunbook.AutomationRunbookPublishContentLinkHashOutputReference Hash
        {
            get => GetInstanceProperty<azurerm.AutomationRunbook.AutomationRunbookPublishContentLinkHashOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hashInput", typeJson: "{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookPublishContentLinkHash\"}", isOptional: true)]
        public virtual azurerm.AutomationRunbook.IAutomationRunbookPublishContentLinkHash? HashInput
        {
            get => GetInstanceProperty<azurerm.AutomationRunbook.IAutomationRunbookPublishContentLinkHash?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookPublishContentLink\"}", isOptional: true)]
        public virtual azurerm.AutomationRunbook.IAutomationRunbookPublishContentLink? InternalValue
        {
            get => GetInstanceProperty<azurerm.AutomationRunbook.IAutomationRunbookPublishContentLink?>();
            set => SetInstanceProperty(value);
        }
    }
}
