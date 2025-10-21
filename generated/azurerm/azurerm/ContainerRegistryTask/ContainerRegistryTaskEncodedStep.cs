using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerRegistryTask.ContainerRegistryTaskEncodedStep")]
    public class ContainerRegistryTaskEncodedStep : azurerm.ContainerRegistryTask.IContainerRegistryTaskEncodedStep
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#task_content ContainerRegistryTask#task_content}.</summary>
        [JsiiProperty(name: "taskContent", typeJson: "{\"primitive\":\"string\"}")]
        public string TaskContent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#context_access_token ContainerRegistryTask#context_access_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contextAccessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContextAccessToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#context_path ContainerRegistryTask#context_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contextPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContextPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#secret_values ContainerRegistryTask#secret_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? SecretValues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#value_content ContainerRegistryTask#value_content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "valueContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ValueContent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#values ContainerRegistryTask#values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Values
        {
            get;
            set;
        }
    }
}
