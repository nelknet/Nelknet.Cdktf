using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchConfiguration
{
    [JsiiInterface(nativeType: typeof(ILaunchConfigurationMetadataOptions), fullyQualifiedName: "aws.launchConfiguration.LaunchConfigurationMetadataOptions")]
    public interface ILaunchConfigurationMetadataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#http_endpoint LaunchConfiguration#http_endpoint}.</summary>
        [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#http_put_response_hop_limit LaunchConfiguration#http_put_response_hop_limit}.</summary>
        [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpPutResponseHopLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#http_tokens LaunchConfiguration#http_tokens}.</summary>
        [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpTokens
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchConfigurationMetadataOptions), fullyQualifiedName: "aws.launchConfiguration.LaunchConfigurationMetadataOptions")]
        internal sealed class _Proxy : DeputyBase, aws.LaunchConfiguration.ILaunchConfigurationMetadataOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#http_endpoint LaunchConfiguration#http_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#http_put_response_hop_limit LaunchConfiguration#http_put_response_hop_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpPutResponseHopLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#http_tokens LaunchConfiguration#http_tokens}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpTokens
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
