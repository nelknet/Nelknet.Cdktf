using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlManagedDatabase
{
    [JsiiInterface(nativeType: typeof(IMssqlManagedDatabasePointInTimeRestore), fullyQualifiedName: "azurerm.mssqlManagedDatabase.MssqlManagedDatabasePointInTimeRestore")]
    public interface IMssqlManagedDatabasePointInTimeRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#restore_point_in_time MssqlManagedDatabase#restore_point_in_time}.</summary>
        [JsiiProperty(name: "restorePointInTime", typeJson: "{\"primitive\":\"string\"}")]
        string RestorePointInTime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#source_database_id MssqlManagedDatabase#source_database_id}.</summary>
        [JsiiProperty(name: "sourceDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceDatabaseId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlManagedDatabasePointInTimeRestore), fullyQualifiedName: "azurerm.mssqlManagedDatabase.MssqlManagedDatabasePointInTimeRestore")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlManagedDatabase.IMssqlManagedDatabasePointInTimeRestore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#restore_point_in_time MssqlManagedDatabase#restore_point_in_time}.</summary>
            [JsiiProperty(name: "restorePointInTime", typeJson: "{\"primitive\":\"string\"}")]
            public string RestorePointInTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#source_database_id MssqlManagedDatabase#source_database_id}.</summary>
            [JsiiProperty(name: "sourceDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
