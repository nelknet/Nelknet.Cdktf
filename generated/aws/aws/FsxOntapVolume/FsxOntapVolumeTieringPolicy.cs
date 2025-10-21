using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapVolume
{
    [JsiiByValue(fqn: "aws.fsxOntapVolume.FsxOntapVolumeTieringPolicy")]
    public class FsxOntapVolumeTieringPolicy : aws.FsxOntapVolume.IFsxOntapVolumeTieringPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#cooling_period FsxOntapVolume#cooling_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coolingPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoolingPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#name FsxOntapVolume#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
