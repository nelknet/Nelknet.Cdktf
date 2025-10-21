using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerApp
{
    [JsiiInterface(nativeType: typeof(IDataAzurermContainerAppTimeouts), fullyQualifiedName: "azurerm.dataAzurermContainerApp.DataAzurermContainerAppTimeouts")]
    public interface IDataAzurermContainerAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app#read DataAzurermContainerApp#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermContainerAppTimeouts), fullyQualifiedName: "azurerm.dataAzurermContainerApp.DataAzurermContainerAppTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermContainerApp.IDataAzurermContainerAppTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app#read DataAzurermContainerApp#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
