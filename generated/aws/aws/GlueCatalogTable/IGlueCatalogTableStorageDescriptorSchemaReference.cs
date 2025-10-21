using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableStorageDescriptorSchemaReference), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReference")]
    public interface IGlueCatalogTableStorageDescriptorSchemaReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_version_number GlueCatalogTable#schema_version_number}.</summary>
        [JsiiProperty(name: "schemaVersionNumber", typeJson: "{\"primitive\":\"number\"}")]
        double SchemaVersionNumber
        {
            get;
        }

        /// <summary>schema_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_id GlueCatalogTable#schema_id}
        /// </remarks>
        [JsiiProperty(name: "schemaId", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId? SchemaId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_version_id GlueCatalogTable#schema_version_id}.</summary>
        [JsiiProperty(name: "schemaVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SchemaVersionId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableStorageDescriptorSchemaReference), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReference")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_version_number GlueCatalogTable#schema_version_number}.</summary>
            [JsiiProperty(name: "schemaVersionNumber", typeJson: "{\"primitive\":\"number\"}")]
            public double SchemaVersionNumber
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>schema_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_id GlueCatalogTable#schema_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schemaId", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId\"}", isOptional: true)]
            public aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId? SchemaId
            {
                get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_version_id GlueCatalogTable#schema_version_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SchemaVersionId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
