using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermFunctionApp
{
    [JsiiInterface(nativeType: typeof(IDataAzurermFunctionAppTimeouts), fullyQualifiedName: "azurerm.dataAzurermFunctionApp.DataAzurermFunctionAppTimeouts")]
    public interface IDataAzurermFunctionAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app#read DataAzurermFunctionApp#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermFunctionAppTimeouts), fullyQualifiedName: "azurerm.dataAzurermFunctionApp.DataAzurermFunctionAppTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermFunctionApp.IDataAzurermFunctionAppTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app#read DataAzurermFunctionApp#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
