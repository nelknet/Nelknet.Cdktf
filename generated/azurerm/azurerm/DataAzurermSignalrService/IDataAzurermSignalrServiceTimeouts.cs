using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSignalrService
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSignalrServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermSignalrService.DataAzurermSignalrServiceTimeouts")]
    public interface IDataAzurermSignalrServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/signalr_service#read DataAzurermSignalrService#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSignalrServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermSignalrService.DataAzurermSignalrServiceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSignalrService.IDataAzurermSignalrServiceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/signalr_service#read DataAzurermSignalrService#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
