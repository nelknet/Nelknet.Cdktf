using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyDetector
{
    [JsiiInterface(nativeType: typeof(IGuarddutyDetectorDatasourcesKubernetes), fullyQualifiedName: "aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetes")]
    public interface IGuarddutyDetectorDatasourcesKubernetes
    {
        /// <summary>audit_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#audit_logs GuarddutyDetector#audit_logs}
        /// </remarks>
        [JsiiProperty(name: "auditLogs", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetesAuditLogs\"}")]
        aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetesAuditLogs AuditLogs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyDetectorDatasourcesKubernetes), fullyQualifiedName: "aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetes")]
        internal sealed class _Proxy : DeputyBase, aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>audit_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#audit_logs GuarddutyDetector#audit_logs}
            /// </remarks>
            [JsiiProperty(name: "auditLogs", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetesAuditLogs\"}")]
            public aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetesAuditLogs AuditLogs
            {
                get => GetInstanceProperty<aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetesAuditLogs>()!;
            }
        }
    }
}
