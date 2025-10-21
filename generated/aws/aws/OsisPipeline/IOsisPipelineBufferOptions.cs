using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OsisPipeline
{
    [JsiiInterface(nativeType: typeof(IOsisPipelineBufferOptions), fullyQualifiedName: "aws.osisPipeline.OsisPipelineBufferOptions")]
    public interface IOsisPipelineBufferOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#persistent_buffer_enabled OsisPipeline#persistent_buffer_enabled}.</summary>
        [JsiiProperty(name: "persistentBufferEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object PersistentBufferEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOsisPipelineBufferOptions), fullyQualifiedName: "aws.osisPipeline.OsisPipelineBufferOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OsisPipeline.IOsisPipelineBufferOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#persistent_buffer_enabled OsisPipeline#persistent_buffer_enabled}.</summary>
            [JsiiProperty(name: "persistentBufferEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object PersistentBufferEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
