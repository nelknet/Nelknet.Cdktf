using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsBedrockInferenceProfiles
{
    [JsiiClass(nativeType: typeof(aws.DataAwsBedrockInferenceProfiles.DataAwsBedrockInferenceProfilesInferenceProfileSummariesOutputReference), fullyQualifiedName: "aws.dataAwsBedrockInferenceProfiles.DataAwsBedrockInferenceProfilesInferenceProfileSummariesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsBedrockInferenceProfilesInferenceProfileSummariesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsBedrockInferenceProfilesInferenceProfileSummariesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsBedrockInferenceProfilesInferenceProfileSummariesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsBedrockInferenceProfilesInferenceProfileSummariesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inferenceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InferenceProfileArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inferenceProfileId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InferenceProfileId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inferenceProfileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InferenceProfileName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "models", typeJson: "{\"fqn\":\"aws.dataAwsBedrockInferenceProfiles.DataAwsBedrockInferenceProfilesInferenceProfileSummariesModelsList\"}")]
        public virtual aws.DataAwsBedrockInferenceProfiles.DataAwsBedrockInferenceProfilesInferenceProfileSummariesModelsList Models
        {
            get => GetInstanceProperty<aws.DataAwsBedrockInferenceProfiles.DataAwsBedrockInferenceProfilesInferenceProfileSummariesModelsList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsBedrockInferenceProfiles.DataAwsBedrockInferenceProfilesInferenceProfileSummaries\"}", isOptional: true)]
        public virtual aws.DataAwsBedrockInferenceProfiles.IDataAwsBedrockInferenceProfilesInferenceProfileSummaries? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsBedrockInferenceProfiles.IDataAwsBedrockInferenceProfilesInferenceProfileSummaries?>();
            set => SetInstanceProperty(value);
        }
    }
}
