using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiByValue(fqn: "azurerm.apiManagement.ApiManagementHostnameConfiguration")]
    public class ApiManagementHostnameConfiguration : azurerm.ApiManagement.IApiManagementHostnameConfiguration
    {
        private object? _developerPortal;

        /// <summary>developer_portal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#developer_portal ApiManagement#developer_portal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "developerPortal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationDeveloperPortal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DeveloperPortal
        {
            get => _developerPortal;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApiManagement.IApiManagementHostnameConfigurationDeveloperPortal[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationDeveloperPortal).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _developerPortal = value;
            }
        }

        private object? _management;

        /// <summary>management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#management ApiManagement#management}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "management", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationManagement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Management
        {
            get => _management;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApiManagement.IApiManagementHostnameConfigurationManagement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationManagement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _management = value;
            }
        }

        private object? _portal;

        /// <summary>portal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#portal ApiManagement#portal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationPortal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Portal
        {
            get => _portal;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApiManagement.IApiManagementHostnameConfigurationPortal[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationPortal).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _portal = value;
            }
        }

        private object? _proxy;

        /// <summary>proxy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#proxy ApiManagement#proxy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "proxy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationProxy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Proxy
        {
            get => _proxy;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApiManagement.IApiManagementHostnameConfigurationProxy[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationProxy).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _proxy = value;
            }
        }

        private object? _scm;

        /// <summary>scm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#scm ApiManagement#scm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scm", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationScm\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Scm
        {
            get => _scm;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApiManagement.IApiManagementHostnameConfigurationScm[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementHostnameConfigurationScm).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scm = value;
            }
        }
    }
}
