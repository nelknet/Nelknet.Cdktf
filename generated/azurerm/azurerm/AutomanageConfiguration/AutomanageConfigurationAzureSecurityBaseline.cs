using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiByValue(fqn: "azurerm.automanageConfiguration.AutomanageConfigurationAzureSecurityBaseline")]
    public class AutomanageConfigurationAzureSecurityBaseline : azurerm.AutomanageConfiguration.IAutomanageConfigurationAzureSecurityBaseline
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#assignment_type AutomanageConfiguration#assignment_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "assignmentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AssignmentType
        {
            get;
            set;
        }
    }
}
