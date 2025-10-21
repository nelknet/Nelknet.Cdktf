using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerApp.ContainerAppRegistry")]
    public class ContainerAppRegistry : azurerm.ContainerApp.IContainerAppRegistry
    {
        /// <summary>The hostname for the Container Registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#server ContainerApp#server}
        /// </remarks>
        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
        public string Server
        {
            get;
            set;
        }

        /// <summary>ID of the System or User Managed Identity used to pull images from the Container Registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#identity ContainerApp#identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Identity
        {
            get;
            set;
        }

        /// <summary>The name of the Secret Reference containing the password value for this user on the Container Registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#password_secret_name ContainerApp#password_secret_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passwordSecretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PasswordSecretName
        {
            get;
            set;
        }

        /// <summary>The username to use for this Container Registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#username ContainerApp#username}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
