using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewayBackendHttpSettings")]
    public class ApplicationGatewayBackendHttpSettings : azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#cookie_based_affinity ApplicationGateway#cookie_based_affinity}.</summary>
        [JsiiProperty(name: "cookieBasedAffinity", typeJson: "{\"primitive\":\"string\"}")]
        public string CookieBasedAffinity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#port ApplicationGateway#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#protocol ApplicationGateway#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#affinity_cookie_name ApplicationGateway#affinity_cookie_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "affinityCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AffinityCookieName
        {
            get;
            set;
        }

        private object? _authenticationCertificate;

        /// <summary>authentication_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#authentication_certificate ApplicationGateway#authentication_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackendHttpSettingsAuthenticationCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AuthenticationCertificate
        {
            get => _authenticationCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettingsAuthenticationCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettingsAuthenticationCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authenticationCertificate = value;
            }
        }

        /// <summary>connection_draining block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#connection_draining ApplicationGateway#connection_draining}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionDraining", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackendHttpSettingsConnectionDraining\"}", isOptional: true)]
        public azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettingsConnectionDraining? ConnectionDraining
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#host_name ApplicationGateway#host_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#path ApplicationGateway#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        private object? _pickHostNameFromBackendAddress;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#pick_host_name_from_backend_address ApplicationGateway#pick_host_name_from_backend_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pickHostNameFromBackendAddress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PickHostNameFromBackendAddress
        {
            get => _pickHostNameFromBackendAddress;
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
                _pickHostNameFromBackendAddress = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#probe_name ApplicationGateway#probe_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "probeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProbeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#request_timeout ApplicationGateway#request_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RequestTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#trusted_root_certificate_names ApplicationGateway#trusted_root_certificate_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedRootCertificateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TrustedRootCertificateNames
        {
            get;
            set;
        }
    }
}
