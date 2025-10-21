using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlDatabase.MssqlDatabaseShortTermRetentionPolicy")]
    public class MssqlDatabaseShortTermRetentionPolicy : azurerm.MssqlDatabase.IMssqlDatabaseShortTermRetentionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#retention_days MssqlDatabase#retention_days}.</summary>
        [JsiiProperty(name: "retentionDays", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#backup_interval_in_hours MssqlDatabase#backup_interval_in_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupIntervalInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackupIntervalInHours
        {
            get;
            set;
        }
    }
}
