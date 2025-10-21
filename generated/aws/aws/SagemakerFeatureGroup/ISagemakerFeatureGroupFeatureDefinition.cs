using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiInterface(nativeType: typeof(ISagemakerFeatureGroupFeatureDefinition), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinition")]
    public interface ISagemakerFeatureGroupFeatureDefinition
    {
        /// <summary>collection_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#collection_config SagemakerFeatureGroup#collection_config}
        /// </remarks>
        [JsiiProperty(name: "collectionConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfig? CollectionConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#collection_type SagemakerFeatureGroup#collection_type}.</summary>
        [JsiiProperty(name: "collectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CollectionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#feature_name SagemakerFeatureGroup#feature_name}.</summary>
        [JsiiProperty(name: "featureName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FeatureName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#feature_type SagemakerFeatureGroup#feature_type}.</summary>
        [JsiiProperty(name: "featureType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FeatureType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFeatureGroupFeatureDefinition), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>collection_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#collection_config SagemakerFeatureGroup#collection_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "collectionConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfig\"}", isOptional: true)]
            public aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfig? CollectionConfig
            {
                get => GetInstanceProperty<aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#collection_type SagemakerFeatureGroup#collection_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "collectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CollectionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#feature_name SagemakerFeatureGroup#feature_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "featureName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FeatureName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#feature_type SagemakerFeatureGroup#feature_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "featureType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FeatureType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
