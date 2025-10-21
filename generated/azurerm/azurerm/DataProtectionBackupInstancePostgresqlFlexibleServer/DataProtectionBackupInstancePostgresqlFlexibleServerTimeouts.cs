using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupInstancePostgresqlFlexibleServer
{
    [JsiiByValue(fqn: "azurerm.dataProtectionBackupInstancePostgresqlFlexibleServer.DataProtectionBackupInstancePostgresqlFlexibleServerTimeouts")]
    public class DataProtectionBackupInstancePostgresqlFlexibleServerTimeouts : azurerm.DataProtectionBackupInstancePostgresqlFlexibleServer.IDataProtectionBackupInstancePostgresqlFlexibleServerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql_flexible_server#create DataProtectionBackupInstancePostgresqlFlexibleServer#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql_flexible_server#delete DataProtectionBackupInstancePostgresqlFlexibleServer#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql_flexible_server#read DataProtectionBackupInstancePostgresqlFlexibleServer#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql_flexible_server#update DataProtectionBackupInstancePostgresqlFlexibleServer#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
