using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainSnapshotOptions")]
    public class OpensearchDomainSnapshotOptions : aws.OpensearchDomain.IOpensearchDomainSnapshotOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#automated_snapshot_start_hour OpensearchDomain#automated_snapshot_start_hour}.</summary>
        [JsiiProperty(name: "automatedSnapshotStartHour", typeJson: "{\"primitive\":\"number\"}")]
        public double AutomatedSnapshotStartHour
        {
            get;
            set;
        }
    }
}
