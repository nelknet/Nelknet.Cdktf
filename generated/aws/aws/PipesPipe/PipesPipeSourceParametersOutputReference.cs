using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeSourceParametersOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeSourceParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeSourceParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeSourceParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeSourceParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActivemqBrokerParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersActivemqBrokerParameters\"}}]")]
        public virtual void PutActivemqBrokerParameters(aws.PipesPipe.IPipesPipeSourceParametersActivemqBrokerParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeSourceParametersActivemqBrokerParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDynamodbStreamParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersDynamodbStreamParameters\"}}]")]
        public virtual void PutDynamodbStreamParameters(aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilterCriteria", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersFilterCriteria\"}}]")]
        public virtual void PutFilterCriteria(aws.PipesPipe.IPipesPipeSourceParametersFilterCriteria @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeSourceParametersFilterCriteria)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisStreamParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersKinesisStreamParameters\"}}]")]
        public virtual void PutKinesisStreamParameters(aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManagedStreamingKafkaParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersManagedStreamingKafkaParameters\"}}]")]
        public virtual void PutManagedStreamingKafkaParameters(aws.PipesPipe.IPipesPipeSourceParametersManagedStreamingKafkaParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeSourceParametersManagedStreamingKafkaParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRabbitmqBrokerParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersRabbitmqBrokerParameters\"}}]")]
        public virtual void PutRabbitmqBrokerParameters(aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSelfManagedKafkaParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParameters\"}}]")]
        public virtual void PutSelfManagedKafkaParameters(aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqsQueueParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSqsQueueParameters\"}}]")]
        public virtual void PutSqsQueueParameters(aws.PipesPipe.IPipesPipeSourceParametersSqsQueueParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeSourceParametersSqsQueueParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActivemqBrokerParameters")]
        public virtual void ResetActivemqBrokerParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodbStreamParameters")]
        public virtual void ResetDynamodbStreamParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilterCriteria")]
        public virtual void ResetFilterCriteria()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisStreamParameters")]
        public virtual void ResetKinesisStreamParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedStreamingKafkaParameters")]
        public virtual void ResetManagedStreamingKafkaParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRabbitmqBrokerParameters")]
        public virtual void ResetRabbitmqBrokerParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSelfManagedKafkaParameters")]
        public virtual void ResetSelfManagedKafkaParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqsQueueParameters")]
        public virtual void ResetSqsQueueParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "activemqBrokerParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersActivemqBrokerParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeSourceParametersActivemqBrokerParametersOutputReference ActivemqBrokerParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeSourceParametersActivemqBrokerParametersOutputReference>()!;
        }

        [JsiiProperty(name: "dynamodbStreamParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersDynamodbStreamParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeSourceParametersDynamodbStreamParametersOutputReference DynamodbStreamParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeSourceParametersDynamodbStreamParametersOutputReference>()!;
        }

        [JsiiProperty(name: "filterCriteria", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersFilterCriteriaOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeSourceParametersFilterCriteriaOutputReference FilterCriteria
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeSourceParametersFilterCriteriaOutputReference>()!;
        }

        [JsiiProperty(name: "kinesisStreamParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersKinesisStreamParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeSourceParametersKinesisStreamParametersOutputReference KinesisStreamParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeSourceParametersKinesisStreamParametersOutputReference>()!;
        }

        [JsiiProperty(name: "managedStreamingKafkaParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersManagedStreamingKafkaParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeSourceParametersManagedStreamingKafkaParametersOutputReference ManagedStreamingKafkaParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeSourceParametersManagedStreamingKafkaParametersOutputReference>()!;
        }

        [JsiiProperty(name: "rabbitmqBrokerParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersRabbitmqBrokerParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeSourceParametersRabbitmqBrokerParametersOutputReference RabbitmqBrokerParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeSourceParametersRabbitmqBrokerParametersOutputReference>()!;
        }

        [JsiiProperty(name: "selfManagedKafkaParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersOutputReference SelfManagedKafkaParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersOutputReference>()!;
        }

        [JsiiProperty(name: "sqsQueueParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSqsQueueParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeSourceParametersSqsQueueParametersOutputReference SqsQueueParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeSourceParametersSqsQueueParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activemqBrokerParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersActivemqBrokerParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersActivemqBrokerParameters? ActivemqBrokerParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersActivemqBrokerParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbStreamParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersDynamodbStreamParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParameters? DynamodbStreamParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterCriteriaInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersFilterCriteria\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersFilterCriteria? FilterCriteriaInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersFilterCriteria?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisStreamParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersKinesisStreamParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParameters? KinesisStreamParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedStreamingKafkaParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersManagedStreamingKafkaParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersManagedStreamingKafkaParameters? ManagedStreamingKafkaParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersManagedStreamingKafkaParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rabbitmqBrokerParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersRabbitmqBrokerParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParameters? RabbitmqBrokerParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "selfManagedKafkaParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParameters? SelfManagedKafkaParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqsQueueParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSqsQueueParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersSqsQueueParameters? SqsQueueParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersSqsQueueParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParameters? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
