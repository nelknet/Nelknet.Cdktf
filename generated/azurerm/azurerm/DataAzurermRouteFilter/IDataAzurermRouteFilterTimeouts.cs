using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRouteFilter
{
    [JsiiInterface(nativeType: typeof(IDataAzurermRouteFilterTimeouts), fullyQualifiedName: "azurerm.dataAzurermRouteFilter.DataAzurermRouteFilterTimeouts")]
    public interface IDataAzurermRouteFilterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_filter#read DataAzurermRouteFilter#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermRouteFilterTimeouts), fullyQualifiedName: "azurerm.dataAzurermRouteFilter.DataAzurermRouteFilterTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermRouteFilter.IDataAzurermRouteFilterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_filter#read DataAzurermRouteFilter#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
