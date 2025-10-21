using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotInstanceRequest
{
    [JsiiByValue(fqn: "aws.spotInstanceRequest.SpotInstanceRequestMetadataOptions")]
    public class SpotInstanceRequestMetadataOptions : aws.SpotInstanceRequest.ISpotInstanceRequestMetadataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#http_endpoint SpotInstanceRequest#http_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#http_protocol_ipv6 SpotInstanceRequest#http_protocol_ipv6}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpProtocolIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpProtocolIpv6
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#http_put_response_hop_limit SpotInstanceRequest#http_put_response_hop_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpPutResponseHopLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#http_tokens SpotInstanceRequest#http_tokens}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpTokens
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#instance_metadata_tags SpotInstanceRequest#instance_metadata_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceMetadataTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceMetadataTags
        {
            get;
            set;
        }
    }
}
