using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapVolume
{
    [JsiiInterface(nativeType: typeof(IFsxOntapVolumeTieringPolicy), fullyQualifiedName: "aws.fsxOntapVolume.FsxOntapVolumeTieringPolicy")]
    public interface IFsxOntapVolumeTieringPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#cooling_period FsxOntapVolume#cooling_period}.</summary>
        [JsiiProperty(name: "coolingPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CoolingPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#name FsxOntapVolume#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOntapVolumeTieringPolicy), fullyQualifiedName: "aws.fsxOntapVolume.FsxOntapVolumeTieringPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.FsxOntapVolume.IFsxOntapVolumeTieringPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#cooling_period FsxOntapVolume#cooling_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "coolingPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CoolingPeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#name FsxOntapVolume#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
