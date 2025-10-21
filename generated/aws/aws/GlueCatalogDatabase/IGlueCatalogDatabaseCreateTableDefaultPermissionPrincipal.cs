using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogDatabase
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogDatabaseCreateTableDefaultPermissionPrincipal), fullyQualifiedName: "aws.glueCatalogDatabase.GlueCatalogDatabaseCreateTableDefaultPermissionPrincipal")]
    public interface IGlueCatalogDatabaseCreateTableDefaultPermissionPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#data_lake_principal_identifier GlueCatalogDatabase#data_lake_principal_identifier}.</summary>
        [JsiiProperty(name: "dataLakePrincipalIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataLakePrincipalIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogDatabaseCreateTableDefaultPermissionPrincipal), fullyQualifiedName: "aws.glueCatalogDatabase.GlueCatalogDatabaseCreateTableDefaultPermissionPrincipal")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogDatabase.IGlueCatalogDatabaseCreateTableDefaultPermissionPrincipal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#data_lake_principal_identifier GlueCatalogDatabase#data_lake_principal_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataLakePrincipalIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataLakePrincipalIdentifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
