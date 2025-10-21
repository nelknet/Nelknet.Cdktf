using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiClass(nativeType: typeof(aws.SagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsOutputReference), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerSpaceSpaceSettingsSpaceStorageSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerSpaceSpaceSettingsSpaceStorageSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerSpaceSpaceSettingsSpaceStorageSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerSpaceSpaceSettingsSpaceStorageSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEbsStorageSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings\"}}]")]
        public virtual void PutEbsStorageSettings(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings)}, new object[]{@value});
        }

        [JsiiProperty(name: "ebsStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettingsOutputReference\"}")]
        public virtual aws.SagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettingsOutputReference EbsStorageSettings
        {
            get => GetInstanceProperty<aws.SagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsStorageSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings\"}", isOptional: true)]
        public virtual aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings? EbsStorageSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettingsEbsStorageSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettings\"}", isOptional: true)]
        public virtual aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettings? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
