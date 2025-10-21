using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmincidentsResponsePlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplate")]
    public class SsmincidentsResponsePlanIncidentTemplate : aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIncidentTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#impact SsmincidentsResponsePlan#impact}.</summary>
        [JsiiProperty(name: "impact", typeJson: "{\"primitive\":\"number\"}")]
        public double Impact
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#title SsmincidentsResponsePlan#title}.</summary>
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public string Title
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#dedupe_string SsmincidentsResponsePlan#dedupe_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dedupeString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DedupeString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#incident_tags SsmincidentsResponsePlan#incident_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "incidentTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? IncidentTags
        {
            get;
            set;
        }

        private object? _notificationTarget;

        /// <summary>notification_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#notification_target SsmincidentsResponsePlan#notification_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notificationTarget", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplateNotificationTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NotificationTarget
        {
            get => _notificationTarget;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIncidentTemplateNotificationTarget[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIncidentTemplateNotificationTarget).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _notificationTarget = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#summary SsmincidentsResponsePlan#summary}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "summary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Summary
        {
            get;
            set;
        }
    }
}
