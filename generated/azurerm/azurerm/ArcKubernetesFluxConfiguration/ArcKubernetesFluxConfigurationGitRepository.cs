using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcKubernetesFluxConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.arcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationGitRepository")]
    public class ArcKubernetesFluxConfigurationGitRepository : azurerm.ArcKubernetesFluxConfiguration.IArcKubernetesFluxConfigurationGitRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#reference_type ArcKubernetesFluxConfiguration#reference_type}.</summary>
        [JsiiProperty(name: "referenceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ReferenceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#reference_value ArcKubernetesFluxConfiguration#reference_value}.</summary>
        [JsiiProperty(name: "referenceValue", typeJson: "{\"primitive\":\"string\"}")]
        public string ReferenceValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#url ArcKubernetesFluxConfiguration#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#https_ca_cert_base64 ArcKubernetesFluxConfiguration#https_ca_cert_base64}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpsCaCertBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpsCaCertBase64
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#https_key_base64 ArcKubernetesFluxConfiguration#https_key_base64}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpsKeyBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpsKeyBase64
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#https_user ArcKubernetesFluxConfiguration#https_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpsUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpsUser
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#local_auth_reference ArcKubernetesFluxConfiguration#local_auth_reference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localAuthReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalAuthReference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#ssh_known_hosts_base64 ArcKubernetesFluxConfiguration#ssh_known_hosts_base64}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sshKnownHostsBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SshKnownHostsBase64
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#ssh_private_key_base64 ArcKubernetesFluxConfiguration#ssh_private_key_base64}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sshPrivateKeyBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SshPrivateKeyBase64
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#sync_interval_in_seconds ArcKubernetesFluxConfiguration#sync_interval_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "syncIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SyncIntervalInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#timeout_in_seconds ArcKubernetesFluxConfiguration#timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutInSeconds
        {
            get;
            set;
        }
    }
}
