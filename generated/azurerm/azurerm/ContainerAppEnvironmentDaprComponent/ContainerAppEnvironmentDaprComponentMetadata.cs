using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppEnvironmentDaprComponent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerAppEnvironmentDaprComponent.ContainerAppEnvironmentDaprComponentMetadata")]
    public class ContainerAppEnvironmentDaprComponentMetadata : azurerm.ContainerAppEnvironmentDaprComponent.IContainerAppEnvironmentDaprComponentMetadata
    {
        /// <summary>The name of the Metadata configuration item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#name ContainerAppEnvironmentDaprComponent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The name of a secret specified in the `secrets` block that contains the value for this metadata configuration item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#secret_name ContainerAppEnvironmentDaprComponent#secret_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretName
        {
            get;
            set;
        }

        /// <summary>The value for this metadata configuration item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#value ContainerAppEnvironmentDaprComponent#value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
