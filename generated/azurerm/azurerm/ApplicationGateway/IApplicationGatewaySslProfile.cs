using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewaySslProfile), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewaySslProfile")]
    public interface IApplicationGatewaySslProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>ssl_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#ssl_policy ApplicationGateway#ssl_policy}
        /// </remarks>
        [JsiiProperty(name: "sslPolicy", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySslProfileSslPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApplicationGateway.IApplicationGatewaySslProfileSslPolicy? SslPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#trusted_client_certificate_names ApplicationGateway#trusted_client_certificate_names}.</summary>
        [JsiiProperty(name: "trustedClientCertificateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TrustedClientCertificateNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#verify_client_certificate_revocation ApplicationGateway#verify_client_certificate_revocation}.</summary>
        [JsiiProperty(name: "verifyClientCertificateRevocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerifyClientCertificateRevocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#verify_client_cert_issuer_dn ApplicationGateway#verify_client_cert_issuer_dn}.</summary>
        [JsiiProperty(name: "verifyClientCertIssuerDn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VerifyClientCertIssuerDn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewaySslProfile), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewaySslProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewaySslProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ssl_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#ssl_policy ApplicationGateway#ssl_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslPolicy", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySslProfileSslPolicy\"}", isOptional: true)]
            public azurerm.ApplicationGateway.IApplicationGatewaySslProfileSslPolicy? SslPolicy
            {
                get => GetInstanceProperty<azurerm.ApplicationGateway.IApplicationGatewaySslProfileSslPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#trusted_client_certificate_names ApplicationGateway#trusted_client_certificate_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedClientCertificateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TrustedClientCertificateNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#verify_client_certificate_revocation ApplicationGateway#verify_client_certificate_revocation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifyClientCertificateRevocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerifyClientCertificateRevocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#verify_client_cert_issuer_dn ApplicationGateway#verify_client_cert_issuer_dn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifyClientCertIssuerDn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? VerifyClientCertIssuerDn
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
