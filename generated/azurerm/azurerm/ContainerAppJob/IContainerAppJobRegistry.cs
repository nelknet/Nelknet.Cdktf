using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiInterface(nativeType: typeof(IContainerAppJobRegistry), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobRegistry")]
    public interface IContainerAppJobRegistry
    {
        /// <summary>The hostname for the Container Registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#server ContainerAppJob#server}
        /// </remarks>
        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
        string Server
        {
            get;
        }

        /// <summary>ID of the System or User Managed Identity used to pull images from the Container Registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#identity ContainerAppJob#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the Secret Reference containing the password value for this user on the Container Registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#password_secret_name ContainerAppJob#password_secret_name}
        /// </remarks>
        [JsiiProperty(name: "passwordSecretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordSecretName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The username to use for this Container Registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#username ContainerAppJob#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppJobRegistry), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobRegistry")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerAppJob.IContainerAppJobRegistry
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The hostname for the Container Registry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#server ContainerAppJob#server}
            /// </remarks>
            [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
            public string Server
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the System or User Managed Identity used to pull images from the Container Registry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#identity ContainerAppJob#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Identity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the Secret Reference containing the password value for this user on the Container Registry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#password_secret_name ContainerAppJob#password_secret_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordSecretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordSecretName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The username to use for this Container Registry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#username ContainerAppJob#username}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
