using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSharedImageVersions
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSharedImageVersionsTimeouts), fullyQualifiedName: "azurerm.dataAzurermSharedImageVersions.DataAzurermSharedImageVersionsTimeouts")]
    public interface IDataAzurermSharedImageVersionsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_versions#read DataAzurermSharedImageVersions#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSharedImageVersionsTimeouts), fullyQualifiedName: "azurerm.dataAzurermSharedImageVersions.DataAzurermSharedImageVersionsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSharedImageVersions.IDataAzurermSharedImageVersionsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_versions#read DataAzurermSharedImageVersions#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
