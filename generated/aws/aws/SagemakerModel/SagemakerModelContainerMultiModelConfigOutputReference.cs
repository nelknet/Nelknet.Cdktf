using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiClass(nativeType: typeof(aws.SagemakerModel.SagemakerModelContainerMultiModelConfigOutputReference), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerMultiModelConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerModelContainerMultiModelConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerModelContainerMultiModelConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModelContainerMultiModelConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModelContainerMultiModelConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetModelCacheSetting")]
        public virtual void ResetModelCacheSetting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelCacheSettingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelCacheSettingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "modelCacheSetting", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelCacheSetting
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerMultiModelConfig\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelContainerMultiModelConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelContainerMultiModelConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
