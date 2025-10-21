using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiClass(nativeType: typeof(aws.Codepipeline.CodepipelineTriggerGitConfigurationPushOutputReference), fullyQualifiedName: "aws.codepipeline.CodepipelineTriggerGitConfigurationPushOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CodepipelineTriggerGitConfigurationPushOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CodepipelineTriggerGitConfigurationPushOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CodepipelineTriggerGitConfigurationPushOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineTriggerGitConfigurationPushOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBranches", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushBranches\"}}]")]
        public virtual void PutBranches(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushBranches @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushBranches)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilePaths", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushFilePaths\"}}]")]
        public virtual void PutFilePaths(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushFilePaths @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushFilePaths)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushTags\"}}]")]
        public virtual void PutTags(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushTags)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBranches")]
        public virtual void ResetBranches()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilePaths")]
        public virtual void ResetFilePaths()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "branches", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushBranchesOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineTriggerGitConfigurationPushBranchesOutputReference Branches
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineTriggerGitConfigurationPushBranchesOutputReference>()!;
        }

        [JsiiProperty(name: "filePaths", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushFilePathsOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineTriggerGitConfigurationPushFilePathsOutputReference FilePaths
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineTriggerGitConfigurationPushFilePathsOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushTagsOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineTriggerGitConfigurationPushTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineTriggerGitConfigurationPushTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "branchesInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushBranches\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushBranches? BranchesInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushBranches?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filePathsInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushFilePaths\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushFilePaths? FilePathsInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushFilePaths?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPushTags\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushTags? TagsInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineTriggerGitConfigurationPushTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPush\"}]}}", isOptional: true)]
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
                        case aws.Codepipeline.ICodepipelineTriggerGitConfigurationPush cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPush).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
