using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapVolume
{
    [JsiiInterface(nativeType: typeof(IFsxOntapVolumeAggregateConfiguration), fullyQualifiedName: "aws.fsxOntapVolume.FsxOntapVolumeAggregateConfiguration")]
    public interface IFsxOntapVolumeAggregateConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#aggregates FsxOntapVolume#aggregates}.</summary>
        [JsiiProperty(name: "aggregates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Aggregates
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#constituents_per_aggregate FsxOntapVolume#constituents_per_aggregate}.</summary>
        [JsiiProperty(name: "constituentsPerAggregate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConstituentsPerAggregate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOntapVolumeAggregateConfiguration), fullyQualifiedName: "aws.fsxOntapVolume.FsxOntapVolumeAggregateConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FsxOntapVolume.IFsxOntapVolumeAggregateConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#aggregates FsxOntapVolume#aggregates}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "aggregates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Aggregates
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#constituents_per_aggregate FsxOntapVolume#constituents_per_aggregate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "constituentsPerAggregate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConstituentsPerAggregate
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
