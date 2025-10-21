using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiInterface(nativeType: typeof(ISagemakerFeatureGroupFeatureDefinitionCollectionConfig), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfig")]
    public interface ISagemakerFeatureGroupFeatureDefinitionCollectionConfig
    {
        /// <summary>vector_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#vector_config SagemakerFeatureGroup#vector_config}
        /// </remarks>
        [JsiiProperty(name: "vectorConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig? VectorConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFeatureGroupFeatureDefinitionCollectionConfig), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>vector_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#vector_config SagemakerFeatureGroup#vector_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vectorConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig\"}", isOptional: true)]
            public aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig? VectorConfig
            {
                get => GetInstanceProperty<aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig?>();
            }
        }
    }
}
