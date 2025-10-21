using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiClass(nativeType: typeof(aws.SagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigOutputReference), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerFeatureGroupFeatureDefinitionCollectionConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerFeatureGroupFeatureDefinitionCollectionConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerFeatureGroupFeatureDefinitionCollectionConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFeatureGroupFeatureDefinitionCollectionConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putVectorConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig\"}}]")]
        public virtual void PutVectorConfig(aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetVectorConfig")]
        public virtual void ResetVectorConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "vectorConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfigOutputReference\"}")]
        public virtual aws.SagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfigOutputReference VectorConfig
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vectorConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig\"}", isOptional: true)]
        public virtual aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig? VectorConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfig\"}", isOptional: true)]
        public virtual aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
