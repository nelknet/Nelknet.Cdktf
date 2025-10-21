using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule")]
    public interface IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#cron_expression_for_recurrence ElasticsearchDomain#cron_expression_for_recurrence}.</summary>
        [JsiiProperty(name: "cronExpressionForRecurrence", typeJson: "{\"primitive\":\"string\"}")]
        string CronExpressionForRecurrence
        {
            get;
        }

        /// <summary>duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#duration ElasticsearchDomain#duration}
        /// </remarks>
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptionsMaintenanceScheduleDuration\"}")]
        aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptionsMaintenanceScheduleDuration Duration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#start_at ElasticsearchDomain#start_at}.</summary>
        [JsiiProperty(name: "startAt", typeJson: "{\"primitive\":\"string\"}")]
        string StartAt
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule")]
        internal sealed class _Proxy : DeputyBase, aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#cron_expression_for_recurrence ElasticsearchDomain#cron_expression_for_recurrence}.</summary>
            [JsiiProperty(name: "cronExpressionForRecurrence", typeJson: "{\"primitive\":\"string\"}")]
            public string CronExpressionForRecurrence
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>duration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#duration ElasticsearchDomain#duration}
            /// </remarks>
            [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptionsMaintenanceScheduleDuration\"}")]
            public aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptionsMaintenanceScheduleDuration Duration
            {
                get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptionsMaintenanceScheduleDuration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#start_at ElasticsearchDomain#start_at}.</summary>
            [JsiiProperty(name: "startAt", typeJson: "{\"primitive\":\"string\"}")]
            public string StartAt
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
