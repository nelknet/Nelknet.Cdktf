using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainAutoTuneOptionsMaintenanceSchedule")]
    public class OpensearchDomainAutoTuneOptionsMaintenanceSchedule : aws.OpensearchDomain.IOpensearchDomainAutoTuneOptionsMaintenanceSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cron_expression_for_recurrence OpensearchDomain#cron_expression_for_recurrence}.</summary>
        [JsiiProperty(name: "cronExpressionForRecurrence", typeJson: "{\"primitive\":\"string\"}")]
        public string CronExpressionForRecurrence
        {
            get;
            set;
        }

        /// <summary>duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#duration OpensearchDomain#duration}
        /// </remarks>
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAutoTuneOptionsMaintenanceScheduleDuration\"}")]
        public aws.OpensearchDomain.IOpensearchDomainAutoTuneOptionsMaintenanceScheduleDuration Duration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#start_at OpensearchDomain#start_at}.</summary>
        [JsiiProperty(name: "startAt", typeJson: "{\"primitive\":\"string\"}")]
        public string StartAt
        {
            get;
            set;
        }
    }
}
