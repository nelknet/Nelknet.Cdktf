using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiClass(nativeType: typeof(azurerm.WindowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsOutputReference), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WindowsWebAppSlotLogsHttpLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WindowsWebAppSlotLogsHttpLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WindowsWebAppSlotLogsHttpLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsWebAppSlotLogsHttpLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAzureBlobStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsAzureBlobStorage\"}}]")]
        public virtual void PutAzureBlobStorage(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsAzureBlobStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsAzureBlobStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileSystem", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsFileSystem\"}}]")]
        public virtual void PutFileSystem(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsFileSystem @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsFileSystem)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAzureBlobStorage")]
        public virtual void ResetAzureBlobStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileSystem")]
        public virtual void ResetFileSystem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "azureBlobStorage", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsAzureBlobStorageOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsAzureBlobStorageOutputReference AzureBlobStorage
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsAzureBlobStorageOutputReference>()!;
        }

        [JsiiProperty(name: "fileSystem", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsFileSystemOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsFileSystemOutputReference FileSystem
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsFileSystemOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorageInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsAzureBlobStorage? AzureBlobStorageInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsAzureBlobStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogsFileSystem\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsFileSystem? FileSystemInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogsFileSystem?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogs\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogs? InternalValue
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
