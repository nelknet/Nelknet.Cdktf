using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciCluster
{
    [JsiiInterface(nativeType: typeof(IStackHciClusterIdentity), fullyQualifiedName: "azurerm.stackHciCluster.StackHciClusterIdentity")]
    public interface IStackHciClusterIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#type StackHciCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStackHciClusterIdentity), fullyQualifiedName: "azurerm.stackHciCluster.StackHciClusterIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.StackHciCluster.IStackHciClusterIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#type StackHciCluster#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
