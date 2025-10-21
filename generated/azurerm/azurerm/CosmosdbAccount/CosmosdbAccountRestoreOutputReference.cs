using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbAccount
{
    [JsiiClass(nativeType: typeof(azurerm.CosmosdbAccount.CosmosdbAccountRestoreOutputReference), fullyQualifiedName: "azurerm.cosmosdbAccount.CosmosdbAccountRestoreOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CosmosdbAccountRestoreOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CosmosdbAccountRestoreOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbAccountRestoreOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbAccountRestoreOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbAccount.CosmosdbAccountRestoreDatabase\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDatabase(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CosmosdbAccount.ICosmosdbAccountRestoreDatabase[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbAccount.ICosmosdbAccountRestoreDatabase).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbAccount.ICosmosdbAccountRestoreDatabase).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGremlinDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbAccount.CosmosdbAccountRestoreGremlinDatabase\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGremlinDatabase(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CosmosdbAccount.ICosmosdbAccountRestoreGremlinDatabase[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbAccount.ICosmosdbAccountRestoreGremlinDatabase).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbAccount.ICosmosdbAccountRestoreGremlinDatabase).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDatabase")]
        public virtual void ResetDatabase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGremlinDatabase")]
        public virtual void ResetGremlinDatabase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTablesToRestore")]
        public virtual void ResetTablesToRestore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"azurerm.cosmosdbAccount.CosmosdbAccountRestoreDatabaseList\"}")]
        public virtual azurerm.CosmosdbAccount.CosmosdbAccountRestoreDatabaseList Database
        {
            get => GetInstanceProperty<azurerm.CosmosdbAccount.CosmosdbAccountRestoreDatabaseList>()!;
        }

        [JsiiProperty(name: "gremlinDatabase", typeJson: "{\"fqn\":\"azurerm.cosmosdbAccount.CosmosdbAccountRestoreGremlinDatabaseList\"}")]
        public virtual azurerm.CosmosdbAccount.CosmosdbAccountRestoreGremlinDatabaseList GremlinDatabase
        {
            get => GetInstanceProperty<azurerm.CosmosdbAccount.CosmosdbAccountRestoreGremlinDatabaseList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbAccount.CosmosdbAccountRestoreDatabase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DatabaseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gremlinDatabaseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbAccount.CosmosdbAccountRestoreGremlinDatabase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GremlinDatabaseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreTimestampInUtcInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RestoreTimestampInUtcInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceCosmosdbAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceCosmosdbAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tablesToRestoreInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TablesToRestoreInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "restoreTimestampInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestoreTimestampInUtc
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceCosmosdbAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCosmosdbAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tablesToRestore", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TablesToRestore
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cosmosdbAccount.CosmosdbAccountRestore\"}", isOptional: true)]
        public virtual azurerm.CosmosdbAccount.ICosmosdbAccountRestore? InternalValue
        {
            get => GetInstanceProperty<azurerm.CosmosdbAccount.ICosmosdbAccountRestore?>();
            set => SetInstanceProperty(value);
        }
    }
}
