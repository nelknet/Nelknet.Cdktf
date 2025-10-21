using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapVolume
{
    [JsiiByValue(fqn: "aws.fsxOntapVolume.FsxOntapVolumeAggregateConfiguration")]
    public class FsxOntapVolumeAggregateConfiguration : aws.FsxOntapVolume.IFsxOntapVolumeAggregateConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#aggregates FsxOntapVolume#aggregates}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aggregates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Aggregates
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#constituents_per_aggregate FsxOntapVolume#constituents_per_aggregate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "constituentsPerAggregate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConstituentsPerAggregate
        {
            get;
            set;
        }
    }
}
