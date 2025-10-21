using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyDetector
{
    [JsiiClass(nativeType: typeof(aws.GuarddutyDetector.GuarddutyDetectorDatasourcesKubernetesOutputReference), fullyQualifiedName: "aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GuarddutyDetectorDatasourcesKubernetesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GuarddutyDetectorDatasourcesKubernetesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GuarddutyDetectorDatasourcesKubernetesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyDetectorDatasourcesKubernetesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuditLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetesAuditLogs\"}}]")]
        public virtual void PutAuditLogs(aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetesAuditLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetesAuditLogs)}, new object[]{@value});
        }

        [JsiiProperty(name: "auditLogs", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetesAuditLogsOutputReference\"}")]
        public virtual aws.GuarddutyDetector.GuarddutyDetectorDatasourcesKubernetesAuditLogsOutputReference AuditLogs
        {
            get => GetInstanceProperty<aws.GuarddutyDetector.GuarddutyDetectorDatasourcesKubernetesAuditLogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditLogsInput", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetesAuditLogs\"}", isOptional: true)]
        public virtual aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetesAuditLogs? AuditLogsInput
        {
            get => GetInstanceProperty<aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetesAuditLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetes\"}", isOptional: true)]
        public virtual aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetes? InternalValue
        {
            get => GetInstanceProperty<aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetes?>();
            set => SetInstanceProperty(value);
        }
    }
}
