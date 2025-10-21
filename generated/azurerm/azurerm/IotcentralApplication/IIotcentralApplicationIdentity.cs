using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.IotcentralApplication
{
    [JsiiInterface(nativeType: typeof(IIotcentralApplicationIdentity), fullyQualifiedName: "azurerm.iotcentralApplication.IotcentralApplicationIdentity")]
    public interface IIotcentralApplicationIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#type IotcentralApplication#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotcentralApplicationIdentity), fullyQualifiedName: "azurerm.iotcentralApplication.IotcentralApplicationIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.IotcentralApplication.IIotcentralApplicationIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#type IotcentralApplication#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
