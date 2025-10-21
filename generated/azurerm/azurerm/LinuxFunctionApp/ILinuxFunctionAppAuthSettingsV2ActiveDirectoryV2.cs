using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    [JsiiInterface(nativeType: typeof(ILinuxFunctionAppAuthSettingsV2ActiveDirectoryV2), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsV2ActiveDirectoryV2")]
    public interface ILinuxFunctionAppAuthSettingsV2ActiveDirectoryV2
    {
        /// <summary>The ID of the Client to use to authenticate with Azure Active Directory.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#client_id LinuxFunctionApp#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>The Azure Tenant Endpoint for the Authenticating Tenant. e.g. `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#tenant_auth_endpoint LinuxFunctionApp#tenant_auth_endpoint}
        /// </remarks>
        [JsiiProperty(name: "tenantAuthEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string TenantAuthEndpoint
        {
            get;
        }

        /// <summary>The list of allowed Applications for the Default Authorisation Policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#allowed_applications LinuxFunctionApp#allowed_applications}
        /// </remarks>
        [JsiiProperty(name: "allowedApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedApplications
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#allowed_audiences LinuxFunctionApp#allowed_audiences}
        /// </remarks>
        [JsiiProperty(name: "allowedAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedAudiences
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of allowed Group Names for the Default Authorisation Policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#allowed_groups LinuxFunctionApp#allowed_groups}
        /// </remarks>
        [JsiiProperty(name: "allowedGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of allowed Identities for the Default Authorisation Policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#allowed_identities LinuxFunctionApp#allowed_identities}
        /// </remarks>
        [JsiiProperty(name: "allowedIdentities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedIdentities
        {
            get
            {
                return null;
            }
        }

        /// <summary>The thumbprint of the certificate used for signing purposes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#client_secret_certificate_thumbprint LinuxFunctionApp#client_secret_certificate_thumbprint}
        /// </remarks>
        [JsiiProperty(name: "clientSecretCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientSecretCertificateThumbprint
        {
            get
            {
                return null;
            }
        }

        /// <summary>The App Setting name that contains the client secret of the Client.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#client_secret_setting_name LinuxFunctionApp#client_secret_setting_name}
        /// </remarks>
        [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientSecretSettingName
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of Allowed Client Applications in the JWT Claim.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#jwt_allowed_client_applications LinuxFunctionApp#jwt_allowed_client_applications}
        /// </remarks>
        [JsiiProperty(name: "jwtAllowedClientApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? JwtAllowedClientApplications
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of Allowed Groups in the JWT Claim.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#jwt_allowed_groups LinuxFunctionApp#jwt_allowed_groups}
        /// </remarks>
        [JsiiProperty(name: "jwtAllowedGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? JwtAllowedGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#login_parameters LinuxFunctionApp#login_parameters}
        /// </remarks>
        [JsiiProperty(name: "loginParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? LoginParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the www-authenticate provider should be omitted from the request? Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#www_authentication_disabled LinuxFunctionApp#www_authentication_disabled}
        /// </remarks>
        [JsiiProperty(name: "wwwAuthenticationDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WwwAuthenticationDisabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxFunctionAppAuthSettingsV2ActiveDirectoryV2), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsV2ActiveDirectoryV2")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsV2ActiveDirectoryV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the Client to use to authenticate with Azure Active Directory.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#client_id LinuxFunctionApp#client_id}
            /// </remarks>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Azure Tenant Endpoint for the Authenticating Tenant. e.g. `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#tenant_auth_endpoint LinuxFunctionApp#tenant_auth_endpoint}
            /// </remarks>
            [JsiiProperty(name: "tenantAuthEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string TenantAuthEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The list of allowed Applications for the Default Authorisation Policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#allowed_applications LinuxFunctionApp#allowed_applications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedApplications
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#allowed_audiences LinuxFunctionApp#allowed_audiences}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedAudiences
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The list of allowed Group Names for the Default Authorisation Policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#allowed_groups LinuxFunctionApp#allowed_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The list of allowed Identities for the Default Authorisation Policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#allowed_identities LinuxFunctionApp#allowed_identities}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedIdentities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedIdentities
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The thumbprint of the certificate used for signing purposes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#client_secret_certificate_thumbprint LinuxFunctionApp#client_secret_certificate_thumbprint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecretCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecretCertificateThumbprint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The App Setting name that contains the client secret of the Client.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#client_secret_setting_name LinuxFunctionApp#client_secret_setting_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecretSettingName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of Allowed Client Applications in the JWT Claim.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#jwt_allowed_client_applications LinuxFunctionApp#jwt_allowed_client_applications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jwtAllowedClientApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? JwtAllowedClientApplications
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A list of Allowed Groups in the JWT Claim.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#jwt_allowed_groups LinuxFunctionApp#jwt_allowed_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jwtAllowedGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? JwtAllowedGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#login_parameters LinuxFunctionApp#login_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loginParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? LoginParameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Should the www-authenticate provider should be omitted from the request? Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#www_authentication_disabled LinuxFunctionApp#www_authentication_disabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wwwAuthenticationDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? WwwAuthenticationDisabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
