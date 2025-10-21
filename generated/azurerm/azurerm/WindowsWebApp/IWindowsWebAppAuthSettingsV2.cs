using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppAuthSettingsV2), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2")]
    public interface IWindowsWebAppAuthSettingsV2
    {
        /// <summary>login block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#login WindowsWebApp#login}
        /// </remarks>
        [JsiiProperty(name: "login", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2Login\"}")]
        azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2Login Login
        {
            get;
        }

        /// <summary>active_directory_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#active_directory_v2 WindowsWebApp#active_directory_v2}
        /// </remarks>
        [JsiiProperty(name: "activeDirectoryV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2ActiveDirectoryV2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2ActiveDirectoryV2? ActiveDirectoryV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>apple_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#apple_v2 WindowsWebApp#apple_v2}
        /// </remarks>
        [JsiiProperty(name: "appleV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2AppleV2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AppleV2? AppleV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the AuthV2 Settings be enabled. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#auth_enabled WindowsWebApp#auth_enabled}
        /// </remarks>
        [JsiiProperty(name: "authEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuthEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>azure_static_web_app_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#azure_static_web_app_v2 WindowsWebApp#azure_static_web_app_v2}
        /// </remarks>
        [JsiiProperty(name: "azureStaticWebAppV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2AzureStaticWebAppV2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AzureStaticWebAppV2? AzureStaticWebAppV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#config_file_path WindowsWebApp#config_file_path}
        /// </remarks>
        [JsiiProperty(name: "configFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigFilePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_oidc_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#custom_oidc_v2 WindowsWebApp#custom_oidc_v2}
        /// </remarks>
        [JsiiProperty(name: "customOidcV2", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2CustomOidcV2\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomOidcV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`.</summary>
        /// <remarks>
        /// Possible values include: <c>apple</c>, <c>azureactivedirectory</c>, <c>facebook</c>, <c>github</c>, <c>google</c>, <c>twitter</c> and the <c>name</c> of your <c>custom_oidc_v2</c> provider.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#default_provider WindowsWebApp#default_provider}
        /// </remarks>
        [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#excluded_paths WindowsWebApp#excluded_paths}
        /// </remarks>
        [JsiiProperty(name: "excludedPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedPaths
        {
            get
            {
                return null;
            }
        }

        /// <summary>facebook_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#facebook_v2 WindowsWebApp#facebook_v2}
        /// </remarks>
        [JsiiProperty(name: "facebookV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2FacebookV2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2FacebookV2? FacebookV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>The convention used to determine the url of the request made.</summary>
        /// <remarks>
        /// Possible values include <c>ForwardProxyConventionNoProxy</c>, <c>ForwardProxyConventionStandard</c>, <c>ForwardProxyConventionCustom</c>. Defaults to <c>ForwardProxyConventionNoProxy</c>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#forward_proxy_convention WindowsWebApp#forward_proxy_convention}
        /// </remarks>
        [JsiiProperty(name: "forwardProxyConvention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ForwardProxyConvention
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the header containing the host of the request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#forward_proxy_custom_host_header_name WindowsWebApp#forward_proxy_custom_host_header_name}
        /// </remarks>
        [JsiiProperty(name: "forwardProxyCustomHostHeaderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ForwardProxyCustomHostHeaderName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the header containing the scheme of the request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#forward_proxy_custom_scheme_header_name WindowsWebApp#forward_proxy_custom_scheme_header_name}
        /// </remarks>
        [JsiiProperty(name: "forwardProxyCustomSchemeHeaderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ForwardProxyCustomSchemeHeaderName
        {
            get
            {
                return null;
            }
        }

        /// <summary>github_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#github_v2 WindowsWebApp#github_v2}
        /// </remarks>
        [JsiiProperty(name: "githubV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2GithubV2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GithubV2? GithubV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>google_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#google_v2 WindowsWebApp#google_v2}
        /// </remarks>
        [JsiiProperty(name: "googleV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2GoogleV2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GoogleV2? GoogleV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#http_route_api_prefix WindowsWebApp#http_route_api_prefix}
        /// </remarks>
        [JsiiProperty(name: "httpRouteApiPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpRouteApiPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>microsoft_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#microsoft_v2 WindowsWebApp#microsoft_v2}
        /// </remarks>
        [JsiiProperty(name: "microsoftV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2MicrosoftV2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2MicrosoftV2? MicrosoftV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the authentication flow be used for all requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#require_authentication WindowsWebApp#require_authentication}
        /// </remarks>
        [JsiiProperty(name: "requireAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should HTTPS be required on connections? Defaults to true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#require_https WindowsWebApp#require_https}
        /// </remarks>
        [JsiiProperty(name: "requireHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireHttps
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#runtime_version WindowsWebApp#runtime_version}
        /// </remarks>
        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuntimeVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>twitter_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#twitter_v2 WindowsWebApp#twitter_v2}
        /// </remarks>
        [JsiiProperty(name: "twitterV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2TwitterV2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2TwitterV2? TwitterV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>The action to take for requests made without authentication.</summary>
        /// <remarks>
        /// Possible values include <c>RedirectToLoginPage</c>, <c>AllowAnonymous</c>, <c>Return401</c>, and <c>Return403</c>. Defaults to <c>RedirectToLoginPage</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#unauthenticated_action WindowsWebApp#unauthenticated_action}
        /// </remarks>
        [JsiiProperty(name: "unauthenticatedAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UnauthenticatedAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppAuthSettingsV2), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>login block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#login WindowsWebApp#login}
            /// </remarks>
            [JsiiProperty(name: "login", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2Login\"}")]
            public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2Login Login
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2Login>()!;
            }

            /// <summary>active_directory_v2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#active_directory_v2 WindowsWebApp#active_directory_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeDirectoryV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2ActiveDirectoryV2\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2ActiveDirectoryV2? ActiveDirectoryV2
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2ActiveDirectoryV2?>();
            }

            /// <summary>apple_v2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#apple_v2 WindowsWebApp#apple_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appleV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2AppleV2\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AppleV2? AppleV2
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AppleV2?>();
            }

            /// <summary>Should the AuthV2 Settings be enabled. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#auth_enabled WindowsWebApp#auth_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AuthEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>azure_static_web_app_v2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#azure_static_web_app_v2 WindowsWebApp#azure_static_web_app_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureStaticWebAppV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2AzureStaticWebAppV2\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AzureStaticWebAppV2? AzureStaticWebAppV2
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AzureStaticWebAppV2?>();
            }

            /// <summary>The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#config_file_path WindowsWebApp#config_file_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigFilePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>custom_oidc_v2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#custom_oidc_v2 WindowsWebApp#custom_oidc_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customOidcV2", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2CustomOidcV2\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomOidcV2
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`.</summary>
            /// <remarks>
            /// Possible values include: <c>apple</c>, <c>azureactivedirectory</c>, <c>facebook</c>, <c>github</c>, <c>google</c>, <c>twitter</c> and the <c>name</c> of your <c>custom_oidc_v2</c> provider.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#default_provider WindowsWebApp#default_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultProvider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#excluded_paths WindowsWebApp#excluded_paths}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludedPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedPaths
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>facebook_v2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#facebook_v2 WindowsWebApp#facebook_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "facebookV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2FacebookV2\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2FacebookV2? FacebookV2
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2FacebookV2?>();
            }

            /// <summary>The convention used to determine the url of the request made.</summary>
            /// <remarks>
            /// Possible values include <c>ForwardProxyConventionNoProxy</c>, <c>ForwardProxyConventionStandard</c>, <c>ForwardProxyConventionCustom</c>. Defaults to <c>ForwardProxyConventionNoProxy</c>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#forward_proxy_convention WindowsWebApp#forward_proxy_convention}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardProxyConvention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ForwardProxyConvention
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the header containing the host of the request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#forward_proxy_custom_host_header_name WindowsWebApp#forward_proxy_custom_host_header_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardProxyCustomHostHeaderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ForwardProxyCustomHostHeaderName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the header containing the scheme of the request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#forward_proxy_custom_scheme_header_name WindowsWebApp#forward_proxy_custom_scheme_header_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardProxyCustomSchemeHeaderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ForwardProxyCustomSchemeHeaderName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>github_v2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#github_v2 WindowsWebApp#github_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "githubV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2GithubV2\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GithubV2? GithubV2
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GithubV2?>();
            }

            /// <summary>google_v2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#google_v2 WindowsWebApp#google_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "googleV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2GoogleV2\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GoogleV2? GoogleV2
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GoogleV2?>();
            }

            /// <summary>The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#http_route_api_prefix WindowsWebApp#http_route_api_prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRouteApiPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpRouteApiPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>microsoft_v2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#microsoft_v2 WindowsWebApp#microsoft_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "microsoftV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2MicrosoftV2\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2MicrosoftV2? MicrosoftV2
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2MicrosoftV2?>();
            }

            /// <summary>Should the authentication flow be used for all requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#require_authentication WindowsWebApp#require_authentication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireAuthentication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Should HTTPS be required on connections? Defaults to true.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#require_https WindowsWebApp#require_https}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireHttps
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#runtime_version WindowsWebApp#runtime_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuntimeVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>twitter_v2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#twitter_v2 WindowsWebApp#twitter_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "twitterV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2TwitterV2\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2TwitterV2? TwitterV2
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2TwitterV2?>();
            }

            /// <summary>The action to take for requests made without authentication.</summary>
            /// <remarks>
            /// Possible values include <c>RedirectToLoginPage</c>, <c>AllowAnonymous</c>, <c>Return401</c>, and <c>Return403</c>. Defaults to <c>RedirectToLoginPage</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#unauthenticated_action WindowsWebApp#unauthenticated_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unauthenticatedAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnauthenticatedAction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
