using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCognitiveAccount
{
    [JsiiByValue(fqn: "azurerm.dataAzurermCognitiveAccount.DataAzurermCognitiveAccountTimeouts")]
    public class DataAzurermCognitiveAccountTimeouts : azurerm.DataAzurermCognitiveAccount.IDataAzurermCognitiveAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cognitive_account#read DataAzurermCognitiveAccount#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
