using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyDetector
{
    [JsiiClass(nativeType: typeof(aws.GuarddutyDetector.GuarddutyDetectorDatasourcesOutputReference), fullyQualifiedName: "aws.guarddutyDetector.GuarddutyDetectorDatasourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GuarddutyDetectorDatasourcesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GuarddutyDetectorDatasourcesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GuarddutyDetectorDatasourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyDetectorDatasourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKubernetes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetes\"}}]")]
        public virtual void PutKubernetes(aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMalwareProtection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesMalwareProtection\"}}]")]
        public virtual void PutMalwareProtection(aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesMalwareProtection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesMalwareProtection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Logs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesS3Logs\"}}]")]
        public virtual void PutS3Logs(aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesS3Logs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesS3Logs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKubernetes")]
        public virtual void ResetKubernetes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMalwareProtection")]
        public virtual void ResetMalwareProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Logs")]
        public virtual void ResetS3Logs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "kubernetes", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetesOutputReference\"}")]
        public virtual aws.GuarddutyDetector.GuarddutyDetectorDatasourcesKubernetesOutputReference Kubernetes
        {
            get => GetInstanceProperty<aws.GuarddutyDetector.GuarddutyDetectorDatasourcesKubernetesOutputReference>()!;
        }

        [JsiiProperty(name: "malwareProtection", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesMalwareProtectionOutputReference\"}")]
        public virtual aws.GuarddutyDetector.GuarddutyDetectorDatasourcesMalwareProtectionOutputReference MalwareProtection
        {
            get => GetInstanceProperty<aws.GuarddutyDetector.GuarddutyDetectorDatasourcesMalwareProtectionOutputReference>()!;
        }

        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesS3LogsOutputReference\"}")]
        public virtual aws.GuarddutyDetector.GuarddutyDetectorDatasourcesS3LogsOutputReference S3Logs
        {
            get => GetInstanceProperty<aws.GuarddutyDetector.GuarddutyDetectorDatasourcesS3LogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubernetesInput", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetes\"}", isOptional: true)]
        public virtual aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetes? KubernetesInput
        {
            get => GetInstanceProperty<aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "malwareProtectionInput", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesMalwareProtection\"}", isOptional: true)]
        public virtual aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesMalwareProtection? MalwareProtectionInput
        {
            get => GetInstanceProperty<aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesMalwareProtection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3LogsInput", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesS3Logs\"}", isOptional: true)]
        public virtual aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesS3Logs? S3LogsInput
        {
            get => GetInstanceProperty<aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesS3Logs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasources\"}", isOptional: true)]
        public virtual aws.GuarddutyDetector.IGuarddutyDetectorDatasources? InternalValue
        {
            get => GetInstanceProperty<aws.GuarddutyDetector.IGuarddutyDetectorDatasources?>();
            set => SetInstanceProperty(value);
        }
    }
}
