using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncTask
{
    [JsiiClass(nativeType: typeof(aws.DatasyncTask.DatasyncTaskOptionsOutputReference), fullyQualifiedName: "aws.datasyncTask.DatasyncTaskOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatasyncTaskOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatasyncTaskOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatasyncTaskOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncTaskOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAtime")]
        public virtual void ResetAtime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBytesPerSecond")]
        public virtual void ResetBytesPerSecond()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGid")]
        public virtual void ResetGid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogLevel")]
        public virtual void ResetLogLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMtime")]
        public virtual void ResetMtime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectTags")]
        public virtual void ResetObjectTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverwriteMode")]
        public virtual void ResetOverwriteMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPosixPermissions")]
        public virtual void ResetPosixPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreserveDeletedFiles")]
        public virtual void ResetPreserveDeletedFiles()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreserveDevices")]
        public virtual void ResetPreserveDevices()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityDescriptorCopyFlags")]
        public virtual void ResetSecurityDescriptorCopyFlags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskQueueing")]
        public virtual void ResetTaskQueueing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransferMode")]
        public virtual void ResetTransferMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUid")]
        public virtual void ResetUid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifyMode")]
        public virtual void ResetVerifyMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "atimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AtimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bytesPerSecondInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BytesPerSecondInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mtimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MtimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectTagsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectTagsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overwriteModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OverwriteModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "posixPermissionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PosixPermissionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preserveDeletedFilesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreserveDeletedFilesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preserveDevicesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreserveDevicesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityDescriptorCopyFlagsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityDescriptorCopyFlagsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskQueueingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskQueueingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transferModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransferModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verifyModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VerifyModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Atime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bytesPerSecond", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BytesPerSecond
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Gid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mtime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectTags", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectTags
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "overwriteMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OverwriteMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "posixPermissions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PosixPermissions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preserveDeletedFiles", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreserveDeletedFiles
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preserveDevices", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreserveDevices
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityDescriptorCopyFlags", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityDescriptorCopyFlags
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskQueueing", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskQueueing
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transferMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransferMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "verifyMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerifyMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskOptions\"}", isOptional: true)]
        public virtual aws.DatasyncTask.IDatasyncTaskOptions? InternalValue
        {
            get => GetInstanceProperty<aws.DatasyncTask.IDatasyncTaskOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
