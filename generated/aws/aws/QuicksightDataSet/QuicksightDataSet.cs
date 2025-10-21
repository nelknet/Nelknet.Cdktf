using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set aws_quicksight_data_set}.</summary>
    [JsiiClass(nativeType: typeof(aws.QuicksightDataSet.QuicksightDataSet), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetConfig\"}}]")]
    public class QuicksightDataSet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set aws_quicksight_data_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public QuicksightDataSet(Constructs.Construct scope, string id, aws.QuicksightDataSet.IQuicksightDataSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.QuicksightDataSet.IQuicksightDataSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a QuicksightDataSet resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the QuicksightDataSet to import.</param>
        /// <param name="importFromId">The id of the existing QuicksightDataSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the QuicksightDataSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the QuicksightDataSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing QuicksightDataSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the QuicksightDataSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.QuicksightDataSet.QuicksightDataSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putColumnGroups", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetColumnGroups\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutColumnGroups(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightDataSet.IQuicksightDataSetColumnGroups[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetColumnGroups).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetColumnGroups).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putColumnLevelPermissionRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetColumnLevelPermissionRules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutColumnLevelPermissionRules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightDataSet.IQuicksightDataSetColumnLevelPermissionRules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetColumnLevelPermissionRules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetColumnLevelPermissionRules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataSetUsageConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetDataSetUsageConfiguration\"}}]")]
        public virtual void PutDataSetUsageConfiguration(aws.QuicksightDataSet.IQuicksightDataSetDataSetUsageConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetDataSetUsageConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFieldFolders", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetFieldFolders\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFieldFolders(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightDataSet.IQuicksightDataSetFieldFolders[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetFieldFolders).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetFieldFolders).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogicalTableMap", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMap\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogicalTableMap(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMap[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMap).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMap).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPermissions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPermissions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPermissions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightDataSet.IQuicksightDataSetPermissions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetPermissions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetPermissions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPhysicalTableMap", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMap\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPhysicalTableMap(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMap[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMap).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMap).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRefreshProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshProperties\"}}]")]
        public virtual void PutRefreshProperties(aws.QuicksightDataSet.IQuicksightDataSetRefreshProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetRefreshProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRowLevelPermissionDataSet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionDataSet\"}}]")]
        public virtual void PutRowLevelPermissionDataSet(aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionDataSet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionDataSet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRowLevelPermissionTagConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfiguration\"}}]")]
        public virtual void PutRowLevelPermissionTagConfiguration(aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionTagConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionTagConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAwsAccountId")]
        public virtual void ResetAwsAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetColumnGroups")]
        public virtual void ResetColumnGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetColumnLevelPermissionRules")]
        public virtual void ResetColumnLevelPermissionRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataSetUsageConfiguration")]
        public virtual void ResetDataSetUsageConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFieldFolders")]
        public virtual void ResetFieldFolders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogicalTableMap")]
        public virtual void ResetLogicalTableMap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPermissions")]
        public virtual void ResetPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhysicalTableMap")]
        public virtual void ResetPhysicalTableMap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefreshProperties")]
        public virtual void ResetRefreshProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRowLevelPermissionDataSet")]
        public virtual void ResetRowLevelPermissionDataSet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRowLevelPermissionTagConfiguration")]
        public virtual void ResetRowLevelPermissionTagConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.QuicksightDataSet.QuicksightDataSet))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "columnGroups", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetColumnGroupsList\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetColumnGroupsList ColumnGroups
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetColumnGroupsList>()!;
        }

        [JsiiProperty(name: "columnLevelPermissionRules", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetColumnLevelPermissionRulesList\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetColumnLevelPermissionRulesList ColumnLevelPermissionRules
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetColumnLevelPermissionRulesList>()!;
        }

        [JsiiProperty(name: "dataSetUsageConfiguration", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetDataSetUsageConfigurationOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetDataSetUsageConfigurationOutputReference DataSetUsageConfiguration
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetDataSetUsageConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "fieldFolders", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetFieldFoldersList\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetFieldFoldersList FieldFolders
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetFieldFoldersList>()!;
        }

        [JsiiProperty(name: "logicalTableMap", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapList\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapList LogicalTableMap
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetLogicalTableMapList>()!;
        }

        [JsiiProperty(name: "outputColumns", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetOutputColumnsList\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetOutputColumnsList OutputColumns
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetOutputColumnsList>()!;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPermissionsList\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetPermissionsList Permissions
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetPermissionsList>()!;
        }

        [JsiiProperty(name: "physicalTableMap", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapList\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapList PhysicalTableMap
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMapList>()!;
        }

        [JsiiProperty(name: "refreshProperties", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetRefreshPropertiesOutputReference RefreshProperties
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetRefreshPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "rowLevelPermissionDataSet", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionDataSetOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetRowLevelPermissionDataSetOutputReference RowLevelPermissionDataSet
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetRowLevelPermissionDataSetOutputReference>()!;
        }

        [JsiiProperty(name: "rowLevelPermissionTagConfiguration", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfigurationOutputReference\"}")]
        public virtual aws.QuicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfigurationOutputReference RowLevelPermissionTagConfiguration
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "columnGroupsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetColumnGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ColumnGroupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "columnLevelPermissionRulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetColumnLevelPermissionRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ColumnLevelPermissionRulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSetUsageConfigurationInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetDataSetUsageConfiguration\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetDataSetUsageConfiguration? DataSetUsageConfigurationInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetDataSetUsageConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldFoldersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetFieldFolders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FieldFoldersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "importModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImportModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logicalTableMapInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogicalTableMapInput
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
        [JsiiProperty(name: "permissionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPermissions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PermissionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "physicalTableMapInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PhysicalTableMapInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshPropertiesInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshProperties\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetRefreshProperties? RefreshPropertiesInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetRefreshProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rowLevelPermissionDataSetInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionDataSet\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionDataSet? RowLevelPermissionDataSetInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionDataSet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rowLevelPermissionTagConfigurationInput", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfiguration\"}", isOptional: true)]
        public virtual aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionTagConfiguration? RowLevelPermissionTagConfigurationInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionTagConfiguration?>();
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

        [JsiiProperty(name: "awsAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSetId
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

        [JsiiProperty(name: "importMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImportMode
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
