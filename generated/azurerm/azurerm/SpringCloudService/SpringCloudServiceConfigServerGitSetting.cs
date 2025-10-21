using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.springCloudService.SpringCloudServiceConfigServerGitSetting")]
    public class SpringCloudServiceConfigServerGitSetting : azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSetting
    {
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
        [JsiiProperty(name: "httpBasicAuth", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingHttpBasicAuth\"}", isOptional: true)]
        public azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingHttpBasicAuth? HttpBasicAuth
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

        private object? _repository;

        /// <summary>repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#repository SpringCloudService#repository}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repository", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepository\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Repository
        {
            get => _repository;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepository[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepository).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _repository = value;
            }
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
        [JsiiProperty(name: "sshAuth", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingSshAuth\"}", isOptional: true)]
        public azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingSshAuth? SshAuth
        {
            get;
            set;
        }
    }
}
