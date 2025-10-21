using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainAutoTuneOptions), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptions")]
    public interface IElasticsearchDomainAutoTuneOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#desired_state ElasticsearchDomain#desired_state}.</summary>
        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
        string DesiredState
        {
            get;
        }

        /// <summary>maintenance_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#maintenance_schedule ElasticsearchDomain#maintenance_schedule}
        /// </remarks>
        [JsiiProperty(name: "maintenanceSchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MaintenanceSchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#rollback_on_disable ElasticsearchDomain#rollback_on_disable}.</summary>
        [JsiiProperty(name: "rollbackOnDisable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RollbackOnDisable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainAutoTuneOptions), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptions")]
        internal sealed class _Proxy : DeputyBase, aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#desired_state ElasticsearchDomain#desired_state}.</summary>
            [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
            public string DesiredState
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>maintenance_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#maintenance_schedule ElasticsearchDomain#maintenance_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceSchedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptionsMaintenanceSchedule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MaintenanceSchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#rollback_on_disable ElasticsearchDomain#rollback_on_disable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rollbackOnDisable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RollbackOnDisable
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
