using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptions")]
    public class ElasticsearchDomainAutoTuneOptions : aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#desired_state ElasticsearchDomain#desired_state}.</summary>
        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
        public string DesiredState
        {
            get;
            set;
        }

        private object? _maintenanceSchedule;

        /// <summary>maintenance_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#maintenance_schedule ElasticsearchDomain#maintenance_schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceSchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MaintenanceSchedule
        {
            get => _maintenanceSchedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptionsMaintenanceSchedule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _maintenanceSchedule = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#rollback_on_disable ElasticsearchDomain#rollback_on_disable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rollbackOnDisable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RollbackOnDisable
        {
            get;
            set;
        }
    }
}
