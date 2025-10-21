using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerAssessment
{
    [JsiiInterface(nativeType: typeof(IAuditmanagerAssessmentScope), fullyQualifiedName: "aws.auditmanagerAssessment.AuditmanagerAssessmentScope")]
    public interface IAuditmanagerAssessmentScope
    {
        /// <summary>aws_accounts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#aws_accounts AuditmanagerAssessment#aws_accounts}
        /// </remarks>
        [JsiiProperty(name: "awsAccounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.auditmanagerAssessment.AuditmanagerAssessmentScopeAwsAccounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsAccounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>aws_services block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#aws_services AuditmanagerAssessment#aws_services}
        /// </remarks>
        [JsiiProperty(name: "awsServices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.auditmanagerAssessment.AuditmanagerAssessmentScopeAwsServices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsServices
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAuditmanagerAssessmentScope), fullyQualifiedName: "aws.auditmanagerAssessment.AuditmanagerAssessmentScope")]
        internal sealed class _Proxy : DeputyBase, aws.AuditmanagerAssessment.IAuditmanagerAssessmentScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_accounts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#aws_accounts AuditmanagerAssessment#aws_accounts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsAccounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.auditmanagerAssessment.AuditmanagerAssessmentScopeAwsAccounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsAccounts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>aws_services block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#aws_services AuditmanagerAssessment#aws_services}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsServices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.auditmanagerAssessment.AuditmanagerAssessmentScopeAwsServices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsServices
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
