using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStaticWebApp
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStaticWebAppTimeouts), fullyQualifiedName: "azurerm.dataAzurermStaticWebApp.DataAzurermStaticWebAppTimeouts")]
    public interface IDataAzurermStaticWebAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/static_web_app#read DataAzurermStaticWebApp#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStaticWebAppTimeouts), fullyQualifiedName: "azurerm.dataAzurermStaticWebApp.DataAzurermStaticWebAppTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStaticWebApp.IDataAzurermStaticWebAppTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/static_web_app#read DataAzurermStaticWebApp#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
