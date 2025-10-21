using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermImages
{
    [JsiiInterface(nativeType: typeof(IDataAzurermImagesTimeouts), fullyQualifiedName: "azurerm.dataAzurermImages.DataAzurermImagesTimeouts")]
    public interface IDataAzurermImagesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/images#read DataAzurermImages#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermImagesTimeouts), fullyQualifiedName: "azurerm.dataAzurermImages.DataAzurermImagesTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermImages.IDataAzurermImagesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/images#read DataAzurermImages#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
