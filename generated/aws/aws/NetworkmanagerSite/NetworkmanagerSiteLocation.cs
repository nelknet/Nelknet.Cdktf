using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerSite
{
    [JsiiByValue(fqn: "aws.networkmanagerSite.NetworkmanagerSiteLocation")]
    public class NetworkmanagerSiteLocation : aws.NetworkmanagerSite.INetworkmanagerSiteLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#address NetworkmanagerSite#address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#latitude NetworkmanagerSite#latitude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Latitude
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#longitude NetworkmanagerSite#longitude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Longitude
        {
            get;
            set;
        }
    }
}
