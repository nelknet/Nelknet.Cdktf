using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerLink
{
    [JsiiByValue(fqn: "aws.networkmanagerLink.NetworkmanagerLinkBandwidth")]
    public class NetworkmanagerLinkBandwidth : aws.NetworkmanagerLink.INetworkmanagerLinkBandwidth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#download_speed NetworkmanagerLink#download_speed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "downloadSpeed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DownloadSpeed
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#upload_speed NetworkmanagerLink#upload_speed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uploadSpeed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UploadSpeed
        {
            get;
            set;
        }
    }
}
