using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeAnomalySubscription
{
    [JsiiInterface(nativeType: typeof(ICeAnomalySubscriptionThresholdExpression), fullyQualifiedName: "aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpression")]
    public interface ICeAnomalySubscriptionThresholdExpression
    {
        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#and CeAnomalySubscription#and}
        /// </remarks>
        [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? And
        {
            get
            {
                return null;
            }
        }

        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#cost_category CeAnomalySubscription#cost_category}
        /// </remarks>
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionCostCategory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionCostCategory? CostCategory
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
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionDimension\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionDimension? Dimension
        {
            get
            {
                return null;
            }
        }

        /// <summary>not block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#not CeAnomalySubscription#not}
        /// </remarks>
        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNot? Not
        {
            get
            {
                return null;
            }
        }

        /// <summary>or block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#or CeAnomalySubscription#or}
        /// </remarks>
        [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Or
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
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICeAnomalySubscriptionThresholdExpression), fullyQualifiedName: "aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpression")]
        internal sealed class _Proxy : DeputyBase, aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpression
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#and CeAnomalySubscription#and}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? And
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cost_category block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#cost_category CeAnomalySubscription#cost_category}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionCostCategory\"}", isOptional: true)]
            public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionCostCategory? CostCategory
            {
                get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionCostCategory?>();
            }

            /// <summary>dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#dimension CeAnomalySubscription#dimension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionDimension\"}", isOptional: true)]
            public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionDimension? Dimension
            {
                get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionDimension?>();
            }

            /// <summary>not block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#not CeAnomalySubscription#not}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNot\"}", isOptional: true)]
            public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNot? Not
            {
                get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNot?>();
            }

            /// <summary>or block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#or CeAnomalySubscription#or}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Or
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_anomaly_subscription#tags CeAnomalySubscription#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionTags\"}", isOptional: true)]
            public aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionTags? Tags
            {
                get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionTags?>();
            }
        }
    }
}
