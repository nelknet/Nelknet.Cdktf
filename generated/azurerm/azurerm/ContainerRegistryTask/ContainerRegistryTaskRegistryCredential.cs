using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    [JsiiByValue(fqn: "azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredential")]
    public class ContainerRegistryTaskRegistryCredential : azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredential
    {
        private object? _custom;

        /// <summary>custom block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#custom ContainerRegistryTask#custom}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "custom", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialCustom\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Custom
        {
            get => _custom;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialCustom[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialCustom).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _custom = value;
            }
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#source ContainerRegistryTask#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialSource\"}", isOptional: true)]
        public azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialSource? Source
        {
            get;
            set;
        }
    }
}
