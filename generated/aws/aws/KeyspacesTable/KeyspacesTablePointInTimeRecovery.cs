using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    [JsiiByValue(fqn: "aws.keyspacesTable.KeyspacesTablePointInTimeRecovery")]
    public class KeyspacesTablePointInTimeRecovery : aws.KeyspacesTable.IKeyspacesTablePointInTimeRecovery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#status KeyspacesTable#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
