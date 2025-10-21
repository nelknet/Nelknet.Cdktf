using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvsPlaybackKeyPair
{
    [JsiiByValue(fqn: "aws.ivsPlaybackKeyPair.IvsPlaybackKeyPairTimeouts")]
    public class IvsPlaybackKeyPairTimeouts : aws.IvsPlaybackKeyPair.IIvsPlaybackKeyPairTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_playback_key_pair#create IvsPlaybackKeyPair#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_playback_key_pair#delete IvsPlaybackKeyPair#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
