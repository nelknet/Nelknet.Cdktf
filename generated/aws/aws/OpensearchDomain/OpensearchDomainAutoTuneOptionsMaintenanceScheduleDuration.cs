using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainAutoTuneOptionsMaintenanceScheduleDuration")]
    public class OpensearchDomainAutoTuneOptionsMaintenanceScheduleDuration : aws.OpensearchDomain.IOpensearchDomainAutoTuneOptionsMaintenanceScheduleDuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#unit OpensearchDomain#unit}.</summary>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        public string Unit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#value OpensearchDomain#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }
    }
}
