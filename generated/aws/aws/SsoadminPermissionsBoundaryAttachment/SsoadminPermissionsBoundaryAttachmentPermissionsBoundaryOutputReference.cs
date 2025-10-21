using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminPermissionsBoundaryAttachment
{
    [JsiiClass(nativeType: typeof(aws.SsoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentPermissionsBoundaryOutputReference), fullyQualifiedName: "aws.ssoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentPermissionsBoundaryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SsoadminPermissionsBoundaryAttachmentPermissionsBoundaryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SsoadminPermissionsBoundaryAttachmentPermissionsBoundaryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SsoadminPermissionsBoundaryAttachmentPermissionsBoundaryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsoadminPermissionsBoundaryAttachmentPermissionsBoundaryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomerManagedPolicyReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentPermissionsBoundaryCustomerManagedPolicyReference\"}}]")]
        public virtual void PutCustomerManagedPolicyReference(aws.SsoadminPermissionsBoundaryAttachment.ISsoadminPermissionsBoundaryAttachmentPermissionsBoundaryCustomerManagedPolicyReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SsoadminPermissionsBoundaryAttachment.ISsoadminPermissionsBoundaryAttachmentPermissionsBoundaryCustomerManagedPolicyReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomerManagedPolicyReference")]
        public virtual void ResetCustomerManagedPolicyReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedPolicyArn")]
        public virtual void ResetManagedPolicyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customerManagedPolicyReference", typeJson: "{\"fqn\":\"aws.ssoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentPermissionsBoundaryCustomerManagedPolicyReferenceOutputReference\"}")]
        public virtual aws.SsoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentPermissionsBoundaryCustomerManagedPolicyReferenceOutputReference CustomerManagedPolicyReference
        {
            get => GetInstanceProperty<aws.SsoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentPermissionsBoundaryCustomerManagedPolicyReferenceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerManagedPolicyReferenceInput", typeJson: "{\"fqn\":\"aws.ssoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentPermissionsBoundaryCustomerManagedPolicyReference\"}", isOptional: true)]
        public virtual aws.SsoadminPermissionsBoundaryAttachment.ISsoadminPermissionsBoundaryAttachmentPermissionsBoundaryCustomerManagedPolicyReference? CustomerManagedPolicyReferenceInput
        {
            get => GetInstanceProperty<aws.SsoadminPermissionsBoundaryAttachment.ISsoadminPermissionsBoundaryAttachmentPermissionsBoundaryCustomerManagedPolicyReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedPolicyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedPolicyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "managedPolicyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedPolicyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ssoadminPermissionsBoundaryAttachment.SsoadminPermissionsBoundaryAttachmentPermissionsBoundary\"}", isOptional: true)]
        public virtual aws.SsoadminPermissionsBoundaryAttachment.ISsoadminPermissionsBoundaryAttachmentPermissionsBoundary? InternalValue
        {
            get => GetInstanceProperty<aws.SsoadminPermissionsBoundaryAttachment.ISsoadminPermissionsBoundaryAttachmentPermissionsBoundary?>();
            set => SetInstanceProperty(value);
        }
    }
}
