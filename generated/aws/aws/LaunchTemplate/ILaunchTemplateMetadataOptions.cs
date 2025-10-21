using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateMetadataOptions), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateMetadataOptions")]
    public interface ILaunchTemplateMetadataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#http_endpoint LaunchTemplate#http_endpoint}.</summary>
        [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#http_protocol_ipv6 LaunchTemplate#http_protocol_ipv6}.</summary>
        [JsiiProperty(name: "httpProtocolIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpProtocolIpv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#http_put_response_hop_limit LaunchTemplate#http_put_response_hop_limit}.</summary>
        [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpPutResponseHopLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#http_tokens LaunchTemplate#http_tokens}.</summary>
        [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpTokens
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#instance_metadata_tags LaunchTemplate#instance_metadata_tags}.</summary>
        [JsiiProperty(name: "instanceMetadataTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceMetadataTags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateMetadataOptions), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateMetadataOptions")]
        internal sealed class _Proxy : DeputyBase, aws.LaunchTemplate.ILaunchTemplateMetadataOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#http_endpoint LaunchTemplate#http_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#http_protocol_ipv6 LaunchTemplate#http_protocol_ipv6}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpProtocolIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpProtocolIpv6
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#http_put_response_hop_limit LaunchTemplate#http_put_response_hop_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpPutResponseHopLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#http_tokens LaunchTemplate#http_tokens}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpTokens
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#instance_metadata_tags LaunchTemplate#instance_metadata_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceMetadataTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceMetadataTags
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
