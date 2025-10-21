using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolContainerConfiguration")]
    public class BatchPoolContainerConfiguration : azurerm.BatchPool.IBatchPoolContainerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#container_image_names BatchPool#container_image_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerImageNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ContainerImageNames
        {
            get;
            set;
        }

        private object? _containerRegistries;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#container_registries BatchPool#container_registries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerRegistries", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolContainerConfigurationContainerRegistries\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ContainerRegistries
        {
            get => _containerRegistries;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolContainerConfigurationContainerRegistries[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolContainerConfigurationContainerRegistries).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _containerRegistries = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#type BatchPool#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
