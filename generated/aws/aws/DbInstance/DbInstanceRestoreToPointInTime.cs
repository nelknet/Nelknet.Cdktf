using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbInstance
{
    [JsiiByValue(fqn: "aws.dbInstance.DbInstanceRestoreToPointInTime")]
    public class DbInstanceRestoreToPointInTime : aws.DbInstance.IDbInstanceRestoreToPointInTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#restore_time DbInstance#restore_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "restoreTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RestoreTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#source_db_instance_automated_backups_arn DbInstance#source_db_instance_automated_backups_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDbInstanceAutomatedBackupsArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceDbInstanceAutomatedBackupsArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#source_db_instance_identifier DbInstance#source_db_instance_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDbInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceDbInstanceIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#source_dbi_resource_id DbInstance#source_dbi_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDbiResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceDbiResourceId
        {
            get;
            set;
        }

        private object? _useLatestRestorableTime;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#use_latest_restorable_time DbInstance#use_latest_restorable_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useLatestRestorableTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseLatestRestorableTime
        {
            get => _useLatestRestorableTime;
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
                _useLatestRestorableTime = value;
            }
        }
    }
}
