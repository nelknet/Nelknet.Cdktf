using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesPostgresqlFlexibleServer), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesPostgresqlFlexibleServer")]
    public interface IAzurermProviderFeaturesPostgresqlFlexibleServer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#restart_server_on_configuration_value_change AzurermProvider#restart_server_on_configuration_value_change}.</summary>
        [JsiiProperty(name: "restartServerOnConfigurationValueChange", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RestartServerOnConfigurationValueChange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesPostgresqlFlexibleServer), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesPostgresqlFlexibleServer")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesPostgresqlFlexibleServer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#restart_server_on_configuration_value_change AzurermProvider#restart_server_on_configuration_value_change}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restartServerOnConfigurationValueChange", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RestartServerOnConfigurationValueChange
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
