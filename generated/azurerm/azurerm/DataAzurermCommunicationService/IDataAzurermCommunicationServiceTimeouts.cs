using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCommunicationService
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCommunicationServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermCommunicationService.DataAzurermCommunicationServiceTimeouts")]
    public interface IDataAzurermCommunicationServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/communication_service#read DataAzurermCommunicationService#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCommunicationServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermCommunicationService.DataAzurermCommunicationServiceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCommunicationService.IDataAzurermCommunicationServiceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/communication_service#read DataAzurermCommunicationService#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
