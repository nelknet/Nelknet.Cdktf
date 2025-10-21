using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapVolume
{
    [JsiiInterface(nativeType: typeof(IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention), fullyQualifiedName: "aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention")]
    public interface IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#type FsxOntapVolume#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#value FsxOntapVolume#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention), fullyQualifiedName: "aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention")]
        internal sealed class _Proxy : DeputyBase, aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#type FsxOntapVolume#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#value FsxOntapVolume#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Value
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
