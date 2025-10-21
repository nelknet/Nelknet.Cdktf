using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatapipelinePipelineDefinition
{
    [JsiiInterface(nativeType: typeof(IDatapipelinePipelineDefinitionParameterObjectAttribute), fullyQualifiedName: "aws.datapipelinePipelineDefinition.DatapipelinePipelineDefinitionParameterObjectAttribute")]
    public interface IDatapipelinePipelineDefinitionParameterObjectAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#key DatapipelinePipelineDefinition#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#string_value DatapipelinePipelineDefinition#string_value}.</summary>
        [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}")]
        string StringValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatapipelinePipelineDefinitionParameterObjectAttribute), fullyQualifiedName: "aws.datapipelinePipelineDefinition.DatapipelinePipelineDefinitionParameterObjectAttribute")]
        internal sealed class _Proxy : DeputyBase, aws.DatapipelinePipelineDefinition.IDatapipelinePipelineDefinitionParameterObjectAttribute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#key DatapipelinePipelineDefinition#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#string_value DatapipelinePipelineDefinition#string_value}.</summary>
            [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}")]
            public string StringValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
