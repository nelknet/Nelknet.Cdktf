using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table aws_glue_catalog_table}.</summary>
    [JsiiClass(nativeType: typeof(aws.GlueCatalogTable.GlueCatalogTable), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableConfig\"}}]")]
    public class GlueCatalogTable : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table aws_glue_catalog_table} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlueCatalogTable(Constructs.Construct scope, string id, aws.GlueCatalogTable.IGlueCatalogTableConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.GlueCatalogTable.IGlueCatalogTableConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTable(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a GlueCatalogTable resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the GlueCatalogTable to import.</param>
        /// <param name="importFromId">The id of the existing GlueCatalogTable that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the GlueCatalogTable to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the GlueCatalogTable to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing GlueCatalogTable that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the GlueCatalogTable to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.GlueCatalogTable.GlueCatalogTable), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putOpenTableFormatInput", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInput\"}}]")]
        public virtual void PutOpenTableFormatInput(aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInput @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInput)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPartitionIndex", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTablePartitionIndex\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPartitionIndex(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCatalogTable.IGlueCatalogTablePartitionIndex[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTablePartitionIndex).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTablePartitionIndex).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPartitionKeys", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTablePartitionKeys\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPartitionKeys(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCatalogTable.IGlueCatalogTablePartitionKeys[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTablePartitionKeys).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTablePartitionKeys).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageDescriptor", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptor\"}}]")]
        public virtual void PutStorageDescriptor(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptor @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptor)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableTargetTable\"}}]")]
        public virtual void PutTargetTable(aws.GlueCatalogTable.IGlueCatalogTableTargetTable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueCatalogTable.IGlueCatalogTableTargetTable)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalogId")]
        public virtual void ResetCatalogId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenTableFormatInput")]
        public virtual void ResetOpenTableFormatInput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOwner")]
        public virtual void ResetOwner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartitionIndex")]
        public virtual void ResetPartitionIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartitionKeys")]
        public virtual void ResetPartitionKeys()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetention")]
        public virtual void ResetRetention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageDescriptor")]
        public virtual void ResetStorageDescriptor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTableType")]
        public virtual void ResetTableType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetTable")]
        public virtual void ResetTargetTable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetViewExpandedText")]
        public virtual void ResetViewExpandedText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetViewOriginalText")]
        public virtual void ResetViewOriginalText()
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
        = GetStaticProperty<string>(typeof(aws.GlueCatalogTable.GlueCatalogTable))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "openTableFormatInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputOutputReference\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTableOpenTableFormatInputOutputReference OpenTableFormatInput
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTableOpenTableFormatInputOutputReference>()!;
        }

        [JsiiProperty(name: "partitionIndex", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTablePartitionIndexList\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTablePartitionIndexList PartitionIndex
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTablePartitionIndexList>()!;
        }

        [JsiiProperty(name: "partitionKeys", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTablePartitionKeysList\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTablePartitionKeysList PartitionKeys
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTablePartitionKeysList>()!;
        }

        [JsiiProperty(name: "storageDescriptor", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorOutputReference\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorOutputReference StorageDescriptor
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorOutputReference>()!;
        }

        [JsiiProperty(name: "targetTable", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableTargetTableOutputReference\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTableTargetTableOutputReference TargetTable
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTableTargetTableOutputReference>()!;
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
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
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
        [JsiiProperty(name: "openTableFormatInputInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInput\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInput? OpenTableFormatInputInput
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInput?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OwnerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionIndexInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTablePartitionIndex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PartitionIndexInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionKeysInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTablePartitionKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PartitionKeysInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageDescriptorInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptor\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptor? StorageDescriptorInput
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptor?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetTableInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableTargetTable\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableTargetTable? TargetTableInput
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableTargetTable?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewExpandedTextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewExpandedTextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewOriginalTextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewOriginalTextInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retention", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Retention
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewExpandedText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewExpandedText
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewOriginalText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewOriginalText
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
