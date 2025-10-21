using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLinuxFunctionApp
{
    [JsiiInterface(nativeType: typeof(IDataAzurermLinuxFunctionAppTimeouts), fullyQualifiedName: "azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppTimeouts")]
    public interface IDataAzurermLinuxFunctionAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_function_app#read DataAzurermLinuxFunctionApp#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermLinuxFunctionAppTimeouts), fullyQualifiedName: "azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermLinuxFunctionApp.IDataAzurermLinuxFunctionAppTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_function_app#read DataAzurermLinuxFunctionApp#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
