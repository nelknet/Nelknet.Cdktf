using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyDetector
{
    [JsiiByValue(fqn: "aws.guarddutyDetector.GuarddutyDetectorDatasources")]
    public class GuarddutyDetectorDatasources : aws.GuarddutyDetector.IGuarddutyDetectorDatasources
    {
        /// <summary>kubernetes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#kubernetes GuarddutyDetector#kubernetes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kubernetes", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesKubernetes\"}", isOptional: true)]
        public aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesKubernetes? Kubernetes
        {
            get;
            set;
        }

        /// <summary>malware_protection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#malware_protection GuarddutyDetector#malware_protection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "malwareProtection", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesMalwareProtection\"}", isOptional: true)]
        public aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesMalwareProtection? MalwareProtection
        {
            get;
            set;
        }

        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#s3_logs GuarddutyDetector#s3_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guarddutyDetector.GuarddutyDetectorDatasourcesS3Logs\"}", isOptional: true)]
        public aws.GuarddutyDetector.IGuarddutyDetectorDatasourcesS3Logs? S3Logs
        {
            get;
            set;
        }
    }
}
