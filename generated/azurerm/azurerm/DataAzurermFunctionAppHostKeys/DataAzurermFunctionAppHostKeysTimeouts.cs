using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermFunctionAppHostKeys
{
    [JsiiByValue(fqn: "azurerm.dataAzurermFunctionAppHostKeys.DataAzurermFunctionAppHostKeysTimeouts")]
    public class DataAzurermFunctionAppHostKeysTimeouts : azurerm.DataAzurermFunctionAppHostKeys.IDataAzurermFunctionAppHostKeysTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app_host_keys#read DataAzurermFunctionAppHostKeys#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
