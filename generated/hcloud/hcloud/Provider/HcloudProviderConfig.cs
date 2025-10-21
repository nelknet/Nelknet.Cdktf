using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.Provider
{
    [JsiiByValue(fqn: "hcloud.provider.HcloudProviderConfig")]
    public class HcloudProviderConfig : hcloud.Provider.IHcloudProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#alias HcloudProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        /// <summary>The Hetzner Cloud API endpoint, can be used to override the default API Endpoint https://api.hetzner.cloud/v1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#endpoint HcloudProvider#endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Endpoint
        {
            get;
            set;
        }

        /// <summary>The type of function to be used during the polling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#poll_function HcloudProvider#poll_function}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pollFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PollFunction
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>The Hetzner Cloud API token, can also be specified with the HCLOUD_TOKEN environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#token HcloudProvider#token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Token
        {
            get;
            set;
        }
    }
}
