using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiClass(nativeType: typeof(azurerm.WindowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogsOutputReference), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WindowsWebAppSlotLogsApplicationLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WindowsWebAppSlotLogsApplicationLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WindowsWebAppSlotLogsApplicationLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsWebAppSlotLogsApplicationLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAzureBlobStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogsAzureBlobStorage\"}}]")]
        public virtual void PutAzureBlobStorage(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogsAzureBlobStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogsAzureBlobStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAzureBlobStorage")]
        public virtual void ResetAzureBlobStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogsAzureBlobStorageOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogsAzureBlobStorageOutputReference AzureBlobStorage
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogsAzureBlobStorageOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorageInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogsAzureBlobStorage\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogsAzureBlobStorage? AzureBlobStorageInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogsAzureBlobStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileSystemLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fileSystemLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogs\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogs? InternalValue
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
