using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionAppSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2")]
    public class LinuxFunctionAppSlotAuthSettingsV2 : azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2
    {
        /// <summary>login block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#login LinuxFunctionAppSlot#login}
        /// </remarks>
        [JsiiProperty(name: "login", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2Login\"}")]
        public azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2Login Login
        {
            get;
            set;
        }

        /// <summary>active_directory_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#active_directory_v2 LinuxFunctionAppSlot#active_directory_v2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryV2", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2ActiveDirectoryV2\"}", isOptional: true)]
        public azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2ActiveDirectoryV2? ActiveDirectoryV2
        {
            get;
            set;
        }

        /// <summary>apple_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#apple_v2 LinuxFunctionAppSlot#apple_v2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appleV2", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2AppleV2\"}", isOptional: true)]
        public azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2AppleV2? AppleV2
        {
            get;
            set;
        }

        private object? _authEnabled;

        /// <summary>Should the AuthV2 Settings be enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#auth_enabled LinuxFunctionAppSlot#auth_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AuthEnabled
        {
            get => _authEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authEnabled = value;
            }
        }

        /// <summary>azure_static_web_app_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#azure_static_web_app_v2 LinuxFunctionAppSlot#azure_static_web_app_v2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureStaticWebAppV2", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2\"}", isOptional: true)]
        public azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2? AzureStaticWebAppV2
        {
            get;
            set;
        }

        /// <summary>The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#config_file_path LinuxFunctionAppSlot#config_file_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigFilePath
        {
            get;
            set;
        }

        private object? _customOidcV2;

        /// <summary>custom_oidc_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#custom_oidc_v2 LinuxFunctionAppSlot#custom_oidc_v2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customOidcV2", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2CustomOidcV2\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomOidcV2
        {
            get => _customOidcV2;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2CustomOidcV2[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2CustomOidcV2).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customOidcV2 = value;
            }
        }

        /// <summary>The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`.</summary>
        /// <remarks>
        /// Possible values include: <c>apple</c>, <c>azureactivedirectory</c>, <c>facebook</c>, <c>github</c>, <c>google</c>, <c>twitter</c> and the <c>name</c> of your <c>custom_oidc_v2</c> provider.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#default_provider LinuxFunctionAppSlot#default_provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultProvider
        {
            get;
            set;
        }

        /// <summary>The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#excluded_paths LinuxFunctionAppSlot#excluded_paths}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludedPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedPaths
        {
            get;
            set;
        }

        /// <summary>facebook_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#facebook_v2 LinuxFunctionAppSlot#facebook_v2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "facebookV2", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2FacebookV2\"}", isOptional: true)]
        public azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2FacebookV2? FacebookV2
        {
            get;
            set;
        }

        /// <summary>The convention used to determine the url of the request made.</summary>
        /// <remarks>
        /// Possible values include <c>ForwardProxyConventionNoProxy</c>, <c>ForwardProxyConventionStandard</c>, <c>ForwardProxyConventionCustom</c>. Defaults to <c>ForwardProxyConventionNoProxy</c>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#forward_proxy_convention LinuxFunctionAppSlot#forward_proxy_convention}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forwardProxyConvention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ForwardProxyConvention
        {
            get;
            set;
        }

        /// <summary>The name of the header containing the host of the request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#forward_proxy_custom_host_header_name LinuxFunctionAppSlot#forward_proxy_custom_host_header_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forwardProxyCustomHostHeaderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ForwardProxyCustomHostHeaderName
        {
            get;
            set;
        }

        /// <summary>The name of the header containing the scheme of the request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#forward_proxy_custom_scheme_header_name LinuxFunctionAppSlot#forward_proxy_custom_scheme_header_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forwardProxyCustomSchemeHeaderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ForwardProxyCustomSchemeHeaderName
        {
            get;
            set;
        }

        /// <summary>github_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#github_v2 LinuxFunctionAppSlot#github_v2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "githubV2", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2GithubV2\"}", isOptional: true)]
        public azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2GithubV2? GithubV2
        {
            get;
            set;
        }

        /// <summary>google_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#google_v2 LinuxFunctionAppSlot#google_v2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "googleV2", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2GoogleV2\"}", isOptional: true)]
        public azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2GoogleV2? GoogleV2
        {
            get;
            set;
        }

        /// <summary>The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#http_route_api_prefix LinuxFunctionAppSlot#http_route_api_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRouteApiPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpRouteApiPrefix
        {
            get;
            set;
        }

        /// <summary>microsoft_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#microsoft_v2 LinuxFunctionAppSlot#microsoft_v2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "microsoftV2", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2MicrosoftV2\"}", isOptional: true)]
        public azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2MicrosoftV2? MicrosoftV2
        {
            get;
            set;
        }

        private object? _requireAuthentication;

        /// <summary>Should the authentication flow be used for all requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#require_authentication LinuxFunctionAppSlot#require_authentication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requireAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireAuthentication
        {
            get => _requireAuthentication;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requireAuthentication = value;
            }
        }

        private object? _requireHttps;

        /// <summary>Should HTTPS be required on connections? Defaults to true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#require_https LinuxFunctionAppSlot#require_https}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requireHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireHttps
        {
            get => _requireHttps;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requireHttps = value;
            }
        }

        /// <summary>The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#runtime_version LinuxFunctionAppSlot#runtime_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RuntimeVersion
        {
            get;
            set;
        }

        /// <summary>twitter_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#twitter_v2 LinuxFunctionAppSlot#twitter_v2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "twitterV2", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2TwitterV2\"}", isOptional: true)]
        public azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2TwitterV2? TwitterV2
        {
            get;
            set;
        }

        /// <summary>The action to take for requests made without authentication.</summary>
        /// <remarks>
        /// Possible values include <c>RedirectToLoginPage</c>, <c>AllowAnonymous</c>, <c>Return401</c>, and <c>Return403</c>. Defaults to <c>RedirectToLoginPage</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#unauthenticated_action LinuxFunctionAppSlot#unauthenticated_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unauthenticatedAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UnauthenticatedAction
        {
            get;
            set;
        }
    }
}
