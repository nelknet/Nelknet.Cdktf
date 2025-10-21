using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerSite
{
    [JsiiInterface(nativeType: typeof(INetworkmanagerSiteLocation), fullyQualifiedName: "aws.networkmanagerSite.NetworkmanagerSiteLocation")]
    public interface INetworkmanagerSiteLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#address NetworkmanagerSite#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#latitude NetworkmanagerSite#latitude}.</summary>
        [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Latitude
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#longitude NetworkmanagerSite#longitude}.</summary>
        [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Longitude
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkmanagerSiteLocation), fullyQualifiedName: "aws.networkmanagerSite.NetworkmanagerSiteLocation")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkmanagerSite.INetworkmanagerSiteLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#address NetworkmanagerSite#address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#latitude NetworkmanagerSite#latitude}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Latitude
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#longitude NetworkmanagerSite#longitude}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Longitude
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
