using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiInterface(nativeType: typeof(ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig")]
    public interface ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#dimension SagemakerFeatureGroup#dimension}.</summary>
        [JsiiProperty(name: "dimension", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Dimension
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerFeatureGroup.ISagemakerFeatureGroupFeatureDefinitionCollectionConfigVectorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#dimension SagemakerFeatureGroup#dimension}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Dimension
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
