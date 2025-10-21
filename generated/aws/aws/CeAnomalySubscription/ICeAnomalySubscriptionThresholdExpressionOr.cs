using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeAnomalySubscription
{
    [JsiiInterface(nativeType: typeof(ICeAnomalySubscriptionThresholdExpressionOr), fullyQualifiedName: "aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOr")]
    public interface ICeAnomalySubscriptionThresholdExpressionOr
    {
        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#cost_category CeAnomalySubscription#cost_category}
        /// </remarks>
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOrCostCategory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOrCostCategory? CostCategory
        {
            get
            {
                return null;
            }
        }

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#dimension CeAnomalySubscription#dimension}
        /// </remarks>
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOrDimension\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOrDimension? Dimension
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#tags CeAnomalySubscription#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOrTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOrTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICeAnomalySubscriptionThresholdExpressionOr), fullyQualifiedName: "aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOr")]
        internal sealed class _Proxy : DeputyBase, aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOr
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cost_category block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#cost_category CeAnomalySubscription#cost_category}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOrCostCategory\"}", isOptional: true)]
            public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOrCostCategory? CostCategory
            {
                get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOrCostCategory?>();
            }

            /// <summary>dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#dimension CeAnomalySubscription#dimension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOrDimension\"}", isOptional: true)]
            public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOrDimension? Dimension
            {
                get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOrDimension?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#tags CeAnomalySubscription#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOrTags\"}", isOptional: true)]
            public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOrTags? Tags
            {
                get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOrTags?>();
            }
        }
    }
}
