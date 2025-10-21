using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.keyspacesTable.KeyspacesTableSchemaDefinitionStaticColumn")]
    public class KeyspacesTableSchemaDefinitionStaticColumn : aws.KeyspacesTable.IKeyspacesTableSchemaDefinitionStaticColumn
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
