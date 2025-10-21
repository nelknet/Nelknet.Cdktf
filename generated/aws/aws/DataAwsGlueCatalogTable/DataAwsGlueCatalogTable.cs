using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsGlueCatalogTable
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_catalog_table aws_glue_catalog_table}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTable), fullyQualifiedName: "aws.dataAwsGlueCatalogTable.DataAwsGlueCatalogTable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsGlueCatalogTable.DataAwsGlueCatalogTableConfig\"}}]")]
    public class DataAwsGlueCatalogTable : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_catalog_table aws_glue_catalog_table} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsGlueCatalogTable(Constructs.Construct scope, string id, aws.DataAwsGlueCatalogTable.IDataAwsGlueCatalogTableConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsGlueCatalogTable.IDataAwsGlueCatalogTableConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsGlueCatalogTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsGlueCatalogTable(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsGlueCatalogTable resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsGlueCatalogTable to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsGlueCatalogTable that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsGlueCatalogTable to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsGlueCatalogTable to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_catalog_table#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsGlueCatalogTable that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsGlueCatalogTable to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTable), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetCatalogId")]
        public virtual void ResetCatalogId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryAsOfTime")]
        public virtual void ResetQueryAsOfTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransactionId")]
        public virtual void ResetTransactionId()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTable))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Parameters
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "partitionIndex", typeJson: "{\"fqn\":\"aws.dataAwsGlueCatalogTable.DataAwsGlueCatalogTablePartitionIndexList\"}")]
        public virtual aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTablePartitionIndexList PartitionIndex
        {
            get => GetInstanceProperty<aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTablePartitionIndexList>()!;
        }

        [JsiiProperty(name: "partitionKeys", typeJson: "{\"fqn\":\"aws.dataAwsGlueCatalogTable.DataAwsGlueCatalogTablePartitionKeysList\"}")]
        public virtual aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTablePartitionKeysList PartitionKeys
        {
            get => GetInstanceProperty<aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTablePartitionKeysList>()!;
        }

        [JsiiProperty(name: "retention", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Retention
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "storageDescriptor", typeJson: "{\"fqn\":\"aws.dataAwsGlueCatalogTable.DataAwsGlueCatalogTableStorageDescriptorList\"}")]
        public virtual aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTableStorageDescriptorList StorageDescriptor
        {
            get => GetInstanceProperty<aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTableStorageDescriptorList>()!;
        }

        [JsiiProperty(name: "tableType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetTable", typeJson: "{\"fqn\":\"aws.dataAwsGlueCatalogTable.DataAwsGlueCatalogTableTargetTableList\"}")]
        public virtual aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTableTargetTableList TargetTable
        {
            get => GetInstanceProperty<aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTableTargetTableList>()!;
        }

        [JsiiProperty(name: "viewExpandedText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewExpandedText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "viewOriginalText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewOriginalText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatalogIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseNameInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "queryAsOfTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryAsOfTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transactionIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TransactionIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "queryAsOfTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueryAsOfTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transactionId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TransactionId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
