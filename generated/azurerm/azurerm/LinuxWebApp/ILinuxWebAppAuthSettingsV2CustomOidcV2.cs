using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppAuthSettingsV2CustomOidcV2), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppAuthSettingsV2CustomOidcV2")]
    public interface ILinuxWebAppAuthSettingsV2CustomOidcV2
    {
        /// <summary>The ID of the Client to use to authenticate with this Custom OIDC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#client_id LinuxWebApp#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>The name of the Custom OIDC Authentication Provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#name LinuxWebApp#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The endpoint that contains all the configuration endpoints for this Custom OIDC provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#openid_configuration_endpoint LinuxWebApp#openid_configuration_endpoint}
        /// </remarks>
        [JsiiProperty(name: "openidConfigurationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string OpenidConfigurationEndpoint
        {
            get;
        }

        /// <summary>The name of the claim that contains the users name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#name_claim_type LinuxWebApp#name_claim_type}
        /// </remarks>
        [JsiiProperty(name: "nameClaimType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NameClaimType
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of the scopes that should be requested while authenticating.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#scopes LinuxWebApp#scopes}
        /// </remarks>
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Scopes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppAuthSettingsV2CustomOidcV2), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppAuthSettingsV2CustomOidcV2")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsV2CustomOidcV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the Client to use to authenticate with this Custom OIDC.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#client_id LinuxWebApp#client_id}
            /// </remarks>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the Custom OIDC Authentication Provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#name LinuxWebApp#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The endpoint that contains all the configuration endpoints for this Custom OIDC provider.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#openid_configuration_endpoint LinuxWebApp#openid_configuration_endpoint}
            /// </remarks>
            [JsiiProperty(name: "openidConfigurationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string OpenidConfigurationEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the claim that contains the users name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#name_claim_type LinuxWebApp#name_claim_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nameClaimType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NameClaimType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The list of the scopes that should be requested while authenticating.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#scopes LinuxWebApp#scopes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Scopes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
