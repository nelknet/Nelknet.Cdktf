using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiByValue(fqn: "azurerm.provider.AzurermProviderFeaturesPostgresqlFlexibleServer")]
    public class AzurermProviderFeaturesPostgresqlFlexibleServer : azurerm.Provider.IAzurermProviderFeaturesPostgresqlFlexibleServer
    {
        private object? _restartServerOnConfigurationValueChange;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#restart_server_on_configuration_value_change AzurermProvider#restart_server_on_configuration_value_change}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "restartServerOnConfigurationValueChange", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RestartServerOnConfigurationValueChange
        {
            get => _restartServerOnConfigurationValueChange;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _restartServerOnConfigurationValueChange = value;
            }
        }
    }
}
