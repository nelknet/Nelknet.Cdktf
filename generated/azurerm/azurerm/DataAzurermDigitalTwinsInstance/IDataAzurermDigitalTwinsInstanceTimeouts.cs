using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDigitalTwinsInstance
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDigitalTwinsInstanceTimeouts), fullyQualifiedName: "azurerm.dataAzurermDigitalTwinsInstance.DataAzurermDigitalTwinsInstanceTimeouts")]
    public interface IDataAzurermDigitalTwinsInstanceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/digital_twins_instance#read DataAzurermDigitalTwinsInstance#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDigitalTwinsInstanceTimeouts), fullyQualifiedName: "azurerm.dataAzurermDigitalTwinsInstance.DataAzurermDigitalTwinsInstanceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDigitalTwinsInstance.IDataAzurermDigitalTwinsInstanceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/digital_twins_instance#read DataAzurermDigitalTwinsInstance#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
