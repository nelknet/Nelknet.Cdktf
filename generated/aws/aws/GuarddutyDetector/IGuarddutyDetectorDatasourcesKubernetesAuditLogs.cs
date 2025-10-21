using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyDetector
{
    [JsiiInterface(nativeType: typeof(IGuarddutyDetectorDatasourcesKubernetesAuditLogs), fullyQualifiedName: "aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetesAuditLogs")]
    public interface IGuarddutyDetectorDatasourcesKubernetesAuditLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#enable GuarddutyDetector#enable}.</summary>
        [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enable
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyDetectorDatasourcesKubernetesAuditLogs), fullyQualifiedName: "aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetesAuditLogs")]
        internal sealed class _Proxy : DeputyBase, aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetesAuditLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#enable GuarddutyDetector#enable}.</summary>
            [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enable
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
