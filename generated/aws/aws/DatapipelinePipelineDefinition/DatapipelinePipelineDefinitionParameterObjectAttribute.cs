using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatapipelinePipelineDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datapipelinePipelineDefinition.DatapipelinePipelineDefinitionParameterObjectAttribute")]
    public class DatapipelinePipelineDefinitionParameterObjectAttribute : aws.DatapipelinePipelineDefinition.IDatapipelinePipelineDefinitionParameterObjectAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#key DatapipelinePipelineDefinition#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#string_value DatapipelinePipelineDefinition#string_value}.</summary>
        [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}")]
        public string StringValue
        {
            get;
            set;
        }
    }
}
