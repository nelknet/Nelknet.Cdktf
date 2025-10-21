using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCloudwatchLogDataProtectionPolicyDocument
{
    [JsiiByValue(fqn: "aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperation")]
    public class DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperation : aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperation
    {
        /// <summary>audit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#audit DataAwsCloudwatchLogDataProtectionPolicyDocument#audit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audit", typeJson: "{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit\"}", isOptional: true)]
        public aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationAudit? Audit
        {
            get;
            set;
        }

        /// <summary>deidentify block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_data_protection_policy_document#deidentify DataAwsCloudwatchLogDataProtectionPolicyDocument#deidentify}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deidentify", typeJson: "{\"fqn\":\"aws.dataAwsCloudwatchLogDataProtectionPolicyDocument.DataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationDeidentify\"}", isOptional: true)]
        public aws.DataAwsCloudwatchLogDataProtectionPolicyDocument.IDataAwsCloudwatchLogDataProtectionPolicyDocumentStatementOperationDeidentify? Deidentify
        {
            get;
            set;
        }
    }
}
