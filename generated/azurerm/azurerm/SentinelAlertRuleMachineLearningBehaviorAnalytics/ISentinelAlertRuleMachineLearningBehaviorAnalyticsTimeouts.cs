using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleMachineLearningBehaviorAnalytics
{
    [JsiiInterface(nativeType: typeof(ISentinelAlertRuleMachineLearningBehaviorAnalyticsTimeouts), fullyQualifiedName: "azurerm.sentinelAlertRuleMachineLearningBehaviorAnalytics.SentinelAlertRuleMachineLearningBehaviorAnalyticsTimeouts")]
    public interface ISentinelAlertRuleMachineLearningBehaviorAnalyticsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#create SentinelAlertRuleMachineLearningBehaviorAnalytics#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#delete SentinelAlertRuleMachineLearningBehaviorAnalytics#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#read SentinelAlertRuleMachineLearningBehaviorAnalytics#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#update SentinelAlertRuleMachineLearningBehaviorAnalytics#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISentinelAlertRuleMachineLearningBehaviorAnalyticsTimeouts), fullyQualifiedName: "azurerm.sentinelAlertRuleMachineLearningBehaviorAnalytics.SentinelAlertRuleMachineLearningBehaviorAnalyticsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.SentinelAlertRuleMachineLearningBehaviorAnalytics.ISentinelAlertRuleMachineLearningBehaviorAnalyticsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#create SentinelAlertRuleMachineLearningBehaviorAnalytics#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#delete SentinelAlertRuleMachineLearningBehaviorAnalytics#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#read SentinelAlertRuleMachineLearningBehaviorAnalytics#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#update SentinelAlertRuleMachineLearningBehaviorAnalytics#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
