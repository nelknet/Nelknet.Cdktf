using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerRegistryTask.ContainerRegistryTaskFileStep")]
    public class ContainerRegistryTaskFileStep : azurerm.ContainerRegistryTask.IContainerRegistryTaskFileStep
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#task_file_path ContainerRegistryTask#task_file_path}.</summary>
        [JsiiProperty(name: "taskFilePath", typeJson: "{\"primitive\":\"string\"}")]
        public string TaskFilePath
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#value_file_path ContainerRegistryTask#value_file_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "valueFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ValueFilePath
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
