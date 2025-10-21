using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapVolume
{
    [JsiiClass(nativeType: typeof(aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfigurationOutputReference), fullyQualifiedName: "aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FsxOntapVolumeSnaplockConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FsxOntapVolumeSnaplockConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FsxOntapVolumeSnaplockConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapVolumeSnaplockConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutocommitPeriod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationAutocommitPeriod\"}}]")]
        public virtual void PutAutocommitPeriod(aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationAutocommitPeriod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationAutocommitPeriod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetentionPeriod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriod\"}}]")]
        public virtual void PutRetentionPeriod(aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriod)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuditLogVolume")]
        public virtual void ResetAuditLogVolume()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutocommitPeriod")]
        public virtual void ResetAutocommitPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivilegedDelete")]
        public virtual void ResetPrivilegedDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionPeriod")]
        public virtual void ResetRetentionPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolumeAppendModeEnabled")]
        public virtual void ResetVolumeAppendModeEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "autocommitPeriod", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationAutocommitPeriodOutputReference\"}")]
        public virtual aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfigurationAutocommitPeriodOutputReference AutocommitPeriod
        {
            get => GetInstanceProperty<aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfigurationAutocommitPeriodOutputReference>()!;
        }

        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodOutputReference\"}")]
        public virtual aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodOutputReference RetentionPeriod
        {
            get => GetInstanceProperty<aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditLogVolumeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AuditLogVolumeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autocommitPeriodInput", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationAutocommitPeriod\"}", isOptional: true)]
        public virtual aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationAutocommitPeriod? AutocommitPeriodInput
        {
            get => GetInstanceProperty<aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationAutocommitPeriod?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privilegedDeleteInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivilegedDeleteInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriodInput", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriod\"}", isOptional: true)]
        public virtual aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriod? RetentionPeriodInput
        {
            get => GetInstanceProperty<aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriod?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snaplockTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnaplockTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeAppendModeEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? VolumeAppendModeEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "auditLogVolume", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AuditLogVolume
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "privilegedDelete", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivilegedDelete
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snaplockType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnaplockType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeAppendModeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object VolumeAppendModeEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfiguration\"}", isOptional: true)]
        public virtual aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
