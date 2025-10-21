using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermResources
{
    [JsiiInterface(nativeType: typeof(IDataAzurermResourcesTimeouts), fullyQualifiedName: "azurerm.dataAzurermResources.DataAzurermResourcesTimeouts")]
    public interface IDataAzurermResourcesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resources#read DataAzurermResources#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermResourcesTimeouts), fullyQualifiedName: "azurerm.dataAzurermResources.DataAzurermResourcesTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermResources.IDataAzurermResourcesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resources#read DataAzurermResources#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
