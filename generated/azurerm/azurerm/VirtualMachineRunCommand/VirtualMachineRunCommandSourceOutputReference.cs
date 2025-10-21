using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineRunCommand
{
    [JsiiClass(nativeType: typeof(azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandSourceOutputReference), fullyQualifiedName: "azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VirtualMachineRunCommandSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VirtualMachineRunCommandSourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VirtualMachineRunCommandSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualMachineRunCommandSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putScriptUriManagedIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSourceScriptUriManagedIdentity\"}}]")]
        public virtual void PutScriptUriManagedIdentity(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSourceScriptUriManagedIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSourceScriptUriManagedIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCommandId")]
        public virtual void ResetCommandId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScript")]
        public virtual void ResetScript()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScriptUri")]
        public virtual void ResetScriptUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScriptUriManagedIdentity")]
        public virtual void ResetScriptUriManagedIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "scriptUriManagedIdentity", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSourceScriptUriManagedIdentityOutputReference\"}")]
        public virtual azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandSourceScriptUriManagedIdentityOutputReference ScriptUriManagedIdentity
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandSourceScriptUriManagedIdentityOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commandIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommandIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scriptInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScriptInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scriptUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScriptUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scriptUriManagedIdentityInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSourceScriptUriManagedIdentity\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSourceScriptUriManagedIdentity? ScriptUriManagedIdentityInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSourceScriptUriManagedIdentity?>();
        }

        [JsiiProperty(name: "commandId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommandId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "script", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Script
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scriptUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScriptUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSource\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSource? InternalValue
        {
            get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
