using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target aws_cloudwatch_event_target}.</summary>
    [JsiiClass(nativeType: typeof(aws.CloudwatchEventTarget.CloudwatchEventTarget), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTarget", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetConfig\"}}]")]
    public class CloudwatchEventTarget : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target aws_cloudwatch_event_target} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudwatchEventTarget(Constructs.Construct scope, string id, aws.CloudwatchEventTarget.ICloudwatchEventTargetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CloudwatchEventTarget.ICloudwatchEventTargetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTarget(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTarget(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CloudwatchEventTarget resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CloudwatchEventTarget to import.</param>
        /// <param name="importFromId">The id of the existing CloudwatchEventTarget that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CloudwatchEventTarget to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CloudwatchEventTarget to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CloudwatchEventTarget that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CloudwatchEventTarget to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CloudwatchEventTarget.CloudwatchEventTarget), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAppsyncTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetAppsyncTarget\"}}]")]
        public virtual void PutAppsyncTarget(aws.CloudwatchEventTarget.ICloudwatchEventTargetAppsyncTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetAppsyncTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBatchTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetBatchTarget\"}}]")]
        public virtual void PutBatchTarget(aws.CloudwatchEventTarget.ICloudwatchEventTargetBatchTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetBatchTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeadLetterConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetDeadLetterConfig\"}}]")]
        public virtual void PutDeadLetterConfig(aws.CloudwatchEventTarget.ICloudwatchEventTargetDeadLetterConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetDeadLetterConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcsTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetEcsTarget\"}}]")]
        public virtual void PutEcsTarget(aws.CloudwatchEventTarget.ICloudwatchEventTargetEcsTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetEcsTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetHttpTarget\"}}]")]
        public virtual void PutHttpTarget(aws.CloudwatchEventTarget.ICloudwatchEventTargetHttpTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetHttpTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInputTransformer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetInputTransformer\"}}]")]
        public virtual void PutInputTransformer(aws.CloudwatchEventTarget.ICloudwatchEventTargetInputTransformer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetInputTransformer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetKinesisTarget\"}}]")]
        public virtual void PutKinesisTarget(aws.CloudwatchEventTarget.ICloudwatchEventTargetKinesisTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetKinesisTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedshiftTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRedshiftTarget\"}}]")]
        public virtual void PutRedshiftTarget(aws.CloudwatchEventTarget.ICloudwatchEventTargetRedshiftTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetRedshiftTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetryPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRetryPolicy\"}}]")]
        public virtual void PutRetryPolicy(aws.CloudwatchEventTarget.ICloudwatchEventTargetRetryPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetRetryPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRunCommandTargets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRunCommandTargets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudwatchEventTarget.ICloudwatchEventTargetRunCommandTargets[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetRunCommandTargets).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetRunCommandTargets).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSagemakerPipelineTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTarget\"}}]")]
        public virtual void PutSagemakerPipelineTarget(aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqsTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSqsTarget\"}}]")]
        public virtual void PutSqsTarget(aws.CloudwatchEventTarget.ICloudwatchEventTargetSqsTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetSqsTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAppsyncTarget")]
        public virtual void ResetAppsyncTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBatchTarget")]
        public virtual void ResetBatchTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeadLetterConfig")]
        public virtual void ResetDeadLetterConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcsTarget")]
        public virtual void ResetEcsTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventBusName")]
        public virtual void ResetEventBusName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDestroy")]
        public virtual void ResetForceDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpTarget")]
        public virtual void ResetHttpTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInput")]
        public virtual void ResetInput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputPath")]
        public virtual void ResetInputPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputTransformer")]
        public virtual void ResetInputTransformer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisTarget")]
        public virtual void ResetKinesisTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedshiftTarget")]
        public virtual void ResetRedshiftTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryPolicy")]
        public virtual void ResetRetryPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoleArn")]
        public virtual void ResetRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunCommandTargets")]
        public virtual void ResetRunCommandTargets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSagemakerPipelineTarget")]
        public virtual void ResetSagemakerPipelineTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqsTarget")]
        public virtual void ResetSqsTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetId")]
        public virtual void ResetTargetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.CloudwatchEventTarget.CloudwatchEventTarget))!;

        [JsiiProperty(name: "appsyncTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetAppsyncTargetOutputReference\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetAppsyncTargetOutputReference AppsyncTarget
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetAppsyncTargetOutputReference>()!;
        }

        [JsiiProperty(name: "batchTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetBatchTargetOutputReference\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetBatchTargetOutputReference BatchTarget
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetBatchTargetOutputReference>()!;
        }

        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetDeadLetterConfigOutputReference\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetDeadLetterConfigOutputReference DeadLetterConfig
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetDeadLetterConfigOutputReference>()!;
        }

        [JsiiProperty(name: "ecsTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetEcsTargetOutputReference\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetEcsTargetOutputReference EcsTarget
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetEcsTargetOutputReference>()!;
        }

        [JsiiProperty(name: "httpTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetHttpTargetOutputReference\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetHttpTargetOutputReference HttpTarget
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetHttpTargetOutputReference>()!;
        }

        [JsiiProperty(name: "inputTransformer", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetInputTransformerOutputReference\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetInputTransformerOutputReference InputTransformer
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetInputTransformerOutputReference>()!;
        }

        [JsiiProperty(name: "kinesisTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetKinesisTargetOutputReference\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetKinesisTargetOutputReference KinesisTarget
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetKinesisTargetOutputReference>()!;
        }

        [JsiiProperty(name: "redshiftTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRedshiftTargetOutputReference\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetRedshiftTargetOutputReference RedshiftTarget
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetRedshiftTargetOutputReference>()!;
        }

        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRetryPolicyOutputReference\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetRetryPolicyOutputReference RetryPolicy
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetRetryPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "runCommandTargets", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRunCommandTargetsList\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetRunCommandTargetsList RunCommandTargets
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetRunCommandTargetsList>()!;
        }

        [JsiiProperty(name: "sagemakerPipelineTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetOutputReference\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetOutputReference SagemakerPipelineTarget
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetOutputReference>()!;
        }

        [JsiiProperty(name: "sqsTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSqsTargetOutputReference\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetSqsTargetOutputReference SqsTarget
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetSqsTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appsyncTargetInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetAppsyncTarget\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetAppsyncTarget? AppsyncTargetInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetAppsyncTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "batchTargetInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetBatchTarget\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetBatchTarget? BatchTargetInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetBatchTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deadLetterConfigInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetDeadLetterConfig\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetDeadLetterConfig? DeadLetterConfigInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetDeadLetterConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecsTargetInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetEcsTarget\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetEcsTarget? EcsTargetInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetEcsTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventBusNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventBusNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDestroyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceDestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpTargetInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetHttpTarget\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetHttpTarget? HttpTargetInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetHttpTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputTransformerInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetInputTransformer\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetInputTransformer? InputTransformerInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetInputTransformer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisTargetInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetKinesisTarget\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetKinesisTarget? KinesisTargetInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetKinesisTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redshiftTargetInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRedshiftTarget\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetRedshiftTarget? RedshiftTargetInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetRedshiftTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryPolicyInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRetryPolicy\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetRetryPolicy? RetryPolicyInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetRetryPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runCommandTargetsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RunCommandTargetsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sagemakerPipelineTargetInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTarget\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTarget? SagemakerPipelineTargetInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqsTargetInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSqsTarget\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetSqsTarget? SqsTargetInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetSqsTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventBusName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventBusName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceDestroy
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Input
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Rule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
