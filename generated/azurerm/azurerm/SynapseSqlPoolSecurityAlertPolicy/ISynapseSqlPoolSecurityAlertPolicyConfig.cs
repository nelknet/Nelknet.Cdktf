using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseSqlPoolSecurityAlertPolicy
{
    [JsiiInterface(nativeType: typeof(ISynapseSqlPoolSecurityAlertPolicyConfig), fullyQualifiedName: "azurerm.synapseSqlPoolSecurityAlertPolicy.SynapseSqlPoolSecurityAlertPolicyConfig")]
    public interface ISynapseSqlPoolSecurityAlertPolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#policy_state SynapseSqlPoolSecurityAlertPolicy#policy_state}.</summary>
        [JsiiProperty(name: "policyState", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyState
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#sql_pool_id SynapseSqlPoolSecurityAlertPolicy#sql_pool_id}.</summary>
        [JsiiProperty(name: "sqlPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string SqlPoolId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#disabled_alerts SynapseSqlPoolSecurityAlertPolicy#disabled_alerts}.</summary>
        [JsiiProperty(name: "disabledAlerts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DisabledAlerts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#email_account_admins_enabled SynapseSqlPoolSecurityAlertPolicy#email_account_admins_enabled}.</summary>
        [JsiiProperty(name: "emailAccountAdminsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EmailAccountAdminsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#email_addresses SynapseSqlPoolSecurityAlertPolicy#email_addresses}.</summary>
        [JsiiProperty(name: "emailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EmailAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#id SynapseSqlPoolSecurityAlertPolicy#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#retention_days SynapseSqlPoolSecurityAlertPolicy#retention_days}.</summary>
        [JsiiProperty(name: "retentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#storage_account_access_key SynapseSqlPoolSecurityAlertPolicy#storage_account_access_key}.</summary>
        [JsiiProperty(name: "storageAccountAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountAccessKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#storage_endpoint SynapseSqlPoolSecurityAlertPolicy#storage_endpoint}.</summary>
        [JsiiProperty(name: "storageEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#timeouts SynapseSqlPoolSecurityAlertPolicy#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.synapseSqlPoolSecurityAlertPolicy.SynapseSqlPoolSecurityAlertPolicyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SynapseSqlPoolSecurityAlertPolicy.ISynapseSqlPoolSecurityAlertPolicyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISynapseSqlPoolSecurityAlertPolicyConfig), fullyQualifiedName: "azurerm.synapseSqlPoolSecurityAlertPolicy.SynapseSqlPoolSecurityAlertPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SynapseSqlPoolSecurityAlertPolicy.ISynapseSqlPoolSecurityAlertPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#policy_state SynapseSqlPoolSecurityAlertPolicy#policy_state}.</summary>
            [JsiiProperty(name: "policyState", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyState
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#sql_pool_id SynapseSqlPoolSecurityAlertPolicy#sql_pool_id}.</summary>
            [JsiiProperty(name: "sqlPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string SqlPoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#disabled_alerts SynapseSqlPoolSecurityAlertPolicy#disabled_alerts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disabledAlerts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DisabledAlerts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#email_account_admins_enabled SynapseSqlPoolSecurityAlertPolicy#email_account_admins_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailAccountAdminsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EmailAccountAdminsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#email_addresses SynapseSqlPoolSecurityAlertPolicy#email_addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EmailAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#id SynapseSqlPoolSecurityAlertPolicy#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#retention_days SynapseSqlPoolSecurityAlertPolicy#retention_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#storage_account_access_key SynapseSqlPoolSecurityAlertPolicy#storage_account_access_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountAccessKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#storage_endpoint SynapseSqlPoolSecurityAlertPolicy#storage_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#timeouts SynapseSqlPoolSecurityAlertPolicy#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.synapseSqlPoolSecurityAlertPolicy.SynapseSqlPoolSecurityAlertPolicyTimeouts\"}", isOptional: true)]
            public azurerm.SynapseSqlPoolSecurityAlertPolicy.ISynapseSqlPoolSecurityAlertPolicyTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SynapseSqlPoolSecurityAlertPolicy.ISynapseSqlPoolSecurityAlertPolicyTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
