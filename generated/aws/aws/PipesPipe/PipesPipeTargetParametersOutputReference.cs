using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeTargetParametersOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeTargetParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeTargetParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeTargetParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeTargetParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBatchJobParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParameters\"}}]")]
        public virtual void PutBatchJobParameters(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCloudwatchLogsParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersCloudwatchLogsParameters\"}}]")]
        public virtual void PutCloudwatchLogsParameters(aws.PipesPipe.IPipesPipeTargetParametersCloudwatchLogsParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersCloudwatchLogsParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcsTaskParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParameters\"}}]")]
        public virtual void PutEcsTaskParameters(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEventbridgeEventBusParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEventbridgeEventBusParameters\"}}]")]
        public virtual void PutEventbridgeEventBusParameters(aws.PipesPipe.IPipesPipeTargetParametersEventbridgeEventBusParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersEventbridgeEventBusParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersHttpParameters\"}}]")]
        public virtual void PutHttpParameters(aws.PipesPipe.IPipesPipeTargetParametersHttpParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersHttpParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisStreamParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersKinesisStreamParameters\"}}]")]
        public virtual void PutKinesisStreamParameters(aws.PipesPipe.IPipesPipeTargetParametersKinesisStreamParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersKinesisStreamParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaFunctionParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersLambdaFunctionParameters\"}}]")]
        public virtual void PutLambdaFunctionParameters(aws.PipesPipe.IPipesPipeTargetParametersLambdaFunctionParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersLambdaFunctionParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedshiftDataParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersRedshiftDataParameters\"}}]")]
        public virtual void PutRedshiftDataParameters(aws.PipesPipe.IPipesPipeTargetParametersRedshiftDataParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersRedshiftDataParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSagemakerPipelineParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParameters\"}}]")]
        public virtual void PutSagemakerPipelineParameters(aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqsQueueParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSqsQueueParameters\"}}]")]
        public virtual void PutSqsQueueParameters(aws.PipesPipe.IPipesPipeTargetParametersSqsQueueParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersSqsQueueParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepFunctionStateMachineParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersStepFunctionStateMachineParameters\"}}]")]
        public virtual void PutStepFunctionStateMachineParameters(aws.PipesPipe.IPipesPipeTargetParametersStepFunctionStateMachineParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersStepFunctionStateMachineParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBatchJobParameters")]
        public virtual void ResetBatchJobParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudwatchLogsParameters")]
        public virtual void ResetCloudwatchLogsParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcsTaskParameters")]
        public virtual void ResetEcsTaskParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventbridgeEventBusParameters")]
        public virtual void ResetEventbridgeEventBusParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpParameters")]
        public virtual void ResetHttpParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputTemplate")]
        public virtual void ResetInputTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisStreamParameters")]
        public virtual void ResetKinesisStreamParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaFunctionParameters")]
        public virtual void ResetLambdaFunctionParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedshiftDataParameters")]
        public virtual void ResetRedshiftDataParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSagemakerPipelineParameters")]
        public virtual void ResetSagemakerPipelineParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqsQueueParameters")]
        public virtual void ResetSqsQueueParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepFunctionStateMachineParameters")]
        public virtual void ResetStepFunctionStateMachineParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "batchJobParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersOutputReference BatchJobParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersOutputReference>()!;
        }

        [JsiiProperty(name: "cloudwatchLogsParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersCloudwatchLogsParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersCloudwatchLogsParametersOutputReference CloudwatchLogsParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersCloudwatchLogsParametersOutputReference>()!;
        }

        [JsiiProperty(name: "ecsTaskParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersEcsTaskParametersOutputReference EcsTaskParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersEcsTaskParametersOutputReference>()!;
        }

        [JsiiProperty(name: "eventbridgeEventBusParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEventbridgeEventBusParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersEventbridgeEventBusParametersOutputReference EventbridgeEventBusParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersEventbridgeEventBusParametersOutputReference>()!;
        }

        [JsiiProperty(name: "httpParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersHttpParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersHttpParametersOutputReference HttpParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersHttpParametersOutputReference>()!;
        }

        [JsiiProperty(name: "kinesisStreamParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersKinesisStreamParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersKinesisStreamParametersOutputReference KinesisStreamParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersKinesisStreamParametersOutputReference>()!;
        }

        [JsiiProperty(name: "lambdaFunctionParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersLambdaFunctionParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersLambdaFunctionParametersOutputReference LambdaFunctionParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersLambdaFunctionParametersOutputReference>()!;
        }

        [JsiiProperty(name: "redshiftDataParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersRedshiftDataParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersRedshiftDataParametersOutputReference RedshiftDataParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersRedshiftDataParametersOutputReference>()!;
        }

        [JsiiProperty(name: "sagemakerPipelineParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersSagemakerPipelineParametersOutputReference SagemakerPipelineParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersSagemakerPipelineParametersOutputReference>()!;
        }

        [JsiiProperty(name: "sqsQueueParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSqsQueueParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersSqsQueueParametersOutputReference SqsQueueParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersSqsQueueParametersOutputReference>()!;
        }

        [JsiiProperty(name: "stepFunctionStateMachineParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersStepFunctionStateMachineParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersStepFunctionStateMachineParametersOutputReference StepFunctionStateMachineParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersStepFunctionStateMachineParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "batchJobParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersBatchJobParameters? BatchJobParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersBatchJobParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersCloudwatchLogsParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersCloudwatchLogsParameters? CloudwatchLogsParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersCloudwatchLogsParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecsTaskParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParameters? EcsTaskParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventbridgeEventBusParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEventbridgeEventBusParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersEventbridgeEventBusParameters? EventbridgeEventBusParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersEventbridgeEventBusParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersHttpParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersHttpParameters? HttpParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersHttpParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputTemplateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputTemplateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisStreamParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersKinesisStreamParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersKinesisStreamParameters? KinesisStreamParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersKinesisStreamParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersLambdaFunctionParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersLambdaFunctionParameters? LambdaFunctionParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersLambdaFunctionParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redshiftDataParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersRedshiftDataParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersRedshiftDataParameters? RedshiftDataParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersRedshiftDataParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sagemakerPipelineParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParameters? SagemakerPipelineParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqsQueueParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSqsQueueParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersSqsQueueParameters? SqsQueueParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersSqsQueueParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepFunctionStateMachineParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersStepFunctionStateMachineParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersStepFunctionStateMachineParameters? StepFunctionStateMachineParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersStepFunctionStateMachineParameters?>();
        }

        [JsiiProperty(name: "inputTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputTemplate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParameters? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
