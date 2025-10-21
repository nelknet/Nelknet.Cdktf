using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlDatabase
{
    [JsiiInterface(nativeType: typeof(IMssqlDatabaseImport), fullyQualifiedName: "azurerm.mssqlDatabase.MssqlDatabaseImport")]
    public interface IMssqlDatabaseImport
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#administrator_login MssqlDatabase#administrator_login}.</summary>
        [JsiiProperty(name: "administratorLogin", typeJson: "{\"primitive\":\"string\"}")]
        string AdministratorLogin
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#administrator_login_password MssqlDatabase#administrator_login_password}.</summary>
        [JsiiProperty(name: "administratorLoginPassword", typeJson: "{\"primitive\":\"string\"}")]
        string AdministratorLoginPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#authentication_type MssqlDatabase#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        string AuthenticationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#storage_key MssqlDatabase#storage_key}.</summary>
        [JsiiProperty(name: "storageKey", typeJson: "{\"primitive\":\"string\"}")]
        string StorageKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#storage_key_type MssqlDatabase#storage_key_type}.</summary>
        [JsiiProperty(name: "storageKeyType", typeJson: "{\"primitive\":\"string\"}")]
        string StorageKeyType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#storage_uri MssqlDatabase#storage_uri}.</summary>
        [JsiiProperty(name: "storageUri", typeJson: "{\"primitive\":\"string\"}")]
        string StorageUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#storage_account_id MssqlDatabase#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlDatabaseImport), fullyQualifiedName: "azurerm.mssqlDatabase.MssqlDatabaseImport")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlDatabase.IMssqlDatabaseImport
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#administrator_login MssqlDatabase#administrator_login}.</summary>
            [JsiiProperty(name: "administratorLogin", typeJson: "{\"primitive\":\"string\"}")]
            public string AdministratorLogin
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#administrator_login_password MssqlDatabase#administrator_login_password}.</summary>
            [JsiiProperty(name: "administratorLoginPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string AdministratorLoginPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#authentication_type MssqlDatabase#authentication_type}.</summary>
            [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthenticationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#storage_key MssqlDatabase#storage_key}.</summary>
            [JsiiProperty(name: "storageKey", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#storage_key_type MssqlDatabase#storage_key_type}.</summary>
            [JsiiProperty(name: "storageKeyType", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageKeyType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#storage_uri MssqlDatabase#storage_uri}.</summary>
            [JsiiProperty(name: "storageUri", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#storage_account_id MssqlDatabase#storage_account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
