using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiByValue(fqn: "azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScale")]
    public class ContainerAppJobEventTriggerConfigScale : azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#max_executions ContainerAppJob#max_executions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxExecutions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxExecutions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#min_executions ContainerAppJob#min_executions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minExecutions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinExecutions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#polling_interval_in_seconds ContainerAppJob#polling_interval_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pollingIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PollingIntervalInSeconds
        {
            get;
            set;
        }

        private object? _rules;

        /// <summary>rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#rules ContainerAppJob#rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScaleRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Rules
        {
            get => _rules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScaleRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfigScaleRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rules = value;
            }
        }
    }
}
