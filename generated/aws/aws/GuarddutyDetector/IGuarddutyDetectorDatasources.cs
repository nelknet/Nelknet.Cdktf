using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyDetector
{
    [JsiiInterface(nativeType: typeof(IGuarddutyDetectorDatasources), fullyQualifiedName: "aws.guarddutyDetector.GuarddutyDetectorDatasources")]
    public interface IGuarddutyDetectorDatasources
    {
        /// <summary>kubernetes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#kubernetes GuarddutyDetector#kubernetes}
        /// </remarks>
        [JsiiProperty(name: "kubernetes", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetes\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetes? Kubernetes
        {
            get
            {
                return null;
            }
        }

        /// <summary>malware_protection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#malware_protection GuarddutyDetector#malware_protection}
        /// </remarks>
        [JsiiProperty(name: "malwareProtection", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesMalwareProtection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesMalwareProtection? MalwareProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#s3_logs GuarddutyDetector#s3_logs}
        /// </remarks>
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesS3Logs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesS3Logs? S3Logs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyDetectorDatasources), fullyQualifiedName: "aws.guarddutyDetector.GuarddutyDetectorDatasources")]
        internal sealed class _Proxy : DeputyBase, aws.GuarddutyDetector.IGuarddutyDetectorDatasources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kubernetes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#kubernetes GuarddutyDetector#kubernetes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kubernetes", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetes\"}", isOptional: true)]
            public aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetes? Kubernetes
            {
                get => GetInstanceProperty<aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetes?>();
            }

            /// <summary>malware_protection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#malware_protection GuarddutyDetector#malware_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "malwareProtection", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesMalwareProtection\"}", isOptional: true)]
            public aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesMalwareProtection? MalwareProtection
            {
                get => GetInstanceProperty<aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesMalwareProtection?>();
            }

            /// <summary>s3_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#s3_logs GuarddutyDetector#s3_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesS3Logs\"}", isOptional: true)]
            public aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesS3Logs? S3Logs
            {
                get => GetInstanceProperty<aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesS3Logs?>();
            }
        }
    }
}
