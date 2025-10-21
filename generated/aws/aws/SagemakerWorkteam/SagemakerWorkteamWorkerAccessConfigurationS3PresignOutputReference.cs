using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    [JsiiClass(nativeType: typeof(aws.SagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3PresignOutputReference), fullyQualifiedName: "aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3PresignOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerWorkteamWorkerAccessConfigurationS3PresignOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerWorkteamWorkerAccessConfigurationS3PresignOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerWorkteamWorkerAccessConfigurationS3PresignOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerWorkteamWorkerAccessConfigurationS3PresignOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIamPolicyConstraints", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraints\"}}]")]
        public virtual void PutIamPolicyConstraints(aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraints @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraints)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIamPolicyConstraints")]
        public virtual void ResetIamPolicyConstraints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "iamPolicyConstraints", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraintsOutputReference\"}")]
        public virtual aws.SagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraintsOutputReference IamPolicyConstraints
        {
            get => GetInstanceProperty<aws.SagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraintsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamPolicyConstraintsInput", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraints\"}", isOptional: true)]
        public virtual aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraints? IamPolicyConstraintsInput
        {
            get => GetInstanceProperty<aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraints?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3Presign\"}", isOptional: true)]
        public virtual aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3Presign? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3Presign?>();
            set => SetInstanceProperty(value);
        }
    }
}
