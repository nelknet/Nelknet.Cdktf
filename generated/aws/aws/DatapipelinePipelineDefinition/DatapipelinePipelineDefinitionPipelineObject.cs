using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatapipelinePipelineDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datapipelinePipelineDefinition.DatapipelinePipelineDefinitionPipelineObject")]
    public class DatapipelinePipelineDefinitionPipelineObject : aws.DatapipelinePipelineDefinition.IDatapipelinePipelineDefinitionPipelineObject
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#id DatapipelinePipelineDefinition#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#name DatapipelinePipelineDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _field;

        /// <summary>field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#field DatapipelinePipelineDefinition#field}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "field", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datapipelinePipelineDefinition.DatapipelinePipelineDefinitionPipelineObjectField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Field
        {
            get => _field;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DatapipelinePipelineDefinition.IDatapipelinePipelineDefinitionPipelineObjectField[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DatapipelinePipelineDefinition.IDatapipelinePipelineDefinitionPipelineObjectField).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _field = value;
            }
        }
    }
}
