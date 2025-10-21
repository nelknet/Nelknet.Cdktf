using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiInterface(nativeType: typeof(IContainerAppJobTemplateContainerStartupProbe), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobTemplateContainerStartupProbe")]
    public interface IContainerAppJobTemplateContainerStartupProbe
    {
        /// <summary>The port number on which to connect. Possible values are between `1` and `65535`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#port ContainerAppJob#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#transport ContainerAppJob#transport}
        /// </remarks>
        [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}")]
        string Transport
        {
            get;
        }

        /// <summary>The number of consecutive failures required to consider this probe as failed.</summary>
        /// <remarks>
        /// Possible values are between <c>1</c> and <c>10</c>. Defaults to <c>3</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#failure_count_threshold ContainerAppJob#failure_count_threshold}
        /// </remarks>
        [JsiiProperty(name: "failureCountThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailureCountThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#header ContainerAppJob#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplateContainerStartupProbeHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>The probe hostname.</summary>
        /// <remarks>
        /// Defaults to the pod IP address. Setting a value for <c>Host</c> in <c>headers</c> can be used to override this for <c>http</c> and <c>https</c> type probes.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#host ContainerAppJob#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#interval_seconds ContainerAppJob#interval_seconds}
        /// </remarks>
        [JsiiProperty(name: "intervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IntervalSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URI to use with the `host` for http type probes.</summary>
        /// <remarks>
        /// Not valid for <c>TCP</c> type probes. Defaults to <c>/</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#path ContainerAppJob#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#timeout ContainerAppJob#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppJobTemplateContainerStartupProbe), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobTemplateContainerStartupProbe")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerAppJob.IContainerAppJobTemplateContainerStartupProbe
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The port number on which to connect. Possible values are between `1` and `65535`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#port ContainerAppJob#port}
            /// </remarks>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#transport ContainerAppJob#transport}
            /// </remarks>
            [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}")]
            public string Transport
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The number of consecutive failures required to consider this probe as failed.</summary>
            /// <remarks>
            /// Possible values are between <c>1</c> and <c>10</c>. Defaults to <c>3</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#failure_count_threshold ContainerAppJob#failure_count_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failureCountThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailureCountThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#header ContainerAppJob#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplateContainerStartupProbeHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Header
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The probe hostname.</summary>
            /// <remarks>
            /// Defaults to the pod IP address. Setting a value for <c>Host</c> in <c>headers</c> can be used to override this for <c>http</c> and <c>https</c> type probes.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#host ContainerAppJob#host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Host
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#interval_seconds ContainerAppJob#interval_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "intervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IntervalSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The URI to use with the `host` for http type probes.</summary>
            /// <remarks>
            /// Not valid for <c>TCP</c> type probes. Defaults to <c>/</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#path ContainerAppJob#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#timeout ContainerAppJob#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
