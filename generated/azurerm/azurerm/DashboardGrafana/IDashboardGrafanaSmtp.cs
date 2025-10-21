using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DashboardGrafana
{
    [JsiiInterface(nativeType: typeof(IDashboardGrafanaSmtp), fullyQualifiedName: "azurerm.dashboardGrafana.DashboardGrafanaSmtp")]
    public interface IDashboardGrafanaSmtp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#from_address DashboardGrafana#from_address}.</summary>
        [JsiiProperty(name: "fromAddress", typeJson: "{\"primitive\":\"string\"}")]
        string FromAddress
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#host DashboardGrafana#host}.</summary>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        string Host
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#password DashboardGrafana#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#start_tls_policy DashboardGrafana#start_tls_policy}.</summary>
        [JsiiProperty(name: "startTlsPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string StartTlsPolicy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#user DashboardGrafana#user}.</summary>
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
        string User
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#enabled DashboardGrafana#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#from_name DashboardGrafana#from_name}.</summary>
        [JsiiProperty(name: "fromName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FromName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#verification_skip_enabled DashboardGrafana#verification_skip_enabled}.</summary>
        [JsiiProperty(name: "verificationSkipEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VerificationSkipEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDashboardGrafanaSmtp), fullyQualifiedName: "azurerm.dashboardGrafana.DashboardGrafanaSmtp")]
        internal sealed class _Proxy : DeputyBase, azurerm.DashboardGrafana.IDashboardGrafanaSmtp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#from_address DashboardGrafana#from_address}.</summary>
            [JsiiProperty(name: "fromAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string FromAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#host DashboardGrafana#host}.</summary>
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
            public string Host
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#password DashboardGrafana#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#start_tls_policy DashboardGrafana#start_tls_policy}.</summary>
            [JsiiProperty(name: "startTlsPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string StartTlsPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#user DashboardGrafana#user}.</summary>
            [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
            public string User
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#enabled DashboardGrafana#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#from_name DashboardGrafana#from_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fromName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FromName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dashboard_grafana#verification_skip_enabled DashboardGrafana#verification_skip_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verificationSkipEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? VerificationSkipEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
