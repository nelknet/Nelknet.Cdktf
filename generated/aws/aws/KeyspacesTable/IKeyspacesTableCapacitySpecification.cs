using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    [JsiiInterface(nativeType: typeof(IKeyspacesTableCapacitySpecification), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableCapacitySpecification")]
    public interface IKeyspacesTableCapacitySpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#read_capacity_units KeyspacesTable#read_capacity_units}.</summary>
        [JsiiProperty(name: "readCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadCapacityUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#throughput_mode KeyspacesTable#throughput_mode}.</summary>
        [JsiiProperty(name: "throughputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ThroughputMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#write_capacity_units KeyspacesTable#write_capacity_units}.</summary>
        [JsiiProperty(name: "writeCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteCapacityUnits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyspacesTableCapacitySpecification), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableCapacitySpecification")]
        internal sealed class _Proxy : DeputyBase, aws.KeyspacesTable.IKeyspacesTableCapacitySpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#read_capacity_units KeyspacesTable#read_capacity_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadCapacityUnits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#throughput_mode KeyspacesTable#throughput_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "throughputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ThroughputMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#write_capacity_units KeyspacesTable#write_capacity_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "writeCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteCapacityUnits
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
