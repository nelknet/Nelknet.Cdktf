using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsDynamodbTable
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table aws_dynamodb_table}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsDynamodbTable.DataAwsDynamodbTable), fullyQualifiedName: "aws.dataAwsDynamodbTable.DataAwsDynamodbTable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsDynamodbTable.DataAwsDynamodbTableConfig\"}}]")]
    public class DataAwsDynamodbTable : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table aws_dynamodb_table} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsDynamodbTable(Constructs.Construct scope, string id, aws.DataAwsDynamodbTable.IDataAwsDynamodbTableConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsDynamodbTable.IDataAwsDynamodbTableConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDynamodbTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDynamodbTable(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsDynamodbTable resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsDynamodbTable to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsDynamodbTable that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsDynamodbTable to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsDynamodbTable to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsDynamodbTable that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsDynamodbTable to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsDynamodbTable.DataAwsDynamodbTable), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putServerSideEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsDynamodbTable.DataAwsDynamodbTableServerSideEncryption\"}}]")]
        public virtual void PutServerSideEncryption(aws.DataAwsDynamodbTable.IDataAwsDynamodbTableServerSideEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsDynamodbTable.IDataAwsDynamodbTableServerSideEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerSideEncryption")]
        public virtual void ResetServerSideEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsDynamodbTable.DataAwsDynamodbTable))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attribute", typeJson: "{\"fqn\":\"aws.dataAwsDynamodbTable.DataAwsDynamodbTableAttributeList\"}")]
        public virtual aws.DataAwsDynamodbTable.DataAwsDynamodbTableAttributeList Attribute
        {
            get => GetInstanceProperty<aws.DataAwsDynamodbTable.DataAwsDynamodbTableAttributeList>()!;
        }

        [JsiiProperty(name: "billingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deletionProtectionEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DeletionProtectionEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "globalSecondaryIndex", typeJson: "{\"fqn\":\"aws.dataAwsDynamodbTable.DataAwsDynamodbTableGlobalSecondaryIndexList\"}")]
        public virtual aws.DataAwsDynamodbTable.DataAwsDynamodbTableGlobalSecondaryIndexList GlobalSecondaryIndex
        {
            get => GetInstanceProperty<aws.DataAwsDynamodbTable.DataAwsDynamodbTableGlobalSecondaryIndexList>()!;
        }

        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localSecondaryIndex", typeJson: "{\"fqn\":\"aws.dataAwsDynamodbTable.DataAwsDynamodbTableLocalSecondaryIndexList\"}")]
        public virtual aws.DataAwsDynamodbTable.DataAwsDynamodbTableLocalSecondaryIndexList LocalSecondaryIndex
        {
            get => GetInstanceProperty<aws.DataAwsDynamodbTable.DataAwsDynamodbTableLocalSecondaryIndexList>()!;
        }

        [JsiiProperty(name: "onDemandThroughput", typeJson: "{\"fqn\":\"aws.dataAwsDynamodbTable.DataAwsDynamodbTableOnDemandThroughputList\"}")]
        public virtual aws.DataAwsDynamodbTable.DataAwsDynamodbTableOnDemandThroughputList OnDemandThroughput
        {
            get => GetInstanceProperty<aws.DataAwsDynamodbTable.DataAwsDynamodbTableOnDemandThroughputList>()!;
        }

        [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"fqn\":\"aws.dataAwsDynamodbTable.DataAwsDynamodbTablePointInTimeRecoveryList\"}")]
        public virtual aws.DataAwsDynamodbTable.DataAwsDynamodbTablePointInTimeRecoveryList PointInTimeRecovery
        {
            get => GetInstanceProperty<aws.DataAwsDynamodbTable.DataAwsDynamodbTablePointInTimeRecoveryList>()!;
        }

        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RangeKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "replica", typeJson: "{\"fqn\":\"aws.dataAwsDynamodbTable.DataAwsDynamodbTableReplicaList\"}")]
        public virtual aws.DataAwsDynamodbTable.DataAwsDynamodbTableReplicaList Replica
        {
            get => GetInstanceProperty<aws.DataAwsDynamodbTable.DataAwsDynamodbTableReplicaList>()!;
        }

        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"fqn\":\"aws.dataAwsDynamodbTable.DataAwsDynamodbTableServerSideEncryptionOutputReference\"}")]
        public virtual aws.DataAwsDynamodbTable.DataAwsDynamodbTableServerSideEncryptionOutputReference ServerSideEncryption
        {
            get => GetInstanceProperty<aws.DataAwsDynamodbTable.DataAwsDynamodbTableServerSideEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable StreamEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "streamLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamViewType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamViewType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tableClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableClass
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"fqn\":\"aws.dataAwsDynamodbTable.DataAwsDynamodbTableTtlList\"}")]
        public virtual aws.DataAwsDynamodbTable.DataAwsDynamodbTableTtlList Ttl
        {
            get => GetInstanceProperty<aws.DataAwsDynamodbTable.DataAwsDynamodbTableTtlList>()!;
        }

        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteCapacity
        {
            get => GetInstanceProperty<double>()!;
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
        [JsiiProperty(name: "serverSideEncryptionInput", typeJson: "{\"fqn\":\"aws.dataAwsDynamodbTable.DataAwsDynamodbTableServerSideEncryption\"}", isOptional: true)]
        public virtual aws.DataAwsDynamodbTable.IDataAwsDynamodbTableServerSideEncryption? ServerSideEncryptionInput
        {
            get => GetInstanceProperty<aws.DataAwsDynamodbTable.IDataAwsDynamodbTableServerSideEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
