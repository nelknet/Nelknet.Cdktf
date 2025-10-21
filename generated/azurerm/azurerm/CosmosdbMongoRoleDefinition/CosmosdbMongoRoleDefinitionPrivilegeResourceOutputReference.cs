using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbMongoRoleDefinition
{
    [JsiiClass(nativeType: typeof(azurerm.CosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilegeResourceOutputReference), fullyQualifiedName: "azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilegeResourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CosmosdbMongoRoleDefinitionPrivilegeResourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CosmosdbMongoRoleDefinitionPrivilegeResourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CosmosdbMongoRoleDefinitionPrivilegeResourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbMongoRoleDefinitionPrivilegeResourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCollectionName")]
        public virtual void ResetCollectionName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbName")]
        public virtual void ResetDbName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "collectionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CollectionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "collectionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CollectionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilegeResource\"}", isOptional: true)]
        public virtual azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionPrivilegeResource? InternalValue
        {
            get => GetInstanceProperty<azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionPrivilegeResource?>();
            set => SetInstanceProperty(value);
        }
    }
}
