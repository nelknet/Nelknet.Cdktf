using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleNrt
{
    [JsiiByValue(fqn: "azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtAlertDetailsOverride")]
    public class SentinelAlertRuleNrtAlertDetailsOverride : azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtAlertDetailsOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#description_format SentinelAlertRuleNrt#description_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "descriptionFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DescriptionFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#display_name_format SentinelAlertRuleNrt#display_name_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayNameFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayNameFormat
        {
            get;
            set;
        }

        private object? _dynamicProperty;

        /// <summary>dynamic_property block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#dynamic_property SentinelAlertRuleNrt#dynamic_property}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamicProperty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtAlertDetailsOverrideDynamicProperty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DynamicProperty
        {
            get => _dynamicProperty;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtAlertDetailsOverrideDynamicProperty[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtAlertDetailsOverrideDynamicProperty).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dynamicProperty = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#severity_column_name SentinelAlertRuleNrt#severity_column_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "severityColumnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SeverityColumnName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#tactics_column_name SentinelAlertRuleNrt#tactics_column_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tacticsColumnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TacticsColumnName
        {
            get;
            set;
        }
    }
}
