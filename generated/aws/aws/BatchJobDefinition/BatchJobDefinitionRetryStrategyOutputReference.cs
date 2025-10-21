using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiClass(nativeType: typeof(aws.BatchJobDefinition.BatchJobDefinitionRetryStrategyOutputReference), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionRetryStrategyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BatchJobDefinitionRetryStrategyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BatchJobDefinitionRetryStrategyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BatchJobDefinitionRetryStrategyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchJobDefinitionRetryStrategyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEvaluateOnExit", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionRetryStrategyEvaluateOnExit\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEvaluateOnExit(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.BatchJobDefinition.IBatchJobDefinitionRetryStrategyEvaluateOnExit[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BatchJobDefinition.IBatchJobDefinitionRetryStrategyEvaluateOnExit).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BatchJobDefinition.IBatchJobDefinitionRetryStrategyEvaluateOnExit).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttempts")]
        public virtual void ResetAttempts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEvaluateOnExit")]
        public virtual void ResetEvaluateOnExit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "evaluateOnExit", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionRetryStrategyEvaluateOnExitList\"}")]
        public virtual aws.BatchJobDefinition.BatchJobDefinitionRetryStrategyEvaluateOnExitList EvaluateOnExit
        {
            get => GetInstanceProperty<aws.BatchJobDefinition.BatchJobDefinitionRetryStrategyEvaluateOnExitList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "evaluateOnExitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionRetryStrategyEvaluateOnExit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EvaluateOnExitInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Attempts
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionRetryStrategy\"}", isOptional: true)]
        public virtual aws.BatchJobDefinition.IBatchJobDefinitionRetryStrategy? InternalValue
        {
            get => GetInstanceProperty<aws.BatchJobDefinition.IBatchJobDefinitionRetryStrategy?>();
            set => SetInstanceProperty(value);
        }
    }
}
