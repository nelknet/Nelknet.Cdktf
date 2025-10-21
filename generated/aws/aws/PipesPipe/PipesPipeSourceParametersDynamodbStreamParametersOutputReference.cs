using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeSourceParametersDynamodbStreamParametersOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersDynamodbStreamParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeSourceParametersDynamodbStreamParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeSourceParametersDynamodbStreamParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeSourceParametersDynamodbStreamParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeSourceParametersDynamodbStreamParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDeadLetterConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersDynamodbStreamParametersDeadLetterConfig\"}}]")]
        public virtual void PutDeadLetterConfig(aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParametersDeadLetterConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParametersDeadLetterConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBatchSize")]
        public virtual void ResetBatchSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeadLetterConfig")]
        public virtual void ResetDeadLetterConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumBatchingWindowInSeconds")]
        public virtual void ResetMaximumBatchingWindowInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumRecordAgeInSeconds")]
        public virtual void ResetMaximumRecordAgeInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumRetryAttempts")]
        public virtual void ResetMaximumRetryAttempts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnPartialBatchItemFailure")]
        public virtual void ResetOnPartialBatchItemFailure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParallelizationFactor")]
        public virtual void ResetParallelizationFactor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersDynamodbStreamParametersDeadLetterConfigOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeSourceParametersDynamodbStreamParametersDeadLetterConfigOutputReference DeadLetterConfig
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeSourceParametersDynamodbStreamParametersDeadLetterConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "batchSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BatchSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deadLetterConfigInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersDynamodbStreamParametersDeadLetterConfig\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParametersDeadLetterConfig? DeadLetterConfigInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParametersDeadLetterConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumBatchingWindowInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumBatchingWindowInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumRecordAgeInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumRecordAgeInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumRetryAttemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumRetryAttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onPartialBatchItemFailureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnPartialBatchItemFailureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parallelizationFactorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ParallelizationFactorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startingPositionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartingPositionInput
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

        [JsiiProperty(name: "maximumRecordAgeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumRecordAgeInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumRetryAttempts
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onPartialBatchItemFailure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnPartialBatchItemFailure
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parallelizationFactor", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ParallelizationFactor
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartingPosition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersDynamodbStreamParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParameters? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
