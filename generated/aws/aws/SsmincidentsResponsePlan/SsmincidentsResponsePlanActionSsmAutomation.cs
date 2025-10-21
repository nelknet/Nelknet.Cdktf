using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmincidentsResponsePlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanActionSsmAutomation")]
    public class SsmincidentsResponsePlanActionSsmAutomation : aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanActionSsmAutomation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#document_name SsmincidentsResponsePlan#document_name}.</summary>
        [JsiiProperty(name: "documentName", typeJson: "{\"primitive\":\"string\"}")]
        public string DocumentName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#role_arn SsmincidentsResponsePlan#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#document_version SsmincidentsResponsePlan#document_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DocumentVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#dynamic_parameters SsmincidentsResponsePlan#dynamic_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamicParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DynamicParameters
        {
            get;
            set;
        }

        private object? _parameter;

        /// <summary>parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#parameter SsmincidentsResponsePlan#parameter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanActionSsmAutomationParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Parameter
        {
            get => _parameter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanActionSsmAutomationParameter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanActionSsmAutomationParameter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parameter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#target_account SsmincidentsResponsePlan#target_account}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetAccount
        {
            get;
            set;
        }
    }
}
