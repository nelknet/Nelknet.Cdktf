using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    [JsiiByValue(fqn: "aws.keyspacesTable.KeyspacesTableCapacitySpecification")]
    public class KeyspacesTableCapacitySpecification : aws.KeyspacesTable.IKeyspacesTableCapacitySpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#read_capacity_units KeyspacesTable#read_capacity_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadCapacityUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#throughput_mode KeyspacesTable#throughput_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "throughputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ThroughputMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#write_capacity_units KeyspacesTable#write_capacity_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "writeCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WriteCapacityUnits
        {
            get;
            set;
        }
    }
}
