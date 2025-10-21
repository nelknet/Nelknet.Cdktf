using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MysqlFlexibleServer
{
    [JsiiByValue(fqn: "azurerm.mysqlFlexibleServer.MysqlFlexibleServerCustomerManagedKey")]
    public class MysqlFlexibleServerCustomerManagedKey : azurerm.MysqlFlexibleServer.IMysqlFlexibleServerCustomerManagedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#geo_backup_key_vault_key_id MysqlFlexibleServer#geo_backup_key_vault_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "geoBackupKeyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GeoBackupKeyVaultKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#geo_backup_user_assigned_identity_id MysqlFlexibleServer#geo_backup_user_assigned_identity_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "geoBackupUserAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GeoBackupUserAssignedIdentityId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#key_vault_key_id MysqlFlexibleServer#key_vault_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyVaultKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#primary_user_assigned_identity_id MysqlFlexibleServer#primary_user_assigned_identity_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryUserAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryUserAssignedIdentityId
        {
            get;
            set;
        }
    }
}
