using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OsisPipeline
{
    [JsiiInterface(nativeType: typeof(IOsisPipelineLogPublishingOptionsCloudwatchLogDestination), fullyQualifiedName: "aws.osisPipeline.OsisPipelineLogPublishingOptionsCloudwatchLogDestination")]
    public interface IOsisPipelineLogPublishingOptionsCloudwatchLogDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#log_group OsisPipeline#log_group}.</summary>
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroup
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOsisPipelineLogPublishingOptionsCloudwatchLogDestination), fullyQualifiedName: "aws.osisPipeline.OsisPipelineLogPublishingOptionsCloudwatchLogDestination")]
        internal sealed class _Proxy : DeputyBase, aws.OsisPipeline.IOsisPipelineLogPublishingOptionsCloudwatchLogDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#log_group OsisPipeline#log_group}.</summary>
            [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroup
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
