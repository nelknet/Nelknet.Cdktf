using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatapipelinePipelineDefinition
{
    [JsiiInterface(nativeType: typeof(IDatapipelinePipelineDefinitionParameterObject), fullyQualifiedName: "aws.datapipelinePipelineDefinition.DatapipelinePipelineDefinitionParameterObject")]
    public interface IDatapipelinePipelineDefinitionParameterObject
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

        /// <summary>attribute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#attribute DatapipelinePipelineDefinition#attribute}
        /// </remarks>
        [JsiiProperty(name: "attribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datapipelinePipelineDefinition.DatapipelinePipelineDefinitionParameterObjectAttribute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Attribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatapipelinePipelineDefinitionParameterObject), fullyQualifiedName: "aws.datapipelinePipelineDefinition.DatapipelinePipelineDefinitionParameterObject")]
        internal sealed class _Proxy : DeputyBase, aws.DatapipelinePipelineDefinition.IDatapipelinePipelineDefinitionParameterObject
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

            /// <summary>attribute block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#attribute DatapipelinePipelineDefinition#attribute}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datapipelinePipelineDefinition.DatapipelinePipelineDefinitionParameterObjectAttribute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Attribute
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
