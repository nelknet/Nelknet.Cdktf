using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxWindowsFileSystem
{
    [JsiiClass(nativeType: typeof(aws.FsxWindowsFileSystem.FsxWindowsFileSystemAuditLogConfigurationOutputReference), fullyQualifiedName: "aws.fsxWindowsFileSystem.FsxWindowsFileSystemAuditLogConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FsxWindowsFileSystemAuditLogConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FsxWindowsFileSystemAuditLogConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FsxWindowsFileSystemAuditLogConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxWindowsFileSystemAuditLogConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAuditLogDestination")]
        public virtual void ResetAuditLogDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileAccessAuditLogLevel")]
        public virtual void ResetFileAccessAuditLogLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileShareAccessAuditLogLevel")]
        public virtual void ResetFileShareAccessAuditLogLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditLogDestinationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuditLogDestinationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileAccessAuditLogLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileAccessAuditLogLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileShareAccessAuditLogLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileShareAccessAuditLogLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "auditLogDestination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditLogDestination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fileAccessAuditLogLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileAccessAuditLogLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fileShareAccessAuditLogLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileShareAccessAuditLogLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fsxWindowsFileSystem.FsxWindowsFileSystemAuditLogConfiguration\"}", isOptional: true)]
        public virtual aws.FsxWindowsFileSystem.IFsxWindowsFileSystemAuditLogConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.FsxWindowsFileSystem.IFsxWindowsFileSystemAuditLogConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
