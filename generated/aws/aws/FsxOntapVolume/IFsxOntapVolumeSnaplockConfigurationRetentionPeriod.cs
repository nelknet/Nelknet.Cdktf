using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapVolume
{
    [JsiiInterface(nativeType: typeof(IFsxOntapVolumeSnaplockConfigurationRetentionPeriod), fullyQualifiedName: "aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriod")]
    public interface IFsxOntapVolumeSnaplockConfigurationRetentionPeriod
    {
        /// <summary>default_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#default_retention FsxOntapVolume#default_retention}
        /// </remarks>
        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention? DefaultRetention
        {
            get
            {
                return null;
            }
        }

        /// <summary>maximum_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#maximum_retention FsxOntapVolume#maximum_retention}
        /// </remarks>
        [JsiiProperty(name: "maximumRetention", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention? MaximumRetention
        {
            get
            {
                return null;
            }
        }

        /// <summary>minimum_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#minimum_retention FsxOntapVolume#minimum_retention}
        /// </remarks>
        [JsiiProperty(name: "minimumRetention", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention? MinimumRetention
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOntapVolumeSnaplockConfigurationRetentionPeriod), fullyQualifiedName: "aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriod")]
        internal sealed class _Proxy : DeputyBase, aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_retention block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#default_retention FsxOntapVolume#default_retention}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention\"}", isOptional: true)]
            public aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention? DefaultRetention
            {
                get => GetInstanceProperty<aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention?>();
            }

            /// <summary>maximum_retention block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#maximum_retention FsxOntapVolume#maximum_retention}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumRetention", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention\"}", isOptional: true)]
            public aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention? MaximumRetention
            {
                get => GetInstanceProperty<aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention?>();
            }

            /// <summary>minimum_retention block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#minimum_retention FsxOntapVolume#minimum_retention}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumRetention", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention\"}", isOptional: true)]
            public aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention? MinimumRetention
            {
                get => GetInstanceProperty<aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention?>();
            }
        }
    }
}
