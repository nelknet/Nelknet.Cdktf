using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbInstance
{
    [JsiiInterface(nativeType: typeof(IDbInstanceRestoreToPointInTime), fullyQualifiedName: "aws.dbInstance.DbInstanceRestoreToPointInTime")]
    public interface IDbInstanceRestoreToPointInTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#restore_time DbInstance#restore_time}.</summary>
        [JsiiProperty(name: "restoreTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RestoreTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#source_db_instance_automated_backups_arn DbInstance#source_db_instance_automated_backups_arn}.</summary>
        [JsiiProperty(name: "sourceDbInstanceAutomatedBackupsArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceDbInstanceAutomatedBackupsArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#source_db_instance_identifier DbInstance#source_db_instance_identifier}.</summary>
        [JsiiProperty(name: "sourceDbInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceDbInstanceIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#source_dbi_resource_id DbInstance#source_dbi_resource_id}.</summary>
        [JsiiProperty(name: "sourceDbiResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceDbiResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#use_latest_restorable_time DbInstance#use_latest_restorable_time}.</summary>
        [JsiiProperty(name: "useLatestRestorableTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseLatestRestorableTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbInstanceRestoreToPointInTime), fullyQualifiedName: "aws.dbInstance.DbInstanceRestoreToPointInTime")]
        internal sealed class _Proxy : DeputyBase, aws.DbInstance.IDbInstanceRestoreToPointInTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#restore_time DbInstance#restore_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restoreTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RestoreTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#source_db_instance_automated_backups_arn DbInstance#source_db_instance_automated_backups_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDbInstanceAutomatedBackupsArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceDbInstanceAutomatedBackupsArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#source_db_instance_identifier DbInstance#source_db_instance_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDbInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceDbInstanceIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#source_dbi_resource_id DbInstance#source_dbi_resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDbiResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceDbiResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#use_latest_restorable_time DbInstance#use_latest_restorable_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useLatestRestorableTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseLatestRestorableTime
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
