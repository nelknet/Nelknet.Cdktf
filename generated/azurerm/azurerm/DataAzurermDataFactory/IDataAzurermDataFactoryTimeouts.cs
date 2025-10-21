using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataFactory
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDataFactoryTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataFactory.DataAzurermDataFactoryTimeouts")]
    public interface IDataAzurermDataFactoryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory#read DataAzurermDataFactory#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDataFactoryTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataFactory.DataAzurermDataFactoryTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDataFactory.IDataAzurermDataFactoryTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory#read DataAzurermDataFactory#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
