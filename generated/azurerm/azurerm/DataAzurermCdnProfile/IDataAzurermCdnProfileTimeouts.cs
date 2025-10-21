using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCdnProfile
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCdnProfileTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnProfile.DataAzurermCdnProfileTimeouts")]
    public interface IDataAzurermCdnProfileTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_profile#read DataAzurermCdnProfile#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCdnProfileTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnProfile.DataAzurermCdnProfileTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCdnProfile.IDataAzurermCdnProfileTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_profile#read DataAzurermCdnProfile#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
