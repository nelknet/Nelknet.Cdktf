using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermWindowsFunctionApp
{
    [JsiiInterface(nativeType: typeof(IDataAzurermWindowsFunctionAppTimeouts), fullyQualifiedName: "azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppTimeouts")]
    public interface IDataAzurermWindowsFunctionAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_function_app#read DataAzurermWindowsFunctionApp#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermWindowsFunctionAppTimeouts), fullyQualifiedName: "azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermWindowsFunctionApp.IDataAzurermWindowsFunctionAppTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_function_app#read DataAzurermWindowsFunctionApp#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
