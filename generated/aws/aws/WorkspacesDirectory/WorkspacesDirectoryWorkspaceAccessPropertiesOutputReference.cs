using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesDirectory
{
    [JsiiClass(nativeType: typeof(aws.WorkspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesOutputReference), fullyQualifiedName: "aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WorkspacesDirectoryWorkspaceAccessPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WorkspacesDirectoryWorkspaceAccessPropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WorkspacesDirectoryWorkspaceAccessPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspacesDirectoryWorkspaceAccessPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDeviceTypeAndroid")]
        public virtual void ResetDeviceTypeAndroid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceTypeChromeos")]
        public virtual void ResetDeviceTypeChromeos()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceTypeIos")]
        public virtual void ResetDeviceTypeIos()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceTypeLinux")]
        public virtual void ResetDeviceTypeLinux()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceTypeOsx")]
        public virtual void ResetDeviceTypeOsx()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceTypeWeb")]
        public virtual void ResetDeviceTypeWeb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceTypeWindows")]
        public virtual void ResetDeviceTypeWindows()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceTypeZeroclient")]
        public virtual void ResetDeviceTypeZeroclient()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeAndroidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceTypeAndroidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeChromeosInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceTypeChromeosInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeIosInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceTypeIosInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeLinuxInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceTypeLinuxInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeOsxInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceTypeOsxInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeWebInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceTypeWebInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeWindowsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceTypeWindowsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeZeroclientInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceTypeZeroclientInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "deviceTypeAndroid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeAndroid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deviceTypeChromeos", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeChromeos
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deviceTypeIos", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeIos
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deviceTypeLinux", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeLinux
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deviceTypeOsx", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeOsx
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deviceTypeWeb", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeWeb
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deviceTypeWindows", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeWindows
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deviceTypeZeroclient", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTypeZeroclient
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessProperties\"}", isOptional: true)]
        public virtual aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessProperties? InternalValue
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
