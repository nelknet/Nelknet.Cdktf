using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiByValue(fqn: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinition")]
    public class SagemakerFeatureGroupFeatureDefinition : aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinition
    {
        /// <summary>collection_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#collection_config SagemakerFeatureGroup#collection_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "collectionConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfig\"}", isOptional: true)]
        public aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfig? CollectionConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#collection_type SagemakerFeatureGroup#collection_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "collectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CollectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#feature_name SagemakerFeatureGroup#feature_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "featureName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FeatureName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#feature_type SagemakerFeatureGroup#feature_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "featureType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FeatureType
        {
            get;
            set;
        }
    }
}
