using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapVolume
{
    [JsiiByValue(fqn: "aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriod")]
    public class FsxOntapVolumeSnaplockConfigurationRetentionPeriod : aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriod
    {
        /// <summary>default_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#default_retention FsxOntapVolume#default_retention}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention\"}", isOptional: true)]
        public aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention? DefaultRetention
        {
            get;
            set;
        }

        /// <summary>maximum_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#maximum_retention FsxOntapVolume#maximum_retention}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximumRetention", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention\"}", isOptional: true)]
        public aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention? MaximumRetention
        {
            get;
            set;
        }

        /// <summary>minimum_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#minimum_retention FsxOntapVolume#minimum_retention}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimumRetention", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention\"}", isOptional: true)]
        public aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention? MinimumRetention
        {
            get;
            set;
        }
    }
}
