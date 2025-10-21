using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule")]
    public class ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule : aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#cron_expression_for_recurrence ElasticsearchDomain#cron_expression_for_recurrence}.</summary>
        [JsiiProperty(name: "cronExpressionForRecurrence", typeJson: "{\"primitive\":\"string\"}")]
        public string CronExpressionForRecurrence
        {
            get;
            set;
        }

        /// <summary>duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#duration ElasticsearchDomain#duration}
        /// </remarks>
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptionsMaintenanceScheduleDuration\"}")]
        public aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptionsMaintenanceScheduleDuration Duration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#start_at ElasticsearchDomain#start_at}.</summary>
        [JsiiProperty(name: "startAt", typeJson: "{\"primitive\":\"string\"}")]
        public string StartAt
        {
            get;
            set;
        }
    }
}
