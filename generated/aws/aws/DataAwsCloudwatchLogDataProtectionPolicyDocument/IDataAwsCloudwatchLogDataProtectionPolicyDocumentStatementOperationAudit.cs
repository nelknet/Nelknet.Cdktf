using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCloudwatchLogDataProtectionPolicyDocument
{
    [JsiiInterface(nativeType: typeof(IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit), fullyQualifiedName: "aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit")]
    public interface IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit
    {
        /// <summary>findings_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#findings_destination DataAwsCloudwatchLogDataProtectionPolicyDocument#findings_destination}
        /// </remarks>
        [JsiiProperty(name: "findingsDestination", typeJson: "{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAuditFindingsDestination\"}")]
        aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAuditFindingsDestination FindingsDestination
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit), fullyQualifiedName: "aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>findings_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#findings_destination DataAwsCloudwatchLogDataProtectionPolicyDocument#findings_destination}
            /// </remarks>
            [JsiiProperty(name: "findingsDestination", typeJson: "{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAuditFindingsDestination\"}")]
            public aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAuditFindingsDestination FindingsDestination
            {
                get => GetInstanceProperty<aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAuditFindingsDestination>()!;
            }
        }
    }
}
