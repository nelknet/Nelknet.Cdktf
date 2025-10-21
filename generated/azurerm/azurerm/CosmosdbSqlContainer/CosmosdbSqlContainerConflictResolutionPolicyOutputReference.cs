using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbSqlContainer
{
    [JsiiClass(nativeType: typeof(azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerConflictResolutionPolicyOutputReference), fullyQualifiedName: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerConflictResolutionPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CosmosdbSqlContainerConflictResolutionPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CosmosdbSqlContainerConflictResolutionPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CosmosdbSqlContainerConflictResolutionPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbSqlContainerConflictResolutionPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConflictResolutionPath")]
        public virtual void ResetConflictResolutionPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConflictResolutionProcedure")]
        public virtual void ResetConflictResolutionProcedure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "conflictResolutionPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConflictResolutionPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "conflictResolutionProcedureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConflictResolutionProcedureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "conflictResolutionPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConflictResolutionPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "conflictResolutionProcedure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConflictResolutionProcedure
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerConflictResolutionPolicy\"}", isOptional: true)]
        public virtual azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerConflictResolutionPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerConflictResolutionPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
