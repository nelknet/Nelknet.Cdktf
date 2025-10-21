using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLinuxWebApp
{
    [JsiiInterface(nativeType: typeof(IDataAzurermLinuxWebAppTimeouts), fullyQualifiedName: "azurerm.dataAzurermLinuxWebApp.DataAzurermLinuxWebAppTimeouts")]
    public interface IDataAzurermLinuxWebAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_web_app#read DataAzurermLinuxWebApp#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermLinuxWebAppTimeouts), fullyQualifiedName: "azurerm.dataAzurermLinuxWebApp.DataAzurermLinuxWebAppTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermLinuxWebApp.IDataAzurermLinuxWebAppTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_web_app#read DataAzurermLinuxWebApp#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
