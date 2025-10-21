using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerAssessment
{
    [JsiiByValue(fqn: "aws.auditmanagerAssessment.AuditmanagerAssessmentScope")]
    public class AuditmanagerAssessmentScope : aws.AuditmanagerAssessment.IAuditmanagerAssessmentScope
    {
        private object? _awsAccounts;

        /// <summary>aws_accounts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#aws_accounts AuditmanagerAssessment#aws_accounts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsAccounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.auditmanagerAssessment.AuditmanagerAssessmentScopeAwsAccounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AwsAccounts
        {
            get => _awsAccounts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AuditmanagerAssessment.IAuditmanagerAssessmentScopeAwsAccounts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AuditmanagerAssessment.IAuditmanagerAssessmentScopeAwsAccounts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsAccounts = value;
            }
        }

        private object? _awsServices;

        /// <summary>aws_services block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#aws_services AuditmanagerAssessment#aws_services}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsServices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.auditmanagerAssessment.AuditmanagerAssessmentScopeAwsServices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AwsServices
        {
            get => _awsServices;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AuditmanagerAssessment.IAuditmanagerAssessmentScopeAwsServices[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AuditmanagerAssessment.IAuditmanagerAssessmentScopeAwsServices).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsServices = value;
            }
        }
    }
}
