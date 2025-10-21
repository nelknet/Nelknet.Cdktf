using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepository")]
    public class SpringCloudServiceConfigServerGitSettingRepository : azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#name SpringCloudService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#uri SpringCloudService#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public string Uri
        {
            get;
            set;
        }

        /// <summary>http_basic_auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#http_basic_auth SpringCloudService#http_basic_auth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpBasicAuth", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth\"}", isOptional: true)]
        public azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth? HttpBasicAuth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#label SpringCloudService#label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#pattern SpringCloudService#pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pattern", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Pattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#search_paths SpringCloudService#search_paths}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "searchPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SearchPaths
        {
            get;
            set;
        }

        /// <summary>ssh_auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#ssh_auth SpringCloudService#ssh_auth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sshAuth", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositorySshAuth\"}", isOptional: true)]
        public azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositorySshAuth? SshAuth
        {
            get;
            set;
        }
    }
}
