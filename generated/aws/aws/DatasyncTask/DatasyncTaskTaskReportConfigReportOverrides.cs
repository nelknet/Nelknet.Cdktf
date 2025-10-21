using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncTask
{
    [JsiiByValue(fqn: "aws.datasyncTask.DatasyncTaskTaskReportConfigReportOverrides")]
    public class DatasyncTaskTaskReportConfigReportOverrides : aws.DatasyncTask.IDatasyncTaskTaskReportConfigReportOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#deleted_override DatasyncTask#deleted_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deletedOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeletedOverride
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#skipped_override DatasyncTask#skipped_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skippedOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SkippedOverride
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#transferred_override DatasyncTask#transferred_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transferredOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransferredOverride
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#verified_override DatasyncTask#verified_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifiedOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VerifiedOverride
        {
            get;
            set;
        }
    }
}
