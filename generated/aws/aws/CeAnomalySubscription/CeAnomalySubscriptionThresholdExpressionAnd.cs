using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeAnomalySubscription
{
    [JsiiByValue(fqn: "aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAnd")]
    public class CeAnomalySubscriptionThresholdExpressionAnd : aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAnd
    {
        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#cost_category CeAnomalySubscription#cost_category}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndCostCategory\"}", isOptional: true)]
        public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndCostCategory? CostCategory
        {
            get;
            set;
        }

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#dimension CeAnomalySubscription#dimension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndDimension\"}", isOptional: true)]
        public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndDimension? Dimension
        {
            get;
            set;
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#tags CeAnomalySubscription#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndTags\"}", isOptional: true)]
        public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndTags? Tags
        {
            get;
            set;
        }
    }
}
