using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    [JsiiClass(nativeType: typeof(aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigOutputReference), fullyQualifiedName: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerEndpointConfigurationAsyncInferenceConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerEndpointConfigurationAsyncInferenceConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerEndpointConfigurationAsyncInferenceConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointConfigurationAsyncInferenceConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClientConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig\"}}]")]
        public virtual void PutClientConfig(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutputConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig\"}}]")]
        public virtual void PutOutputConfig(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientConfig")]
        public virtual void ResetClientConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientConfig", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfigOutputReference\"}")]
        public virtual aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfigOutputReference ClientConfig
        {
            get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfigOutputReference>()!;
        }

        [JsiiProperty(name: "outputConfig", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigOutputReference\"}")]
        public virtual aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigOutputReference OutputConfig
        {
            get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig\"}", isOptional: true)]
        public virtual aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig? ClientConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig\"}", isOptional: true)]
        public virtual aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig? OutputConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfig\"}", isOptional: true)]
        public virtual aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
