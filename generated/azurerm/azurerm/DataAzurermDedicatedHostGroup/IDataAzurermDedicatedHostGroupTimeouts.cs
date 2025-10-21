using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDedicatedHostGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDedicatedHostGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermDedicatedHostGroup.DataAzurermDedicatedHostGroupTimeouts")]
    public interface IDataAzurermDedicatedHostGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dedicated_host_group#read DataAzurermDedicatedHostGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDedicatedHostGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermDedicatedHostGroup.DataAzurermDedicatedHostGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDedicatedHostGroup.IDataAzurermDedicatedHostGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dedicated_host_group#read DataAzurermDedicatedHostGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
