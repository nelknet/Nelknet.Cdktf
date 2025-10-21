using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElastictranscoderPipeline
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPipelineNotifications), fullyQualifiedName: "aws.elastictranscoderPipeline.ElastictranscoderPipelineNotifications")]
    public interface IElastictranscoderPipelineNotifications
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#completed ElastictranscoderPipeline#completed}.</summary>
        [JsiiProperty(name: "completed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Completed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#error ElastictranscoderPipeline#error}.</summary>
        [JsiiProperty(name: "error", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Error
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#progressing ElastictranscoderPipeline#progressing}.</summary>
        [JsiiProperty(name: "progressing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Progressing
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#warning ElastictranscoderPipeline#warning}.</summary>
        [JsiiProperty(name: "warning", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Warning
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPipelineNotifications), fullyQualifiedName: "aws.elastictranscoderPipeline.ElastictranscoderPipelineNotifications")]
        internal sealed class _Proxy : DeputyBase, aws.ElastictranscoderPipeline.IElastictranscoderPipelineNotifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#completed ElastictranscoderPipeline#completed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "completed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Completed
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#error ElastictranscoderPipeline#error}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "error", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Error
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#progressing ElastictranscoderPipeline#progressing}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "progressing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Progressing
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#warning ElastictranscoderPipeline#warning}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warning", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Warning
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
