using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppConfigurationKeys
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAppConfigurationKeysTimeouts), fullyQualifiedName: "azurerm.dataAzurermAppConfigurationKeys.DataAzurermAppConfigurationKeysTimeouts")]
    public interface IDataAzurermAppConfigurationKeysTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_keys#read DataAzurermAppConfigurationKeys#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAppConfigurationKeysTimeouts), fullyQualifiedName: "azurerm.dataAzurermAppConfigurationKeys.DataAzurermAppConfigurationKeysTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAppConfigurationKeys.IDataAzurermAppConfigurationKeysTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_keys#read DataAzurermAppConfigurationKeys#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
