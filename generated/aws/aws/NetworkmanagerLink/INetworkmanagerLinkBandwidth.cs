using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerLink
{
    [JsiiInterface(nativeType: typeof(INetworkmanagerLinkBandwidth), fullyQualifiedName: "aws.networkmanagerLink.NetworkmanagerLinkBandwidth")]
    public interface INetworkmanagerLinkBandwidth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#download_speed NetworkmanagerLink#download_speed}.</summary>
        [JsiiProperty(name: "downloadSpeed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DownloadSpeed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#upload_speed NetworkmanagerLink#upload_speed}.</summary>
        [JsiiProperty(name: "uploadSpeed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UploadSpeed
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkmanagerLinkBandwidth), fullyQualifiedName: "aws.networkmanagerLink.NetworkmanagerLinkBandwidth")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkmanagerLink.INetworkmanagerLinkBandwidth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#download_speed NetworkmanagerLink#download_speed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "downloadSpeed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DownloadSpeed
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#upload_speed NetworkmanagerLink#upload_speed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uploadSpeed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UploadSpeed
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
