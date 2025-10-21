using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiByValue(fqn: "aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId")]
    public class GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId : aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#registry_name GlueCatalogTable#registry_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "registryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistryName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_arn GlueCatalogTable#schema_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemaArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SchemaArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_name GlueCatalogTable#schema_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SchemaName
        {
            get;
            set;
        }
    }
}
