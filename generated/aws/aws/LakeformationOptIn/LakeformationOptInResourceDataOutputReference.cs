using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationOptIn
{
    [JsiiClass(nativeType: typeof(aws.LakeformationOptIn.LakeformationOptInResourceDataOutputReference), fullyQualifiedName: "aws.lakeformationOptIn.LakeformationOptInResourceDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LakeformationOptInResourceDataOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LakeformationOptInResourceDataOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LakeformationOptInResourceDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LakeformationOptInResourceDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCatalog", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataCatalog\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCatalog(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LakeformationOptIn.ILakeformationOptInResourceDataCatalog[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataCatalog).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataCatalog).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDatabase\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDatabase(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LakeformationOptIn.ILakeformationOptInResourceDataDatabase[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataDatabase).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataDatabase).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataCellsFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDataCellsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDataCellsFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LakeformationOptIn.ILakeformationOptInResourceDataDataCellsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataDataCellsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataDataCellsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDataLocation\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDataLocation(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LakeformationOptIn.ILakeformationOptInResourceDataDataLocation[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataDataLocation).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataDataLocation).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLfTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTag\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLfTag(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTag[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTag).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTag).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLfTagExpression", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagExpression\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLfTagExpression(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTagExpression[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTagExpression).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTagExpression).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLfTagPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagPolicy\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLfTagPolicy(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTagPolicy[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTagPolicy).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTagPolicy).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataTable\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTable(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LakeformationOptIn.ILakeformationOptInResourceDataTable[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataTable).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataTable).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTableWithColumns", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataTableWithColumns\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTableWithColumns(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LakeformationOptIn.ILakeformationOptInResourceDataTableWithColumns[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataTableWithColumns).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataTableWithColumns).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalog")]
        public virtual void ResetCatalog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabase")]
        public virtual void ResetDatabase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataCellsFilter")]
        public virtual void ResetDataCellsFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataLocation")]
        public virtual void ResetDataLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLfTag")]
        public virtual void ResetLfTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLfTagExpression")]
        public virtual void ResetLfTagExpression()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLfTagPolicy")]
        public virtual void ResetLfTagPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTable")]
        public virtual void ResetTable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTableWithColumns")]
        public virtual void ResetTableWithColumns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "catalog", typeJson: "{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataCatalogList\"}")]
        public virtual aws.LakeformationOptIn.LakeformationOptInResourceDataCatalogList Catalog
        {
            get => GetInstanceProperty<aws.LakeformationOptIn.LakeformationOptInResourceDataCatalogList>()!;
        }

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDatabaseList\"}")]
        public virtual aws.LakeformationOptIn.LakeformationOptInResourceDataDatabaseList Database
        {
            get => GetInstanceProperty<aws.LakeformationOptIn.LakeformationOptInResourceDataDatabaseList>()!;
        }

        [JsiiProperty(name: "dataCellsFilter", typeJson: "{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDataCellsFilterList\"}")]
        public virtual aws.LakeformationOptIn.LakeformationOptInResourceDataDataCellsFilterList DataCellsFilter
        {
            get => GetInstanceProperty<aws.LakeformationOptIn.LakeformationOptInResourceDataDataCellsFilterList>()!;
        }

        [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDataLocationList\"}")]
        public virtual aws.LakeformationOptIn.LakeformationOptInResourceDataDataLocationList DataLocation
        {
            get => GetInstanceProperty<aws.LakeformationOptIn.LakeformationOptInResourceDataDataLocationList>()!;
        }

        [JsiiProperty(name: "lfTag", typeJson: "{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagList\"}")]
        public virtual aws.LakeformationOptIn.LakeformationOptInResourceDataLfTagList LfTag
        {
            get => GetInstanceProperty<aws.LakeformationOptIn.LakeformationOptInResourceDataLfTagList>()!;
        }

        [JsiiProperty(name: "lfTagExpression", typeJson: "{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagExpressionList\"}")]
        public virtual aws.LakeformationOptIn.LakeformationOptInResourceDataLfTagExpressionList LfTagExpression
        {
            get => GetInstanceProperty<aws.LakeformationOptIn.LakeformationOptInResourceDataLfTagExpressionList>()!;
        }

        [JsiiProperty(name: "lfTagPolicy", typeJson: "{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagPolicyList\"}")]
        public virtual aws.LakeformationOptIn.LakeformationOptInResourceDataLfTagPolicyList LfTagPolicy
        {
            get => GetInstanceProperty<aws.LakeformationOptIn.LakeformationOptInResourceDataLfTagPolicyList>()!;
        }

        [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataTableList\"}")]
        public virtual aws.LakeformationOptIn.LakeformationOptInResourceDataTableList Table
        {
            get => GetInstanceProperty<aws.LakeformationOptIn.LakeformationOptInResourceDataTableList>()!;
        }

        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataTableWithColumnsList\"}")]
        public virtual aws.LakeformationOptIn.LakeformationOptInResourceDataTableWithColumnsList TableWithColumns
        {
            get => GetInstanceProperty<aws.LakeformationOptIn.LakeformationOptInResourceDataTableWithColumnsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataCatalog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CatalogInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDatabase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DatabaseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataCellsFilterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDataCellsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DataCellsFilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataLocationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDataLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DataLocationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lfTagExpressionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LfTagExpressionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lfTagInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LfTagInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lfTagPolicyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LfTagPolicyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataTable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableWithColumnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataTableWithColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TableWithColumnsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceData\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LakeformationOptIn.ILakeformationOptInResourceData cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceData).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
