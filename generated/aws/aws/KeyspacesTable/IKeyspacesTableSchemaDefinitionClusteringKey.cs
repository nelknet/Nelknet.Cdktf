using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    [JsiiInterface(nativeType: typeof(IKeyspacesTableSchemaDefinitionClusteringKey), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableSchemaDefinitionClusteringKey")]
    public interface IKeyspacesTableSchemaDefinitionClusteringKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#name KeyspacesTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#order_by KeyspacesTable#order_by}.</summary>
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}")]
        string OrderBy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyspacesTableSchemaDefinitionClusteringKey), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableSchemaDefinitionClusteringKey")]
        internal sealed class _Proxy : DeputyBase, aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionClusteringKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#name KeyspacesTable#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#order_by KeyspacesTable#order_by}.</summary>
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}")]
            public string OrderBy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
