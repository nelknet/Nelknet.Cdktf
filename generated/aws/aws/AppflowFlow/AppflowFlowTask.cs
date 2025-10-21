using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowTask")]
    public class AppflowFlowTask : aws.AppflowFlow.IAppflowFlowTask
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#task_type AppflowFlow#task_type}.</summary>
        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        public string TaskType
        {
            get;
            set;
        }

        private object? _connectorOperator;

        /// <summary>connector_operator block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#connector_operator AppflowFlow#connector_operator}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectorOperator", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appflowFlow.AppflowFlowTaskConnectorOperator\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ConnectorOperator
        {
            get => _connectorOperator;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppflowFlow.IAppflowFlowTaskConnectorOperator[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppflowFlow.IAppflowFlowTaskConnectorOperator).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connectorOperator = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#destination_field AppflowFlow#destination_field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationField
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#source_fields AppflowFlow#source_fields}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SourceFields
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#task_properties AppflowFlow#task_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TaskProperties
        {
            get;
            set;
        }
    }
}
