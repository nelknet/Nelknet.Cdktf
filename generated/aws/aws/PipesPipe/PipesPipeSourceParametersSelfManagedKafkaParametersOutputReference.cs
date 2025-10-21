using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeSourceParametersSelfManagedKafkaParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeSourceParametersSelfManagedKafkaParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeSourceParametersSelfManagedKafkaParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeSourceParametersSelfManagedKafkaParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentials\"}}]")]
        public virtual void PutCredentials(aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersVpc\"}}]")]
        public virtual void PutVpc(aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersVpc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersVpc)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalBootstrapServers")]
        public virtual void ResetAdditionalBootstrapServers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBatchSize")]
        public virtual void ResetBatchSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConsumerGroupId")]
        public virtual void ResetConsumerGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentials")]
        public virtual void ResetCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumBatchingWindowInSeconds")]
        public virtual void ResetMaximumBatchingWindowInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerRootCaCertificate")]
        public virtual void ResetServerRootCaCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartingPosition")]
        public virtual void ResetStartingPosition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpc")]
        public virtual void ResetVpc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentialsOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentialsOutputReference Credentials
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentialsOutputReference>()!;
        }

        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersVpcOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersVpcOutputReference Vpc
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersVpcOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalBootstrapServersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AdditionalBootstrapServersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "batchSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BatchSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "consumerGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConsumerGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentials\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials? CredentialsInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumBatchingWindowInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumBatchingWindowInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverRootCaCertificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerRootCaCertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startingPositionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartingPositionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TopicNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersVpc\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersVpc? VpcInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersVpc?>();
        }

        [JsiiProperty(name: "additionalBootstrapServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdditionalBootstrapServers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BatchSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "consumerGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumBatchingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumBatchingWindowInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverRootCaCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerRootCaCertificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartingPosition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "topicName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TopicName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParameters? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
