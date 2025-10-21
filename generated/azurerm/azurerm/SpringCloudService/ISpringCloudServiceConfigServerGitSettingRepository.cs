using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    [JsiiInterface(nativeType: typeof(ISpringCloudServiceConfigServerGitSettingRepository), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepository")]
    public interface ISpringCloudServiceConfigServerGitSettingRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#name SpringCloudService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#uri SpringCloudService#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        string Uri
        {
            get;
        }

        /// <summary>http_basic_auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#http_basic_auth SpringCloudService#http_basic_auth}
        /// </remarks>
        [JsiiProperty(name: "httpBasicAuth", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth? HttpBasicAuth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#label SpringCloudService#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#pattern SpringCloudService#pattern}.</summary>
        [JsiiProperty(name: "pattern", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Pattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#search_paths SpringCloudService#search_paths}.</summary>
        [JsiiProperty(name: "searchPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SearchPaths
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssh_auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#ssh_auth SpringCloudService#ssh_auth}
        /// </remarks>
        [JsiiProperty(name: "sshAuth", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositorySshAuth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositorySshAuth? SshAuth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudServiceConfigServerGitSettingRepository), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepository")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepository
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#name SpringCloudService#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#uri SpringCloudService#uri}.</summary>
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
            public string Uri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>http_basic_auth block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#http_basic_auth SpringCloudService#http_basic_auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpBasicAuth", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth\"}", isOptional: true)]
            public azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth? HttpBasicAuth
            {
                get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#label SpringCloudService#label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#pattern SpringCloudService#pattern}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pattern", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Pattern
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#search_paths SpringCloudService#search_paths}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SearchPaths
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>ssh_auth block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#ssh_auth SpringCloudService#ssh_auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sshAuth", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositorySshAuth\"}", isOptional: true)]
            public azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositorySshAuth? SshAuth
            {
                get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositorySshAuth?>();
            }
        }
    }
}
