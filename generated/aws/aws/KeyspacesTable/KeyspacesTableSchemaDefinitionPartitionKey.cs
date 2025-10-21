using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.keyspacesTable.KeyspacesTableSchemaDefinitionPartitionKey")]
    public class KeyspacesTableSchemaDefinitionPartitionKey : aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionPartitionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#name KeyspacesTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
