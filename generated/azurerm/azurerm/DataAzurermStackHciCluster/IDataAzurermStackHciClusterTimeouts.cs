using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStackHciCluster
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStackHciClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermStackHciCluster.DataAzurermStackHciClusterTimeouts")]
    public interface IDataAzurermStackHciClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stack_hci_cluster#read DataAzurermStackHciCluster#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStackHciClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermStackHciCluster.DataAzurermStackHciClusterTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStackHciCluster.IDataAzurermStackHciClusterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stack_hci_cluster#read DataAzurermStackHciCluster#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
