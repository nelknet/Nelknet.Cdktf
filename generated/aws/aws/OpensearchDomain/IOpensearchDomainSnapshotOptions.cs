using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainSnapshotOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainSnapshotOptions")]
    public interface IOpensearchDomainSnapshotOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#automated_snapshot_start_hour OpensearchDomain#automated_snapshot_start_hour}.</summary>
        [JsiiProperty(name: "automatedSnapshotStartHour", typeJson: "{\"primitive\":\"number\"}")]
        double AutomatedSnapshotStartHour
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainSnapshotOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainSnapshotOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainSnapshotOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#automated_snapshot_start_hour OpensearchDomain#automated_snapshot_start_hour}.</summary>
            [JsiiProperty(name: "automatedSnapshotStartHour", typeJson: "{\"primitive\":\"number\"}")]
            public double AutomatedSnapshotStartHour
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
