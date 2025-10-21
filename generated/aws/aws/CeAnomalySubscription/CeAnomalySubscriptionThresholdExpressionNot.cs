using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeAnomalySubscription
{
    [JsiiByValue(fqn: "aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNot")]
    public class CeAnomalySubscriptionThresholdExpressionNot : aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNot
    {
        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#cost_category CeAnomalySubscription#cost_category}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotCostCategory\"}", isOptional: true)]
        public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotCostCategory? CostCategory
        {
            get;
            set;
        }

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#dimension CeAnomalySubscription#dimension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotDimension\"}", isOptional: true)]
        public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotDimension? Dimension
        {
            get;
            set;
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#tags CeAnomalySubscription#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotTags\"}", isOptional: true)]
        public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotTags? Tags
        {
            get;
            set;
        }
    }
}
