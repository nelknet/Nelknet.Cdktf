using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustOutputReference), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm\"}}]")]
        public virtual void PutAcm(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFile\"}}]")]
        public virtual void PutFile(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSds", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSds\"}}]")]
        public virtual void PutSds(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSds @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSds)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcm")]
        public virtual void ResetAcm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFile")]
        public virtual void ResetFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSds")]
        public virtual void ResetSds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acm", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcmOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcmOutputReference Acm
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcmOutputReference>()!;
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFileOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFileOutputReference File
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFileOutputReference>()!;
        }

        [JsiiProperty(name: "sds", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSdsOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSdsOutputReference Sds
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSdsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acmInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm? AcmInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustAcm?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFile\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFile? FileInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustFile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sdsInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSds\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSds? SdsInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrustSds?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrust\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrust? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationTrust?>();
            set => SetInstanceProperty(value);
        }
    }
}
