using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerApp.ContainerAppTemplateHttpScaleRuleAuthentication")]
    public class ContainerAppTemplateHttpScaleRuleAuthentication : azurerm.ContainerApp.IContainerAppTemplateHttpScaleRuleAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#secret_name ContainerApp#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#trigger_parameter ContainerApp#trigger_parameter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "triggerParameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TriggerParameter
        {
            get;
            set;
        }
    }
}
