using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.keyspacesTable.KeyspacesTableSchemaDefinitionClusteringKey")]
    public class KeyspacesTableSchemaDefinitionClusteringKey : aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionClusteringKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#name KeyspacesTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#order_by KeyspacesTable#order_by}.</summary>
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}")]
        public string OrderBy
        {
            get;
            set;
        }
    }
}
