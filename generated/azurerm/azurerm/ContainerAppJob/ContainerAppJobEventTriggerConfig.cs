using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiByValue(fqn: "azurerm.containerAppJob.ContainerAppJobEventTriggerConfig")]
    public class ContainerAppJobEventTriggerConfig : azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#parallelism ContainerAppJob#parallelism}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Parallelism
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#replica_completion_count ContainerAppJob#replica_completion_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicaCompletionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReplicaCompletionCount
        {
            get;
            set;
        }

        private object? _scale;

        /// <summary>scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#scale ContainerAppJob#scale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scale", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScale\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Scale
        {
            get => _scale;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScale[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScale).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scale = value;
            }
        }
    }
}
