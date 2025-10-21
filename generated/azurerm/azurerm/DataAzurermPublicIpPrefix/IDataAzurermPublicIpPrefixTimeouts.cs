using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPublicIpPrefix
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPublicIpPrefixTimeouts), fullyQualifiedName: "azurerm.dataAzurermPublicIpPrefix.DataAzurermPublicIpPrefixTimeouts")]
    public interface IDataAzurermPublicIpPrefixTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip_prefix#read DataAzurermPublicIpPrefix#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPublicIpPrefixTimeouts), fullyQualifiedName: "azurerm.dataAzurermPublicIpPrefix.DataAzurermPublicIpPrefixTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPublicIpPrefix.IDataAzurermPublicIpPrefixTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip_prefix#read DataAzurermPublicIpPrefix#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
