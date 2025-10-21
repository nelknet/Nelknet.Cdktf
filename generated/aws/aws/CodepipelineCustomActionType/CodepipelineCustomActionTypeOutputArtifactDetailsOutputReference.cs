using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodepipelineCustomActionType
{
    [JsiiClass(nativeType: typeof(aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeOutputArtifactDetailsOutputReference), fullyQualifiedName: "aws.codepipelineCustomActionType.CodepipelineCustomActionTypeOutputArtifactDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodepipelineCustomActionTypeOutputArtifactDetailsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodepipelineCustomActionTypeOutputArtifactDetailsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CodepipelineCustomActionTypeOutputArtifactDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineCustomActionTypeOutputArtifactDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maximumCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeOutputArtifactDetails\"}", isOptional: true)]
        public virtual aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeOutputArtifactDetails? InternalValue
        {
            get => GetInstanceProperty<aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeOutputArtifactDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
