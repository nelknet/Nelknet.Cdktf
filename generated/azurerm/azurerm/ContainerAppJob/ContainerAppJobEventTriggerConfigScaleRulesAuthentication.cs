using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScaleRulesAuthentication")]
    public class ContainerAppJobEventTriggerConfigScaleRulesAuthentication : azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScaleRulesAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#secret_name ContainerAppJob#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#trigger_parameter ContainerAppJob#trigger_parameter}.</summary>
        [JsiiProperty(name: "triggerParameter", typeJson: "{\"primitive\":\"string\"}")]
        public string TriggerParameter
        {
            get;
            set;
        }
    }
}
