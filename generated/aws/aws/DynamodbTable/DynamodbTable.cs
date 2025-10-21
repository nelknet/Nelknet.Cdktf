using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table aws_dynamodb_table}.</summary>
    [JsiiClass(nativeType: typeof(aws.DynamodbTable.DynamodbTable), fullyQualifiedName: "aws.dynamodbTable.DynamodbTable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableConfig\"}}]")]
    public class DynamodbTable : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table aws_dynamodb_table} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DynamodbTable(Constructs.Construct scope, string id, aws.DynamodbTable.IDynamodbTableConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DynamodbTable.IDynamodbTableConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTable(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DynamodbTable resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DynamodbTable to import.</param>
        /// <param name="importFromId">The id of the existing DynamodbTable that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DynamodbTable to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DynamodbTable to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DynamodbTable that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DynamodbTable to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DynamodbTable.DynamodbTable), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAttribute", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableAttribute\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAttribute(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.DynamodbTable.IDynamodbTableAttribute[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DynamodbTable.IDynamodbTableAttribute).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DynamodbTable.IDynamodbTableAttribute).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGlobalSecondaryIndex", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableGlobalSecondaryIndex\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGlobalSecondaryIndex(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndex[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndex).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndex).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImportTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTable\"}}]")]
        public virtual void PutImportTable(aws.DynamodbTable.IDynamodbTableImportTable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbTable.IDynamodbTableImportTable)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLocalSecondaryIndex", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableLocalSecondaryIndex\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLocalSecondaryIndex(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.DynamodbTable.IDynamodbTableLocalSecondaryIndex[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DynamodbTable.IDynamodbTableLocalSecondaryIndex).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DynamodbTable.IDynamodbTableLocalSecondaryIndex).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOnDemandThroughput", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableOnDemandThroughput\"}}]")]
        public virtual void PutOnDemandThroughput(aws.DynamodbTable.IDynamodbTableOnDemandThroughput @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbTable.IDynamodbTableOnDemandThroughput)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPointInTimeRecovery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbTable.DynamodbTablePointInTimeRecovery\"}}]")]
        public virtual void PutPointInTimeRecovery(aws.DynamodbTable.IDynamodbTablePointInTimeRecovery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbTable.IDynamodbTablePointInTimeRecovery)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReplica", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableReplica\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutReplica(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.DynamodbTable.IDynamodbTableReplica[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DynamodbTable.IDynamodbTableReplica).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DynamodbTable.IDynamodbTableReplica).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServerSideEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableServerSideEncryption\"}}]")]
        public virtual void PutServerSideEncryption(aws.DynamodbTable.IDynamodbTableServerSideEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbTable.IDynamodbTableServerSideEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.DynamodbTable.IDynamodbTableTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbTable.IDynamodbTableTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTtl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableTtl\"}}]")]
        public virtual void PutTtl(aws.DynamodbTable.IDynamodbTableTtl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbTable.IDynamodbTableTtl)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttribute")]
        public virtual void ResetAttribute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBillingMode")]
        public virtual void ResetBillingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeletionProtectionEnabled")]
        public virtual void ResetDeletionProtectionEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGlobalSecondaryIndex")]
        public virtual void ResetGlobalSecondaryIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHashKey")]
        public virtual void ResetHashKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImportTable")]
        public virtual void ResetImportTable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalSecondaryIndex")]
        public virtual void ResetLocalSecondaryIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnDemandThroughput")]
        public virtual void ResetOnDemandThroughput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPointInTimeRecovery")]
        public virtual void ResetPointInTimeRecovery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRangeKey")]
        public virtual void ResetRangeKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadCapacity")]
        public virtual void ResetReadCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplica")]
        public virtual void ResetReplica()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestoreDateTime")]
        public virtual void ResetRestoreDateTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestoreSourceName")]
        public virtual void ResetRestoreSourceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestoreSourceTableArn")]
        public virtual void ResetRestoreSourceTableArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestoreToLatestTime")]
        public virtual void ResetRestoreToLatestTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerSideEncryption")]
        public virtual void ResetServerSideEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamEnabled")]
        public virtual void ResetStreamEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamViewType")]
        public virtual void ResetStreamViewType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTableClass")]
        public virtual void ResetTableClass()
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

        [JsiiMethod(name: "resetWriteCapacity")]
        public virtual void ResetWriteCapacity()
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
        = GetStaticProperty<string>(typeof(aws.DynamodbTable.DynamodbTable))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attribute", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableAttributeList\"}")]
        public virtual aws.DynamodbTable.DynamodbTableAttributeList Attribute
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTableAttributeList>()!;
        }

        [JsiiProperty(name: "globalSecondaryIndex", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexList\"}")]
        public virtual aws.DynamodbTable.DynamodbTableGlobalSecondaryIndexList GlobalSecondaryIndex
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTableGlobalSecondaryIndexList>()!;
        }

        [JsiiProperty(name: "importTable", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableOutputReference\"}")]
        public virtual aws.DynamodbTable.DynamodbTableImportTableOutputReference ImportTable
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTableImportTableOutputReference>()!;
        }

        [JsiiProperty(name: "localSecondaryIndex", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableLocalSecondaryIndexList\"}")]
        public virtual aws.DynamodbTable.DynamodbTableLocalSecondaryIndexList LocalSecondaryIndex
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTableLocalSecondaryIndexList>()!;
        }

        [JsiiProperty(name: "onDemandThroughput", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableOnDemandThroughputOutputReference\"}")]
        public virtual aws.DynamodbTable.DynamodbTableOnDemandThroughputOutputReference OnDemandThroughput
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTableOnDemandThroughputOutputReference>()!;
        }

        [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTablePointInTimeRecoveryOutputReference\"}")]
        public virtual aws.DynamodbTable.DynamodbTablePointInTimeRecoveryOutputReference PointInTimeRecovery
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTablePointInTimeRecoveryOutputReference>()!;
        }

        [JsiiProperty(name: "replica", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableReplicaList\"}")]
        public virtual aws.DynamodbTable.DynamodbTableReplicaList Replica
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTableReplicaList>()!;
        }

        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableServerSideEncryptionOutputReference\"}")]
        public virtual aws.DynamodbTable.DynamodbTableServerSideEncryptionOutputReference ServerSideEncryption
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTableServerSideEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableTimeoutsOutputReference\"}")]
        public virtual aws.DynamodbTable.DynamodbTableTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTableTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableTtlOutputReference\"}")]
        public virtual aws.DynamodbTable.DynamodbTableTtlOutputReference Ttl
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTableTtlOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableAttribute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AttributeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BillingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deletionProtectionEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeletionProtectionEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "globalSecondaryIndexInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableGlobalSecondaryIndex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GlobalSecondaryIndexInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hashKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HashKeyInput
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
        [JsiiProperty(name: "importTableInput", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTable\"}", isOptional: true)]
        public virtual aws.DynamodbTable.IDynamodbTableImportTable? ImportTableInput
        {
            get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableImportTable?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localSecondaryIndexInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableLocalSecondaryIndex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LocalSecondaryIndexInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandThroughputInput", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableOnDemandThroughput\"}", isOptional: true)]
        public virtual aws.DynamodbTable.IDynamodbTableOnDemandThroughput? OnDemandThroughputInput
        {
            get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableOnDemandThroughput?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pointInTimeRecoveryInput", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTablePointInTimeRecovery\"}", isOptional: true)]
        public virtual aws.DynamodbTable.IDynamodbTablePointInTimeRecovery? PointInTimeRecoveryInput
        {
            get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTablePointInTimeRecovery?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rangeKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RangeKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReadCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableReplica\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ReplicaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreDateTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RestoreDateTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreSourceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RestoreSourceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreSourceTableArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RestoreSourceTableArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreToLatestTimeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RestoreToLatestTimeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionInput", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableServerSideEncryption\"}", isOptional: true)]
        public virtual aws.DynamodbTable.IDynamodbTableServerSideEncryption? ServerSideEncryptionInput
        {
            get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableServerSideEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StreamEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamViewTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreamViewTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableClassInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.dynamodbTable.DynamodbTableTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ttlInput", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableTtl\"}", isOptional: true)]
        public virtual aws.DynamodbTable.IDynamodbTableTtl? TtlInput
        {
            get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableTtl?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WriteCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "billingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deletionProtectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DeletionProtectionEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashKey
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

        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RangeKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restoreDateTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestoreDateTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restoreSourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestoreSourceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restoreSourceTableArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestoreSourceTableArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restoreToLatestTime", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RestoreToLatestTime
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "streamEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object StreamEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "streamViewType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamViewType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableClass
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

        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
