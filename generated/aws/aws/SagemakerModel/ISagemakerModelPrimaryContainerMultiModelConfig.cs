using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelPrimaryContainerMultiModelConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelPrimaryContainerMultiModelConfig")]
    public interface ISagemakerModelPrimaryContainerMultiModelConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#model_cache_setting SagemakerModel#model_cache_setting}.</summary>
        [JsiiProperty(name: "modelCacheSetting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelCacheSetting
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelPrimaryContainerMultiModelConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelPrimaryContainerMultiModelConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerModel.ISagemakerModelPrimaryContainerMultiModelConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#model_cache_setting SagemakerModel#model_cache_setting}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelCacheSetting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelCacheSetting
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
