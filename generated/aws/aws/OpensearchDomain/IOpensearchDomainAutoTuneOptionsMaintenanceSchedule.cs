using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainAutoTuneOptionsMaintenanceSchedule), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAutoTuneOptionsMaintenanceSchedule")]
    public interface IOpensearchDomainAutoTuneOptionsMaintenanceSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cron_expression_for_recurrence OpensearchDomain#cron_expression_for_recurrence}.</summary>
        [JsiiProperty(name: "cronExpressionForRecurrence", typeJson: "{\"primitive\":\"string\"}")]
        string CronExpressionForRecurrence
        {
            get;
        }

        /// <summary>duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#duration OpensearchDomain#duration}
        /// </remarks>
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAutoTuneOptionsMaintenanceScheduleDuration\"}")]
        aws.OpensearchDomain.IOpensearchDomainAutoTuneOptionsMaintenanceScheduleDuration Duration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#start_at OpensearchDomain#start_at}.</summary>
        [JsiiProperty(name: "startAt", typeJson: "{\"primitive\":\"string\"}")]
        string StartAt
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainAutoTuneOptionsMaintenanceSchedule), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAutoTuneOptionsMaintenanceSchedule")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainAutoTuneOptionsMaintenanceSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#cron_expression_for_recurrence OpensearchDomain#cron_expression_for_recurrence}.</summary>
            [JsiiProperty(name: "cronExpressionForRecurrence", typeJson: "{\"primitive\":\"string\"}")]
            public string CronExpressionForRecurrence
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>duration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#duration OpensearchDomain#duration}
            /// </remarks>
            [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAutoTuneOptionsMaintenanceScheduleDuration\"}")]
            public aws.OpensearchDomain.IOpensearchDomainAutoTuneOptionsMaintenanceScheduleDuration Duration
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainAutoTuneOptionsMaintenanceScheduleDuration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#start_at OpensearchDomain#start_at}.</summary>
            [JsiiProperty(name: "startAt", typeJson: "{\"primitive\":\"string\"}")]
            public string StartAt
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
