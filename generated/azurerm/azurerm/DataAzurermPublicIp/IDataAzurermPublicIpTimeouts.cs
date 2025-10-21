using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPublicIp
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPublicIpTimeouts), fullyQualifiedName: "azurerm.dataAzurermPublicIp.DataAzurermPublicIpTimeouts")]
    public interface IDataAzurermPublicIpTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip#read DataAzurermPublicIp#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPublicIpTimeouts), fullyQualifiedName: "azurerm.dataAzurermPublicIp.DataAzurermPublicIpTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPublicIp.IDataAzurermPublicIpTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip#read DataAzurermPublicIp#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
