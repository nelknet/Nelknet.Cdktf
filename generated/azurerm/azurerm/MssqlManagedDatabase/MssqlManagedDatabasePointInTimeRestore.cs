using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlManagedDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlManagedDatabase.MssqlManagedDatabasePointInTimeRestore")]
    public class MssqlManagedDatabasePointInTimeRestore : azurerm.MssqlManagedDatabase.IMssqlManagedDatabasePointInTimeRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#restore_point_in_time MssqlManagedDatabase#restore_point_in_time}.</summary>
        [JsiiProperty(name: "restorePointInTime", typeJson: "{\"primitive\":\"string\"}")]
        public string RestorePointInTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#source_database_id MssqlManagedDatabase#source_database_id}.</summary>
        [JsiiProperty(name: "sourceDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceDatabaseId
        {
            get;
            set;
        }
    }
}
