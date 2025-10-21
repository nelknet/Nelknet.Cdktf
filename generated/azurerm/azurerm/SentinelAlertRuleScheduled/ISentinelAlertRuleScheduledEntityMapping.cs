using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleScheduled
{
    [JsiiInterface(nativeType: typeof(ISentinelAlertRuleScheduledEntityMapping), fullyQualifiedName: "azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledEntityMapping")]
    public interface ISentinelAlertRuleScheduledEntityMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#entity_type SentinelAlertRuleScheduled#entity_type}.</summary>
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
        string EntityType
        {
            get;
        }

        /// <summary>field_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#field_mapping SentinelAlertRuleScheduled#field_mapping}
        /// </remarks>
        [JsiiProperty(name: "fieldMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledEntityMappingFieldMapping\"},\"kind\":\"array\"}}]}}")]
        object FieldMapping
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISentinelAlertRuleScheduledEntityMapping), fullyQualifiedName: "azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledEntityMapping")]
        internal sealed class _Proxy : DeputyBase, azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledEntityMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#entity_type SentinelAlertRuleScheduled#entity_type}.</summary>
            [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
            public string EntityType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>field_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#field_mapping SentinelAlertRuleScheduled#field_mapping}
            /// </remarks>
            [JsiiProperty(name: "fieldMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledEntityMappingFieldMapping\"},\"kind\":\"array\"}}]}}")]
            public object FieldMapping
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
