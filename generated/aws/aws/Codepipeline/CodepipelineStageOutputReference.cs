using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiClass(nativeType: typeof(aws.Codepipeline.CodepipelineStageOutputReference), fullyQualifiedName: "aws.codepipeline.CodepipelineStageOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CodepipelineStageOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CodepipelineStageOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineStageOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineStageOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineStageAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Codepipeline.ICodepipelineStageAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Codepipeline.ICodepipelineStageAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Codepipeline.ICodepipelineStageAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBeforeEntry", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntry\"}}]")]
        public virtual void PutBeforeEntry(aws.Codepipeline.ICodepipelineStageBeforeEntry @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineStageBeforeEntry)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOnFailure", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailure\"}}]")]
        public virtual void PutOnFailure(aws.Codepipeline.ICodepipelineStageOnFailure @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineStageOnFailure)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOnSuccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccess\"}}]")]
        public virtual void PutOnSuccess(aws.Codepipeline.ICodepipelineStageOnSuccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineStageOnSuccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBeforeEntry")]
        public virtual void ResetBeforeEntry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnFailure")]
        public virtual void ResetOnFailure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnSuccess")]
        public virtual void ResetOnSuccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageActionList\"}")]
        public virtual aws.Codepipeline.CodepipelineStageActionList Action
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineStageActionList>()!;
        }

        [JsiiProperty(name: "beforeEntry", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntryOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineStageBeforeEntryOutputReference BeforeEntry
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineStageBeforeEntryOutputReference>()!;
        }

        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailureOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineStageOnFailureOutputReference OnFailure
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineStageOnFailureOutputReference>()!;
        }

        [JsiiProperty(name: "onSuccess", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccessOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineStageOnSuccessOutputReference OnSuccess
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineStageOnSuccessOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineStageAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "beforeEntryInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntry\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineStageBeforeEntry? BeforeEntryInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageBeforeEntry?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onFailureInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailure\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineStageOnFailure? OnFailureInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageOnFailure?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onSuccessInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccess\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineStageOnSuccess? OnSuccessInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineStageOnSuccess?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.codepipeline.CodepipelineStage\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Codepipeline.ICodepipelineStage cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Codepipeline.ICodepipelineStage).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
