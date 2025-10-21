using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiClass(nativeType: typeof(aws.Codepipeline.CodepipelineTriggerAllGitConfigurationPushOutputReference), fullyQualifiedName: "aws.codepipeline.CodepipelineTriggerAllGitConfigurationPushOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CodepipelineTriggerAllGitConfigurationPushOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CodepipelineTriggerAllGitConfigurationPushOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CodepipelineTriggerAllGitConfigurationPushOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineTriggerAllGitConfigurationPushOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "branches", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerAllGitConfigurationPushBranchesList\"}")]
        public virtual aws.Codepipeline.CodepipelineTriggerAllGitConfigurationPushBranchesList Branches
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineTriggerAllGitConfigurationPushBranchesList>()!;
        }

        [JsiiProperty(name: "filePaths", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerAllGitConfigurationPushFilePathsList\"}")]
        public virtual aws.Codepipeline.CodepipelineTriggerAllGitConfigurationPushFilePathsList FilePaths
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineTriggerAllGitConfigurationPushFilePathsList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerAllGitConfigurationPushTagsList\"}")]
        public virtual aws.Codepipeline.CodepipelineTriggerAllGitConfigurationPushTagsList Tags
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineTriggerAllGitConfigurationPushTagsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineTriggerAllGitConfigurationPush\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineTriggerAllGitConfigurationPush? InternalValue
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineTriggerAllGitConfigurationPush?>();
            set => SetInstanceProperty(value);
        }
    }
}
