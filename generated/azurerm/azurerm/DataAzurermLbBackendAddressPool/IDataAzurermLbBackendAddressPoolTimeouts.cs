using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLbBackendAddressPool
{
    [JsiiInterface(nativeType: typeof(IDataAzurermLbBackendAddressPoolTimeouts), fullyQualifiedName: "azurerm.dataAzurermLbBackendAddressPool.DataAzurermLbBackendAddressPoolTimeouts")]
    public interface IDataAzurermLbBackendAddressPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_backend_address_pool#read DataAzurermLbBackendAddressPool#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermLbBackendAddressPoolTimeouts), fullyQualifiedName: "azurerm.dataAzurermLbBackendAddressPool.DataAzurermLbBackendAddressPoolTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermLbBackendAddressPool.IDataAzurermLbBackendAddressPoolTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_backend_address_pool#read DataAzurermLbBackendAddressPool#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
