using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.Provider
{
    [JsiiInterface(nativeType: typeof(IHcloudProviderConfig), fullyQualifiedName: "hcloud.provider.HcloudProviderConfig")]
    public interface IHcloudProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#alias HcloudProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Hetzner Cloud API endpoint, can be used to override the default API Endpoint https://api.hetzner.cloud/v1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#endpoint HcloudProvider#endpoint}
        /// </remarks>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Endpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of function to be used during the polling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#poll_function HcloudProvider#poll_function}
        /// </remarks>
        [JsiiProperty(name: "pollFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PollFunction
        {
            get
            {
                return null;
            }
        }

        /// <summary>The interval at which actions are polled by the client.</summary>
        /// <remarks>
        /// Default <c>500ms</c>. Increase this interval if you run into rate limiting errors.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#poll_interval HcloudProvider#poll_interval}
        /// </remarks>
        [JsiiProperty(name: "pollInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PollInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Hetzner Cloud API token, can also be specified with the HCLOUD_TOKEN environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#token HcloudProvider#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Token
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHcloudProviderConfig), fullyQualifiedName: "hcloud.provider.HcloudProviderConfig")]
        internal sealed class _Proxy : DeputyBase, hcloud.Provider.IHcloudProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#alias HcloudProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Hetzner Cloud API endpoint, can be used to override the default API Endpoint https://api.hetzner.cloud/v1.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#endpoint HcloudProvider#endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Endpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The type of function to be used during the polling.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#poll_function HcloudProvider#poll_function}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pollFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PollFunction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The interval at which actions are polled by the client.</summary>
            /// <remarks>
            /// Default <c>500ms</c>. Increase this interval if you run into rate limiting errors.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#poll_interval HcloudProvider#poll_interval}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pollInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PollInterval
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Hetzner Cloud API token, can also be specified with the HCLOUD_TOKEN environment variable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#token HcloudProvider#token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Token
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
