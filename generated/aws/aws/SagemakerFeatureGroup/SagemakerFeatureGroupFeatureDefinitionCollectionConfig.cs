using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiByValue(fqn: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfig")]
    public class SagemakerFeatureGroupFeatureDefinitionCollectionConfig : aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfig
    {
        /// <summary>vector_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#vector_config SagemakerFeatureGroup#vector_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vectorConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig\"}", isOptional: true)]
        public aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig? VectorConfig
        {
            get;
            set;
        }
    }
}
