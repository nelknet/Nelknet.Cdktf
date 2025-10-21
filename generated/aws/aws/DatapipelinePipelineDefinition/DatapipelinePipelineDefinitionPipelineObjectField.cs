using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatapipelinePipelineDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datapipelinePipelineDefinition.DatapipelinePipelineDefinitionPipelineObjectField")]
    public class DatapipelinePipelineDefinitionPipelineObjectField : aws.DatapipelinePipelineDefinition.IDatapipelinePipelineDefinitionPipelineObjectField
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#key DatapipelinePipelineDefinition#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#ref_value DatapipelinePipelineDefinition#ref_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "refValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RefValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#string_value DatapipelinePipelineDefinition#string_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StringValue
        {
            get;
            set;
        }
    }
}
