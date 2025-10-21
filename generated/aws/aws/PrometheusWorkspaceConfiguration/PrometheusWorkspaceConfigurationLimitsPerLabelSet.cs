using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusWorkspaceConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.prometheusWorkspaceConfiguration.PrometheusWorkspaceConfigurationLimitsPerLabelSet")]
    public class PrometheusWorkspaceConfigurationLimitsPerLabelSet : aws.PrometheusWorkspaceConfiguration.IPrometheusWorkspaceConfigurationLimitsPerLabelSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace_configuration#label_set PrometheusWorkspaceConfiguration#label_set}.</summary>
        [JsiiProperty(name: "labelSet", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> LabelSet
        {
            get;
            set;
        }

        private object? _limits;

        /// <summary>limits block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace_configuration#limits PrometheusWorkspaceConfiguration#limits}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limits", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusWorkspaceConfiguration.PrometheusWorkspaceConfigurationLimitsPerLabelSetLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Limits
        {
            get => _limits;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.PrometheusWorkspaceConfiguration.IPrometheusWorkspaceConfigurationLimitsPerLabelSetLimits[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PrometheusWorkspaceConfiguration.IPrometheusWorkspaceConfigurationLimitsPerLabelSetLimits).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _limits = value;
            }
        }
    }
}
