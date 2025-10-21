using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapVolume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfiguration")]
    public class FsxOntapVolumeSnaplockConfiguration : aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#snaplock_type FsxOntapVolume#snaplock_type}.</summary>
        [JsiiProperty(name: "snaplockType", typeJson: "{\"primitive\":\"string\"}")]
        public string SnaplockType
        {
            get;
            set;
        }

        private object? _auditLogVolume;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#audit_log_volume FsxOntapVolume#audit_log_volume}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "auditLogVolume", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AuditLogVolume
        {
            get => _auditLogVolume;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _auditLogVolume = value;
            }
        }

        /// <summary>autocommit_period block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#autocommit_period FsxOntapVolume#autocommit_period}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autocommitPeriod", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationAutocommitPeriod\"}", isOptional: true)]
        public aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationAutocommitPeriod? AutocommitPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#privileged_delete FsxOntapVolume#privileged_delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privilegedDelete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivilegedDelete
        {
            get;
            set;
        }

        /// <summary>retention_period block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#retention_period FsxOntapVolume#retention_period}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriod\"}", isOptional: true)]
        public aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriod? RetentionPeriod
        {
            get;
            set;
        }

        private object? _volumeAppendModeEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#volume_append_mode_enabled FsxOntapVolume#volume_append_mode_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeAppendModeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? VolumeAppendModeEnabled
        {
            get => _volumeAppendModeEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _volumeAppendModeEnabled = value;
            }
        }
    }
}
