using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppService
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAppServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermAppService.DataAzurermAppServiceTimeouts")]
    public interface IDataAzurermAppServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service#read DataAzurermAppService#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAppServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermAppService.DataAzurermAppServiceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAppService.IDataAzurermAppServiceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service#read DataAzurermAppService#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
