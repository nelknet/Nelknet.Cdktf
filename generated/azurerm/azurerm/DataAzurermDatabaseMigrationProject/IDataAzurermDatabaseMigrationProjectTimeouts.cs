using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDatabaseMigrationProject
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDatabaseMigrationProjectTimeouts), fullyQualifiedName: "azurerm.dataAzurermDatabaseMigrationProject.DataAzurermDatabaseMigrationProjectTimeouts")]
    public interface IDataAzurermDatabaseMigrationProjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_project#read DataAzurermDatabaseMigrationProject#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDatabaseMigrationProjectTimeouts), fullyQualifiedName: "azurerm.dataAzurermDatabaseMigrationProject.DataAzurermDatabaseMigrationProjectTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDatabaseMigrationProject.IDataAzurermDatabaseMigrationProjectTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_project#read DataAzurermDatabaseMigrationProject#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
