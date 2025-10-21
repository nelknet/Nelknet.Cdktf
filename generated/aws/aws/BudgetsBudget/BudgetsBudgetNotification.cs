using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BudgetsBudget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.budgetsBudget.BudgetsBudgetNotification")]
    public class BudgetsBudgetNotification : aws.BudgetsBudget.IBudgetsBudgetNotification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#comparison_operator BudgetsBudget#comparison_operator}.</summary>
        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
        public string ComparisonOperator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#notification_type BudgetsBudget#notification_type}.</summary>
        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}")]
        public string NotificationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#threshold BudgetsBudget#threshold}.</summary>
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
        public double Threshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#threshold_type BudgetsBudget#threshold_type}.</summary>
        [JsiiProperty(name: "thresholdType", typeJson: "{\"primitive\":\"string\"}")]
        public string ThresholdType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#subscriber_email_addresses BudgetsBudget#subscriber_email_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subscriberEmailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SubscriberEmailAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#subscriber_sns_topic_arns BudgetsBudget#subscriber_sns_topic_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subscriberSnsTopicArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SubscriberSnsTopicArns
        {
            get;
            set;
        }
    }
}
