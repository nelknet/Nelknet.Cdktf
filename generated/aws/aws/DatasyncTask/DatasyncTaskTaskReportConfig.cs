using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasyncTask.DatasyncTaskTaskReportConfig")]
    public class DatasyncTaskTaskReportConfig : aws.DatasyncTask.IDatasyncTaskTaskReportConfig
    {
        /// <summary>s3_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#s3_destination DatasyncTask#s3_destination}
        /// </remarks>
        [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigS3Destination\"}")]
        public aws.DatasyncTask.IDatasyncTaskTaskReportConfigS3Destination S3Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#output_type DatasyncTask#output_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#report_level DatasyncTask#report_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reportLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReportLevel
        {
            get;
            set;
        }

        /// <summary>report_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#report_overrides DatasyncTask#report_overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reportOverrides", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigReportOverrides\"}", isOptional: true)]
        public aws.DatasyncTask.IDatasyncTaskTaskReportConfigReportOverrides? ReportOverrides
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#s3_object_versioning DatasyncTask#s3_object_versioning}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3ObjectVersioning", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3ObjectVersioning
        {
            get;
            set;
        }
    }
}
