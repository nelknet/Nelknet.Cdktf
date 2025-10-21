using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogDatabase
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogDatabaseCreateTableDefaultPermission), fullyQualifiedName: "aws.glueCatalogDatabase.GlueCatalogDatabaseCreateTableDefaultPermission")]
    public interface IGlueCatalogDatabaseCreateTableDefaultPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#permissions GlueCatalogDatabase#permissions}.</summary>
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Permissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>principal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#principal GlueCatalogDatabase#principal}
        /// </remarks>
        [JsiiProperty(name: "principal", typeJson: "{\"fqn\":\"aws.glueCatalogDatabase.GlueCatalogDatabaseCreateTableDefaultPermissionPrincipal\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueCatalogDatabase.IGlueCatalogDatabaseCreateTableDefaultPermissionPrincipal? Principal
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogDatabaseCreateTableDefaultPermission), fullyQualifiedName: "aws.glueCatalogDatabase.GlueCatalogDatabaseCreateTableDefaultPermission")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogDatabase.IGlueCatalogDatabaseCreateTableDefaultPermission
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#permissions GlueCatalogDatabase#permissions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Permissions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>principal block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#principal GlueCatalogDatabase#principal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "principal", typeJson: "{\"fqn\":\"aws.glueCatalogDatabase.GlueCatalogDatabaseCreateTableDefaultPermissionPrincipal\"}", isOptional: true)]
            public aws.GlueCatalogDatabase.IGlueCatalogDatabaseCreateTableDefaultPermissionPrincipal? Principal
            {
                get => GetInstanceProperty<aws.GlueCatalogDatabase.IGlueCatalogDatabaseCreateTableDefaultPermissionPrincipal?>();
            }
        }
    }
}
