using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IFirewallPolicyInsights), fullyQualifiedName: "azurerm.firewallPolicy.FirewallPolicyInsights")]
    public interface IFirewallPolicyInsights
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#default_log_analytics_workspace_id FirewallPolicy#default_log_analytics_workspace_id}.</summary>
        [JsiiProperty(name: "defaultLogAnalyticsWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultLogAnalyticsWorkspaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#enabled FirewallPolicy#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>log_analytics_workspace block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#log_analytics_workspace FirewallPolicy#log_analytics_workspace}
        /// </remarks>
        [JsiiProperty(name: "logAnalyticsWorkspace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyInsightsLogAnalyticsWorkspace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogAnalyticsWorkspace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#retention_in_days FirewallPolicy#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionInDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFirewallPolicyInsights), fullyQualifiedName: "azurerm.firewallPolicy.FirewallPolicyInsights")]
        internal sealed class _Proxy : DeputyBase, azurerm.FirewallPolicy.IFirewallPolicyInsights
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#default_log_analytics_workspace_id FirewallPolicy#default_log_analytics_workspace_id}.</summary>
            [JsiiProperty(name: "defaultLogAnalyticsWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultLogAnalyticsWorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#enabled FirewallPolicy#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>log_analytics_workspace block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#log_analytics_workspace FirewallPolicy#log_analytics_workspace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logAnalyticsWorkspace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyInsightsLogAnalyticsWorkspace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogAnalyticsWorkspace
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#retention_in_days FirewallPolicy#retention_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionInDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
