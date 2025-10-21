using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermTemplateSpecVersion
{
    [JsiiByValue(fqn: "azurerm.dataAzurermTemplateSpecVersion.DataAzurermTemplateSpecVersionTimeouts")]
    public class DataAzurermTemplateSpecVersionTimeouts : azurerm.DataAzurermTemplateSpecVersion.IDataAzurermTemplateSpecVersionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/template_spec_version#read DataAzurermTemplateSpecVersion#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
