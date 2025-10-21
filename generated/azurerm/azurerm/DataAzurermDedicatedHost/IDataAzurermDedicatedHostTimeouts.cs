using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDedicatedHost
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDedicatedHostTimeouts), fullyQualifiedName: "azurerm.dataAzurermDedicatedHost.DataAzurermDedicatedHostTimeouts")]
    public interface IDataAzurermDedicatedHostTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dedicated_host#read DataAzurermDedicatedHost#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDedicatedHostTimeouts), fullyQualifiedName: "azurerm.dataAzurermDedicatedHost.DataAzurermDedicatedHostTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDedicatedHost.IDataAzurermDedicatedHostTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dedicated_host#read DataAzurermDedicatedHost#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
