using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlDatabase
{
    [JsiiInterface(nativeType: typeof(IMssqlDatabaseShortTermRetentionPolicy), fullyQualifiedName: "azurerm.mssqlDatabase.MssqlDatabaseShortTermRetentionPolicy")]
    public interface IMssqlDatabaseShortTermRetentionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#retention_days MssqlDatabase#retention_days}.</summary>
        [JsiiProperty(name: "retentionDays", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#backup_interval_in_hours MssqlDatabase#backup_interval_in_hours}.</summary>
        [JsiiProperty(name: "backupIntervalInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackupIntervalInHours
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlDatabaseShortTermRetentionPolicy), fullyQualifiedName: "azurerm.mssqlDatabase.MssqlDatabaseShortTermRetentionPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlDatabase.IMssqlDatabaseShortTermRetentionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#retention_days MssqlDatabase#retention_days}.</summary>
            [JsiiProperty(name: "retentionDays", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#backup_interval_in_hours MssqlDatabase#backup_interval_in_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupIntervalInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackupIntervalInHours
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
