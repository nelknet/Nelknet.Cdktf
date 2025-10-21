using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbCassandraTable
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table azurerm_cosmosdb_cassandra_table}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.CosmosdbCassandraTable.CosmosdbCassandraTable), fullyQualifiedName: "azurerm.cosmosdbCassandraTable.CosmosdbCassandraTable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableConfig\"}}]")]
    public class CosmosdbCassandraTable : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table azurerm_cosmosdb_cassandra_table} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CosmosdbCassandraTable(Constructs.Construct scope, string id, azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbCassandraTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbCassandraTable(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CosmosdbCassandraTable resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CosmosdbCassandraTable to import.</param>
        /// <param name="importFromId">The id of the existing CosmosdbCassandraTable that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CosmosdbCassandraTable to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CosmosdbCassandraTable to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CosmosdbCassandraTable that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CosmosdbCassandraTable to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.CosmosdbCassandraTable.CosmosdbCassandraTable), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutoscaleSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableAutoscaleSettings\"}}]")]
        public virtual void PutAutoscaleSettings(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableAutoscaleSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableAutoscaleSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchema", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchema\"}}]")]
        public virtual void PutSchema(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchema @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchema)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnalyticalStorageTtl")]
        public virtual void ResetAnalyticalStorageTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscaleSettings")]
        public virtual void ResetAutoscaleSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultTtl")]
        public virtual void ResetDefaultTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThroughput")]
        public virtual void ResetThroughput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.CosmosdbCassandraTable.CosmosdbCassandraTable))!;

        [JsiiProperty(name: "autoscaleSettings", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableAutoscaleSettingsOutputReference\"}")]
        public virtual azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableAutoscaleSettingsOutputReference AutoscaleSettings
        {
            get => GetInstanceProperty<azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableAutoscaleSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchemaOutputReference\"}")]
        public virtual azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableSchemaOutputReference Schema
        {
            get => GetInstanceProperty<azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableSchemaOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableTimeoutsOutputReference\"}")]
        public virtual azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "analyticalStorageTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AnalyticalStorageTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscaleSettingsInput", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableAutoscaleSettings\"}", isOptional: true)]
        public virtual azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableAutoscaleSettings? AutoscaleSettingsInput
        {
            get => GetInstanceProperty<azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableAutoscaleSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cassandraKeyspaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CassandraKeyspaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaInput", typeJson: "{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableSchema\"}", isOptional: true)]
        public virtual azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchema? SchemaInput
        {
            get => GetInstanceProperty<azurerm.CosmosdbCassandraTable.ICosmosdbCassandraTableSchema?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "throughputInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThroughputInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.cosmosdbCassandraTable.CosmosdbCassandraTableTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "analyticalStorageTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AnalyticalStorageTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cassandraKeyspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CassandraKeyspaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "throughput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Throughput
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
