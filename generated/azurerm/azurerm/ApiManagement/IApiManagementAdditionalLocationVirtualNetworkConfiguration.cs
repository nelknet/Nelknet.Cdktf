using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiInterface(nativeType: typeof(IApiManagementAdditionalLocationVirtualNetworkConfiguration), fullyQualifiedName: "azurerm.apiManagement.ApiManagementAdditionalLocationVirtualNetworkConfiguration")]
    public interface IApiManagementAdditionalLocationVirtualNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#subnet_id ApiManagement#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementAdditionalLocationVirtualNetworkConfiguration), fullyQualifiedName: "azurerm.apiManagement.ApiManagementAdditionalLocationVirtualNetworkConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagement.IApiManagementAdditionalLocationVirtualNetworkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#subnet_id ApiManagement#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
