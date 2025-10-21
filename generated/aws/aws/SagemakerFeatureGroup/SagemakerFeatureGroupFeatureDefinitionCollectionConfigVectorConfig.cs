using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiByValue(fqn: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig")]
    public class SagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig : aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#dimension SagemakerFeatureGroup#dimension}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dimension", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Dimension
        {
            get;
            set;
        }
    }
}
