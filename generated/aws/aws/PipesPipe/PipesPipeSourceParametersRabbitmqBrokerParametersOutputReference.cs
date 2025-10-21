using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeSourceParametersRabbitmqBrokerParametersOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersRabbitmqBrokerParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeSourceParametersRabbitmqBrokerParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeSourceParametersRabbitmqBrokerParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeSourceParametersRabbitmqBrokerParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeSourceParametersRabbitmqBrokerParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersRabbitmqBrokerParametersCredentials\"}}]")]
        public virtual void PutCredentials(aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParametersCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParametersCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBatchSize")]
        public virtual void ResetBatchSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumBatchingWindowInSeconds")]
        public virtual void ResetMaximumBatchingWindowInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualHost")]
        public virtual void ResetVirtualHost()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersRabbitmqBrokerParametersCredentialsOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeSourceParametersRabbitmqBrokerParametersCredentialsOutputReference Credentials
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeSourceParametersRabbitmqBrokerParametersCredentialsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "batchSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BatchSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersRabbitmqBrokerParametersCredentials\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParametersCredentials? CredentialsInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParametersCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumBatchingWindowInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumBatchingWindowInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queueNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueueNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualHostInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualHostInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BatchSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumBatchingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumBatchingWindowInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueueName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualHost
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersRabbitmqBrokerParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParameters? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
