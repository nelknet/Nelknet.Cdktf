using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReference")]
    public class GlueCatalogTableStorageDescriptorSchemaReference : aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_version_number GlueCatalogTable#schema_version_number}.</summary>
        [JsiiProperty(name: "schemaVersionNumber", typeJson: "{\"primitive\":\"number\"}")]
        public double SchemaVersionNumber
        {
            get;
            set;
        }

        /// <summary>schema_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_id GlueCatalogTable#schema_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schemaId", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId\"}", isOptional: true)]
        public aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId? SchemaId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_version_id GlueCatalogTable#schema_version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemaVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SchemaVersionId
        {
            get;
            set;
        }
    }
}
