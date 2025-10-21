using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbAccount
{
    [JsiiClass(nativeType: typeof(azurerm.CosmosdbAccount.CosmosdbAccountConsistencyPolicyOutputReference), fullyQualifiedName: "azurerm.cosmosdbAccount.CosmosdbAccountConsistencyPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CosmosdbAccountConsistencyPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CosmosdbAccountConsistencyPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CosmosdbAccountConsistencyPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbAccountConsistencyPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxIntervalInSeconds")]
        public virtual void ResetMaxIntervalInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxStalenessPrefix")]
        public virtual void ResetMaxStalenessPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "consistencyLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConsistencyLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxIntervalInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxIntervalInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxStalenessPrefixInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxStalenessPrefixInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "consistencyLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsistencyLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxIntervalInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxStalenessPrefix", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxStalenessPrefix
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cosmosdbAccount.CosmosdbAccountConsistencyPolicy\"}", isOptional: true)]
        public virtual azurerm.CosmosdbAccount.ICosmosdbAccountConsistencyPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.CosmosdbAccount.ICosmosdbAccountConsistencyPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
