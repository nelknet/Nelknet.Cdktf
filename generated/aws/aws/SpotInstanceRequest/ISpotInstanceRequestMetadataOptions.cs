using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotInstanceRequest
{
    [JsiiInterface(nativeType: typeof(ISpotInstanceRequestMetadataOptions), fullyQualifiedName: "aws.spotInstanceRequest.SpotInstanceRequestMetadataOptions")]
    public interface ISpotInstanceRequestMetadataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#http_endpoint SpotInstanceRequest#http_endpoint}.</summary>
        [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#http_protocol_ipv6 SpotInstanceRequest#http_protocol_ipv6}.</summary>
        [JsiiProperty(name: "httpProtocolIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpProtocolIpv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#http_put_response_hop_limit SpotInstanceRequest#http_put_response_hop_limit}.</summary>
        [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpPutResponseHopLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#http_tokens SpotInstanceRequest#http_tokens}.</summary>
        [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpTokens
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#instance_metadata_tags SpotInstanceRequest#instance_metadata_tags}.</summary>
        [JsiiProperty(name: "instanceMetadataTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceMetadataTags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotInstanceRequestMetadataOptions), fullyQualifiedName: "aws.spotInstanceRequest.SpotInstanceRequestMetadataOptions")]
        internal sealed class _Proxy : DeputyBase, aws.SpotInstanceRequest.ISpotInstanceRequestMetadataOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#http_endpoint SpotInstanceRequest#http_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#http_protocol_ipv6 SpotInstanceRequest#http_protocol_ipv6}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpProtocolIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpProtocolIpv6
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#http_put_response_hop_limit SpotInstanceRequest#http_put_response_hop_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpPutResponseHopLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#http_tokens SpotInstanceRequest#http_tokens}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpTokens
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#instance_metadata_tags SpotInstanceRequest#instance_metadata_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceMetadataTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceMetadataTags
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
