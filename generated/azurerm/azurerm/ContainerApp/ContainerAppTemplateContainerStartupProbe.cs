using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerApp.ContainerAppTemplateContainerStartupProbe")]
    public class ContainerAppTemplateContainerStartupProbe : azurerm.ContainerApp.IContainerAppTemplateContainerStartupProbe
    {
        /// <summary>The port number on which to connect. Possible values are between `1` and `65535`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#port ContainerApp#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#transport ContainerApp#transport}
        /// </remarks>
        [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}")]
        public string Transport
        {
            get;
            set;
        }

        /// <summary>The number of consecutive failures required to consider this probe as failed.</summary>
        /// <remarks>
        /// Possible values are between <c>1</c> and <c>10</c>. Defaults to <c>3</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#failure_count_threshold ContainerApp#failure_count_threshold}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failureCountThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureCountThreshold
        {
            get;
            set;
        }

        private object? _header;

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#header ContainerApp#header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerStartupProbeHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Header
        {
            get => _header;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppTemplateContainerStartupProbeHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppTemplateContainerStartupProbeHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _header = value;
            }
        }

        /// <summary>The probe hostname.</summary>
        /// <remarks>
        /// Defaults to the pod IP address. Setting a value for <c>Host</c> in <c>headers</c> can be used to override this for <c>http</c> and <c>https</c> type probes.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#host ContainerApp#host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Host
        {
            get;
            set;
        }

        /// <summary>How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#interval_seconds ContainerApp#interval_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalSeconds
        {
            get;
            set;
        }

        /// <summary>The URI to use with the `host` for http type probes.</summary>
        /// <remarks>
        /// Not valid for <c>TCP</c> type probes. Defaults to <c>/</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#path ContainerApp#path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#timeout ContainerApp#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timeout
        {
            get;
            set;
        }
    }
}
