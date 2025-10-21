using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig
{
    [JsiiInterface(nativeType: typeof(IDataAzurermServicebusNamespaceDisasterRecoveryConfigTimeouts), fullyQualifiedName: "azurerm.dataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfigTimeouts")]
    public interface IDataAzurermServicebusNamespaceDisasterRecoveryConfigTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_disaster_recovery_config#read DataAzurermServicebusNamespaceDisasterRecoveryConfig#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermServicebusNamespaceDisasterRecoveryConfigTimeouts), fullyQualifiedName: "azurerm.dataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfigTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.IDataAzurermServicebusNamespaceDisasterRecoveryConfigTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_disaster_recovery_config#read DataAzurermServicebusNamespaceDisasterRecoveryConfig#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
