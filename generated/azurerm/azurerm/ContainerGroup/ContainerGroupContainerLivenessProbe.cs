using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerGroup
{
    [JsiiByValue(fqn: "azurerm.containerGroup.ContainerGroupContainerLivenessProbe")]
    public class ContainerGroupContainerLivenessProbe : azurerm.ContainerGroup.IContainerGroupContainerLivenessProbe
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#exec ContainerGroup#exec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exec", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Exec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#failure_threshold ContainerGroup#failure_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }

        private object? _httpGet;

        /// <summary>http_get block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#http_get ContainerGroup#http_get}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpGet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerLivenessProbeHttpGet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HttpGet
        {
            get => _httpGet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerGroup.IContainerGroupContainerLivenessProbeHttpGet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerGroup.IContainerGroupContainerLivenessProbeHttpGet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _httpGet = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#initial_delay_seconds ContainerGroup#initial_delay_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialDelaySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InitialDelaySeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#period_seconds ContainerGroup#period_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "periodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeriodSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#success_threshold ContainerGroup#success_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "successThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SuccessThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#timeout_seconds ContainerGroup#timeout_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutSeconds
        {
            get;
            set;
        }
    }
}
