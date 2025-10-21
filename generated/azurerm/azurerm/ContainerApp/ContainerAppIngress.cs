using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerApp.ContainerAppIngress")]
    public class ContainerAppIngress : azurerm.ContainerApp.IContainerAppIngress
    {
        /// <summary>The target port on the container for the Ingress traffic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#target_port ContainerApp#target_port}
        /// </remarks>
        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
        public double TargetPort
        {
            get;
            set;
        }

        private object _trafficWeight;

        /// <summary>traffic_weight block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#traffic_weight ContainerApp#traffic_weight}
        /// </remarks>
        [JsiiProperty(name: "trafficWeight", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppIngressTrafficWeight\"},\"kind\":\"array\"}}]}}")]
        public object TrafficWeight
        {
            get => _trafficWeight;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppIngressTrafficWeight[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppIngressTrafficWeight).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppIngressTrafficWeight).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trafficWeight = value;
            }
        }

        private object? _allowInsecureConnections;

        /// <summary>Should this ingress allow insecure connections?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#allow_insecure_connections ContainerApp#allow_insecure_connections}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowInsecureConnections", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowInsecureConnections
        {
            get => _allowInsecureConnections;
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
                _allowInsecureConnections = value;
            }
        }

        /// <summary>The exposed port on the container for the Ingress traffic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#exposed_port ContainerApp#exposed_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exposedPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExposedPort
        {
            get;
            set;
        }

        private object? _externalEnabled;

        /// <summary>Is this an external Ingress.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#external_enabled ContainerApp#external_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ExternalEnabled
        {
            get => _externalEnabled;
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
                _externalEnabled = value;
            }
        }

        private object? _ipSecurityRestriction;

        /// <summary>ip_security_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#ip_security_restriction ContainerApp#ip_security_restriction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipSecurityRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppIngressIpSecurityRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IpSecurityRestriction
        {
            get => _ipSecurityRestriction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppIngressIpSecurityRestriction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppIngressIpSecurityRestriction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipSecurityRestriction = value;
            }
        }

        /// <summary>The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#transport ContainerApp#transport}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Transport
        {
            get;
            set;
        }
    }
}
