using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbGremlinDatabase
{
    [JsiiClass(nativeType: typeof(azurerm.CosmosdbGremlinDatabase.CosmosdbGremlinDatabaseAutoscaleSettingsOutputReference), fullyQualifiedName: "azurerm.cosmosdbGremlinDatabase.CosmosdbGremlinDatabaseAutoscaleSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CosmosdbGremlinDatabaseAutoscaleSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CosmosdbGremlinDatabaseAutoscaleSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CosmosdbGremlinDatabaseAutoscaleSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CosmosdbGremlinDatabaseAutoscaleSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxThroughput")]
        public virtual void ResetMaxThroughput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxThroughputInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxThroughputInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxThroughput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxThroughput
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cosmosdbGremlinDatabase.CosmosdbGremlinDatabaseAutoscaleSettings\"}", isOptional: true)]
        public virtual azurerm.CosmosdbGremlinDatabase.ICosmosdbGremlinDatabaseAutoscaleSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.CosmosdbGremlinDatabase.ICosmosdbGremlinDatabaseAutoscaleSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
