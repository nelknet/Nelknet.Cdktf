using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table aws_keyspaces_table}.</summary>
    [JsiiClass(nativeType: typeof(aws.KeyspacesTable.KeyspacesTable), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableConfig\"}}]")]
    public class KeyspacesTable : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table aws_keyspaces_table} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KeyspacesTable(Constructs.Construct scope, string id, aws.KeyspacesTable.IKeyspacesTableConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.KeyspacesTable.IKeyspacesTableConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KeyspacesTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KeyspacesTable(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a KeyspacesTable resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KeyspacesTable to import.</param>
        /// <param name="importFromId">The id of the existing KeyspacesTable that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KeyspacesTable to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KeyspacesTable to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KeyspacesTable that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KeyspacesTable to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.KeyspacesTable.KeyspacesTable), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCapacitySpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableCapacitySpecification\"}}]")]
        public virtual void PutCapacitySpecification(aws.KeyspacesTable.IKeyspacesTableCapacitySpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KeyspacesTable.IKeyspacesTableCapacitySpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientSideTimestamps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableClientSideTimestamps\"}}]")]
        public virtual void PutClientSideTimestamps(aws.KeyspacesTable.IKeyspacesTableClientSideTimestamps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KeyspacesTable.IKeyspacesTableClientSideTimestamps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComment", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableComment\"}}]")]
        public virtual void PutComment(aws.KeyspacesTable.IKeyspacesTableComment @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KeyspacesTable.IKeyspacesTableComment)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptionSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableEncryptionSpecification\"}}]")]
        public virtual void PutEncryptionSpecification(aws.KeyspacesTable.IKeyspacesTableEncryptionSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KeyspacesTable.IKeyspacesTableEncryptionSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPointInTimeRecovery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTablePointInTimeRecovery\"}}]")]
        public virtual void PutPointInTimeRecovery(aws.KeyspacesTable.IKeyspacesTablePointInTimeRecovery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KeyspacesTable.IKeyspacesTablePointInTimeRecovery)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchemaDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinition\"}}]")]
        public virtual void PutSchemaDefinition(aws.KeyspacesTable.IKeyspacesTableSchemaDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KeyspacesTable.IKeyspacesTableSchemaDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.KeyspacesTable.IKeyspacesTableTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KeyspacesTable.IKeyspacesTableTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTtl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.keyspacesTable.KeyspacesTableTtl\"}}]")]
        public virtual void PutTtl(aws.KeyspacesTable.IKeyspacesTableTtl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KeyspacesTable.IKeyspacesTableTtl)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacitySpecification")]
        public virtual void ResetCapacitySpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientSideTimestamps")]
        public virtual void ResetClientSideTimestamps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComment")]
        public virtual void ResetComment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultTimeToLive")]
        public virtual void ResetDefaultTimeToLive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionSpecification")]
        public virtual void ResetEncryptionSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPointInTimeRecovery")]
        public virtual void ResetPointInTimeRecovery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTtl")]
        public virtual void ResetTtl()
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
        = GetStaticProperty<string>(typeof(aws.KeyspacesTable.KeyspacesTable))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacitySpecification", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableCapacitySpecificationOutputReference\"}")]
        public virtual aws.KeyspacesTable.KeyspacesTableCapacitySpecificationOutputReference CapacitySpecification
        {
            get => GetInstanceProperty<aws.KeyspacesTable.KeyspacesTableCapacitySpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "clientSideTimestamps", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableClientSideTimestampsOutputReference\"}")]
        public virtual aws.KeyspacesTable.KeyspacesTableClientSideTimestampsOutputReference ClientSideTimestamps
        {
            get => GetInstanceProperty<aws.KeyspacesTable.KeyspacesTableClientSideTimestampsOutputReference>()!;
        }

        [JsiiProperty(name: "comment", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableCommentOutputReference\"}")]
        public virtual aws.KeyspacesTable.KeyspacesTableCommentOutputReference Comment
        {
            get => GetInstanceProperty<aws.KeyspacesTable.KeyspacesTableCommentOutputReference>()!;
        }

        [JsiiProperty(name: "encryptionSpecification", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableEncryptionSpecificationOutputReference\"}")]
        public virtual aws.KeyspacesTable.KeyspacesTableEncryptionSpecificationOutputReference EncryptionSpecification
        {
            get => GetInstanceProperty<aws.KeyspacesTable.KeyspacesTableEncryptionSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTablePointInTimeRecoveryOutputReference\"}")]
        public virtual aws.KeyspacesTable.KeyspacesTablePointInTimeRecoveryOutputReference PointInTimeRecovery
        {
            get => GetInstanceProperty<aws.KeyspacesTable.KeyspacesTablePointInTimeRecoveryOutputReference>()!;
        }

        [JsiiProperty(name: "schemaDefinition", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinitionOutputReference\"}")]
        public virtual aws.KeyspacesTable.KeyspacesTableSchemaDefinitionOutputReference SchemaDefinition
        {
            get => GetInstanceProperty<aws.KeyspacesTable.KeyspacesTableSchemaDefinitionOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableTimeoutsOutputReference\"}")]
        public virtual aws.KeyspacesTable.KeyspacesTableTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.KeyspacesTable.KeyspacesTableTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableTtlOutputReference\"}")]
        public virtual aws.KeyspacesTable.KeyspacesTableTtlOutputReference Ttl
        {
            get => GetInstanceProperty<aws.KeyspacesTable.KeyspacesTableTtlOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacitySpecificationInput", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableCapacitySpecification\"}", isOptional: true)]
        public virtual aws.KeyspacesTable.IKeyspacesTableCapacitySpecification? CapacitySpecificationInput
        {
            get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableCapacitySpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientSideTimestampsInput", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableClientSideTimestamps\"}", isOptional: true)]
        public virtual aws.KeyspacesTable.IKeyspacesTableClientSideTimestamps? ClientSideTimestampsInput
        {
            get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableClientSideTimestamps?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commentInput", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableComment\"}", isOptional: true)]
        public virtual aws.KeyspacesTable.IKeyspacesTableComment? CommentInput
        {
            get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableComment?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultTimeToLiveInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultTimeToLiveInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionSpecificationInput", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableEncryptionSpecification\"}", isOptional: true)]
        public virtual aws.KeyspacesTable.IKeyspacesTableEncryptionSpecification? EncryptionSpecificationInput
        {
            get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableEncryptionSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyspaceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyspaceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pointInTimeRecoveryInput", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTablePointInTimeRecovery\"}", isOptional: true)]
        public virtual aws.KeyspacesTable.IKeyspacesTablePointInTimeRecovery? PointInTimeRecoveryInput
        {
            get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTablePointInTimeRecovery?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaDefinitionInput", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinition\"}", isOptional: true)]
        public virtual aws.KeyspacesTable.IKeyspacesTableSchemaDefinition? SchemaDefinitionInput
        {
            get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableSchemaDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.keyspacesTable.KeyspacesTableTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ttlInput", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableTtl\"}", isOptional: true)]
        public virtual aws.KeyspacesTable.IKeyspacesTableTtl? TtlInput
        {
            get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableTtl?>();
        }

        [JsiiProperty(name: "defaultTimeToLive", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultTimeToLive
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

        [JsiiProperty(name: "keyspaceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyspaceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
