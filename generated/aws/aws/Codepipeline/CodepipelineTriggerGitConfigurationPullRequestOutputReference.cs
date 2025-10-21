using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiClass(nativeType: typeof(aws.Codepipeline.CodepipelineTriggerGitConfigurationPullRequestOutputReference), fullyQualifiedName: "aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CodepipelineTriggerGitConfigurationPullRequestOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CodepipelineTriggerGitConfigurationPullRequestOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CodepipelineTriggerGitConfigurationPullRequestOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineTriggerGitConfigurationPullRequestOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBranches", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestBranches\"}}]")]
        public virtual void PutBranches(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestBranches @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestBranches)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilePaths", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestFilePaths\"}}]")]
        public virtual void PutFilePaths(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestFilePaths @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestFilePaths)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBranches")]
        public virtual void ResetBranches()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEvents")]
        public virtual void ResetEvents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilePaths")]
        public virtual void ResetFilePaths()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "branches", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestBranchesOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineTriggerGitConfigurationPullRequestBranchesOutputReference Branches
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineTriggerGitConfigurationPullRequestBranchesOutputReference>()!;
        }

        [JsiiProperty(name: "filePaths", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestFilePathsOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineTriggerGitConfigurationPullRequestFilePathsOutputReference FilePaths
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineTriggerGitConfigurationPullRequestFilePathsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "branchesInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestBranches\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestBranches? BranchesInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestBranches?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EventsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filePathsInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequestFilePaths\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestFilePaths? FilePathsInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequestFilePaths?>();
        }

        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Events
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequest\"}]}}", isOptional: true)]
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
                        case aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequest cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequest).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
