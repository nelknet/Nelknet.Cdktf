using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    [JsiiInterface(nativeType: typeof(IContainerAppTemplateContainerReadinessProbe), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplateContainerReadinessProbe")]
    public interface IContainerAppTemplateContainerReadinessProbe
    {
        /// <summary>The port number on which to connect. Possible values are between `1` and `65535`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#port ContainerApp#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#transport ContainerApp#transport}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#failure_count_threshold ContainerApp#failure_count_threshold}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#header ContainerApp#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerReadinessProbeHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#host ContainerApp#host}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#interval_seconds ContainerApp#interval_seconds}
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

        /// <summary>The URI to use for http type probes. Not valid for `TCP` type probes. Defaults to `/`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#path ContainerApp#path}
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

        /// <summary>The number of consecutive successful responses required to consider this probe as successful.</summary>
        /// <remarks>
        /// Possible values are between <c>1</c> and <c>10</c>. Defaults to <c>3</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#success_count_threshold ContainerApp#success_count_threshold}
        /// </remarks>
        [JsiiProperty(name: "successCountThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SuccessCountThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#timeout ContainerApp#timeout}
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

        [JsiiTypeProxy(nativeType: typeof(IContainerAppTemplateContainerReadinessProbe), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplateContainerReadinessProbe")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerApp.IContainerAppTemplateContainerReadinessProbe
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The port number on which to connect. Possible values are between `1` and `65535`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#port ContainerApp#port}
            /// </remarks>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#transport ContainerApp#transport}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#failure_count_threshold ContainerApp#failure_count_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failureCountThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailureCountThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#header ContainerApp#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerReadinessProbeHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Header
            {
                get => GetInstanceProperty<object?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#interval_seconds ContainerApp#interval_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "intervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IntervalSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The URI to use for http type probes. Not valid for `TCP` type probes. Defaults to `/`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#path ContainerApp#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of consecutive successful responses required to consider this probe as successful.</summary>
            /// <remarks>
            /// Possible values are between <c>1</c> and <c>10</c>. Defaults to <c>3</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#success_count_threshold ContainerApp#success_count_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "successCountThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SuccessCountThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#timeout ContainerApp#timeout}
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
