using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiClass(nativeType: typeof(aws.SagemakerModel.SagemakerModelContainerImageConfigOutputReference), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerImageConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerModelContainerImageConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerModelContainerImageConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerModelContainerImageConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModelContainerImageConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRepositoryAuthConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerImageConfigRepositoryAuthConfig\"}}]")]
        public virtual void PutRepositoryAuthConfig(aws.SagemakerModel.ISagemakerModelContainerImageConfigRepositoryAuthConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerModel.ISagemakerModelContainerImageConfigRepositoryAuthConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRepositoryAuthConfig")]
        public virtual void ResetRepositoryAuthConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "repositoryAuthConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerImageConfigRepositoryAuthConfigOutputReference\"}")]
        public virtual aws.SagemakerModel.SagemakerModelContainerImageConfigRepositoryAuthConfigOutputReference RepositoryAuthConfig
        {
            get => GetInstanceProperty<aws.SagemakerModel.SagemakerModelContainerImageConfigRepositoryAuthConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryAccessModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryAccessModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryAuthConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerImageConfigRepositoryAuthConfig\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelContainerImageConfigRepositoryAuthConfig?>();
        }

        [JsiiProperty(name: "repositoryAccessMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryAccessMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerImageConfig\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelContainerImageConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelContainerImageConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
