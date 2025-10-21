using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMobileNetworkSite
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMobileNetworkSiteTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkSite.DataAzurermMobileNetworkSiteTimeouts")]
    public interface IDataAzurermMobileNetworkSiteTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_site#read DataAzurermMobileNetworkSite#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMobileNetworkSiteTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkSite.DataAzurermMobileNetworkSiteTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMobileNetworkSite.IDataAzurermMobileNetworkSiteTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_site#read DataAzurermMobileNetworkSite#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
