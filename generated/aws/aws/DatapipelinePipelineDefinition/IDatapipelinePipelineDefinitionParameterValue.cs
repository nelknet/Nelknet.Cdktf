using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatapipelinePipelineDefinition
{
    [JsiiInterface(nativeType: typeof(IDatapipelinePipelineDefinitionParameterValue), fullyQualifiedName: "aws.datapipelinePipelineDefinition.DatapipelinePipelineDefinitionParameterValue")]
    public interface IDatapipelinePipelineDefinitionParameterValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#id DatapipelinePipelineDefinition#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#string_value DatapipelinePipelineDefinition#string_value}.</summary>
        [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}")]
        string StringValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatapipelinePipelineDefinitionParameterValue), fullyQualifiedName: "aws.datapipelinePipelineDefinition.DatapipelinePipelineDefinitionParameterValue")]
        internal sealed class _Proxy : DeputyBase, aws.DatapipelinePipelineDefinition.IDatapipelinePipelineDefinitionParameterValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#id DatapipelinePipelineDefinition#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
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
