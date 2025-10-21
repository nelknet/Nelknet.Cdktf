using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogDatabase
{
    [JsiiByValue(fqn: "aws.glueCatalogDatabase.GlueCatalogDatabaseCreateTableDefaultPermissionPrincipal")]
    public class GlueCatalogDatabaseCreateTableDefaultPermissionPrincipal : aws.GlueCatalogDatabase.IGlueCatalogDatabaseCreateTableDefaultPermissionPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#data_lake_principal_identifier GlueCatalogDatabase#data_lake_principal_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataLakePrincipalIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataLakePrincipalIdentifier
        {
            get;
            set;
        }
    }
}
