using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapVolume
{
    [JsiiInterface(nativeType: typeof(IFsxOntapVolumeSnaplockConfiguration), fullyQualifiedName: "aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfiguration")]
    public interface IFsxOntapVolumeSnaplockConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#snaplock_type FsxOntapVolume#snaplock_type}.</summary>
        [JsiiProperty(name: "snaplockType", typeJson: "{\"primitive\":\"string\"}")]
        string SnaplockType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#audit_log_volume FsxOntapVolume#audit_log_volume}.</summary>
        [JsiiProperty(name: "auditLogVolume", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuditLogVolume
        {
            get
            {
                return null;
            }
        }

        /// <summary>autocommit_period block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#autocommit_period FsxOntapVolume#autocommit_period}
        /// </remarks>
        [JsiiProperty(name: "autocommitPeriod", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationAutocommitPeriod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationAutocommitPeriod? AutocommitPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#privileged_delete FsxOntapVolume#privileged_delete}.</summary>
        [JsiiProperty(name: "privilegedDelete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivilegedDelete
        {
            get
            {
                return null;
            }
        }

        /// <summary>retention_period block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#retention_period FsxOntapVolume#retention_period}
        /// </remarks>
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriod? RetentionPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#volume_append_mode_enabled FsxOntapVolume#volume_append_mode_enabled}.</summary>
        [JsiiProperty(name: "volumeAppendModeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VolumeAppendModeEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOntapVolumeSnaplockConfiguration), fullyQualifiedName: "aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#snaplock_type FsxOntapVolume#snaplock_type}.</summary>
            [JsiiProperty(name: "snaplockType", typeJson: "{\"primitive\":\"string\"}")]
            public string SnaplockType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#audit_log_volume FsxOntapVolume#audit_log_volume}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "auditLogVolume", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AuditLogVolume
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>autocommit_period block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#autocommit_period FsxOntapVolume#autocommit_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autocommitPeriod", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationAutocommitPeriod\"}", isOptional: true)]
            public aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationAutocommitPeriod? AutocommitPeriod
            {
                get => GetInstanceProperty<aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationAutocommitPeriod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#privileged_delete FsxOntapVolume#privileged_delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privilegedDelete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivilegedDelete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>retention_period block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#retention_period FsxOntapVolume#retention_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriod", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriod\"}", isOptional: true)]
            public aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriod? RetentionPeriod
            {
                get => GetInstanceProperty<aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#volume_append_mode_enabled FsxOntapVolume#volume_append_mode_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeAppendModeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? VolumeAppendModeEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
