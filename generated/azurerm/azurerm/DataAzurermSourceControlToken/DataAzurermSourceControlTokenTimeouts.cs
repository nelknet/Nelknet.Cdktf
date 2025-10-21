using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSourceControlToken
{
    [JsiiByValue(fqn: "azurerm.dataAzurermSourceControlToken.DataAzurermSourceControlTokenTimeouts")]
    public class DataAzurermSourceControlTokenTimeouts : azurerm.DataAzurermSourceControlToken.IDataAzurermSourceControlTokenTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/source_control_token#read DataAzurermSourceControlToken#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
