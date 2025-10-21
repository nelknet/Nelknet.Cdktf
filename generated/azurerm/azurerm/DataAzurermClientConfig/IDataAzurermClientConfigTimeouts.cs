using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermClientConfig
{
    [JsiiInterface(nativeType: typeof(IDataAzurermClientConfigTimeouts), fullyQualifiedName: "azurerm.dataAzurermClientConfig.DataAzurermClientConfigTimeouts")]
    public interface IDataAzurermClientConfigTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/client_config#read DataAzurermClientConfig#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermClientConfigTimeouts), fullyQualifiedName: "azurerm.dataAzurermClientConfig.DataAzurermClientConfigTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermClientConfig.IDataAzurermClientConfigTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/client_config#read DataAzurermClientConfig#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
