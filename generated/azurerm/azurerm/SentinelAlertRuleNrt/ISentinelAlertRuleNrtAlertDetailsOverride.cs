using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleNrt
{
    [JsiiInterface(nativeType: typeof(ISentinelAlertRuleNrtAlertDetailsOverride), fullyQualifiedName: "azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtAlertDetailsOverride")]
    public interface ISentinelAlertRuleNrtAlertDetailsOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#description_format SentinelAlertRuleNrt#description_format}.</summary>
        [JsiiProperty(name: "descriptionFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DescriptionFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#display_name_format SentinelAlertRuleNrt#display_name_format}.</summary>
        [JsiiProperty(name: "displayNameFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayNameFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamic_property block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#dynamic_property SentinelAlertRuleNrt#dynamic_property}
        /// </remarks>
        [JsiiProperty(name: "dynamicProperty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtAlertDetailsOverrideDynamicProperty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DynamicProperty
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#severity_column_name SentinelAlertRuleNrt#severity_column_name}.</summary>
        [JsiiProperty(name: "severityColumnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SeverityColumnName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#tactics_column_name SentinelAlertRuleNrt#tactics_column_name}.</summary>
        [JsiiProperty(name: "tacticsColumnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TacticsColumnName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISentinelAlertRuleNrtAlertDetailsOverride), fullyQualifiedName: "azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtAlertDetailsOverride")]
        internal sealed class _Proxy : DeputyBase, azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtAlertDetailsOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#description_format SentinelAlertRuleNrt#description_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "descriptionFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DescriptionFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#display_name_format SentinelAlertRuleNrt#display_name_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayNameFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayNameFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dynamic_property block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#dynamic_property SentinelAlertRuleNrt#dynamic_property}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamicProperty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtAlertDetailsOverrideDynamicProperty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DynamicProperty
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#severity_column_name SentinelAlertRuleNrt#severity_column_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "severityColumnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SeverityColumnName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#tactics_column_name SentinelAlertRuleNrt#tactics_column_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tacticsColumnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TacticsColumnName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
