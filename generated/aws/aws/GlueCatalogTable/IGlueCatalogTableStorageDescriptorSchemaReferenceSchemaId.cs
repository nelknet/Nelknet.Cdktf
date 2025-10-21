using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId")]
    public interface IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#registry_name GlueCatalogTable#registry_name}.</summary>
        [JsiiProperty(name: "registryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegistryName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_arn GlueCatalogTable#schema_arn}.</summary>
        [JsiiProperty(name: "schemaArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SchemaArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_name GlueCatalogTable#schema_name}.</summary>
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SchemaName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#registry_name GlueCatalogTable#registry_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "registryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistryName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_arn GlueCatalogTable#schema_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SchemaArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#schema_name GlueCatalogTable#schema_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SchemaName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
