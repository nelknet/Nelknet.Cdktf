using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainSnapshotOptions), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainSnapshotOptions")]
    public interface IElasticsearchDomainSnapshotOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#automated_snapshot_start_hour ElasticsearchDomain#automated_snapshot_start_hour}.</summary>
        [JsiiProperty(name: "automatedSnapshotStartHour", typeJson: "{\"primitive\":\"number\"}")]
        double AutomatedSnapshotStartHour
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainSnapshotOptions), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomainSnapshotOptions")]
        internal sealed class _Proxy : DeputyBase, aws.ElasticsearchDomain.IElasticsearchDomainSnapshotOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#automated_snapshot_start_hour ElasticsearchDomain#automated_snapshot_start_hour}.</summary>
            [JsiiProperty(name: "automatedSnapshotStartHour", typeJson: "{\"primitive\":\"number\"}")]
            public double AutomatedSnapshotStartHour
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
