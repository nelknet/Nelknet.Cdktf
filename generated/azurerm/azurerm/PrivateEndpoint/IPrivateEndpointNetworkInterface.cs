using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PrivateEndpoint
{
    [JsiiInterface(nativeType: typeof(IPrivateEndpointNetworkInterface), fullyQualifiedName: "azurerm.privateEndpoint.PrivateEndpointNetworkInterface")]
    public interface IPrivateEndpointNetworkInterface
    {

        [JsiiTypeProxy(nativeType: typeof(IPrivateEndpointNetworkInterface), fullyQualifiedName: "azurerm.privateEndpoint.PrivateEndpointNetworkInterface")]
        internal sealed class _Proxy : DeputyBase, azurerm.PrivateEndpoint.IPrivateEndpointNetworkInterface
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
