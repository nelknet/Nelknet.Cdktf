using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiClass(nativeType: typeof(aws.SagemakerModel.SagemakerModelPrimaryContainerImageConfigOutputReference), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerModelPrimaryContainerImageConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerModelPrimaryContainerImageConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerModelPrimaryContainerImageConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModelPrimaryContainerImageConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRepositoryAuthConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig\"}}]")]
        public virtual void PutRepositoryAuthConfig(aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRepositoryAuthConfig")]
        public virtual void ResetRepositoryAuthConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "repositoryAuthConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfigRepositoryAuthConfigOutputReference\"}")]
        public virtual aws.SagemakerModel.SagemakerModelPrimaryContainerImageConfigRepositoryAuthConfigOutputReference RepositoryAuthConfig
        {
            get => GetInstanceProperty<aws.SagemakerModel.SagemakerModelPrimaryContainerImageConfigRepositoryAuthConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryAccessModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryAccessModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryAuthConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig?>();
        }

        [JsiiProperty(name: "repositoryAccessMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryAccessMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfig\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
