using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogDatabase
{
    [JsiiByValue(fqn: "aws.glueCatalogDatabase.GlueCatalogDatabaseCreateTableDefaultPermission")]
    public class GlueCatalogDatabaseCreateTableDefaultPermission : aws.GlueCatalogDatabase.IGlueCatalogDatabaseCreateTableDefaultPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#permissions GlueCatalogDatabase#permissions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Permissions
        {
            get;
            set;
        }

        /// <summary>principal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#principal GlueCatalogDatabase#principal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "principal", typeJson: "{\"fqn\":\"aws.glueCatalogDatabase.GlueCatalogDatabaseCreateTableDefaultPermissionPrincipal\"}", isOptional: true)]
        public aws.GlueCatalogDatabase.IGlueCatalogDatabaseCreateTableDefaultPermissionPrincipal? Principal
        {
            get;
            set;
        }
    }
}
