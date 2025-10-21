using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiByValue(fqn: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigTtlDuration")]
    public class SagemakerFeatureGroupOnlineStoreConfigTtlDuration : aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigTtlDuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#unit SagemakerFeatureGroup#unit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Unit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#value SagemakerFeatureGroup#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Value
        {
            get;
            set;
        }
    }
}
