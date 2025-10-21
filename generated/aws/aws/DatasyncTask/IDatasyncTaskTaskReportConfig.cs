using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncTask
{
    [JsiiInterface(nativeType: typeof(IDatasyncTaskTaskReportConfig), fullyQualifiedName: "aws.datasyncTask.DatasyncTaskTaskReportConfig")]
    public interface IDatasyncTaskTaskReportConfig
    {
        /// <summary>s3_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#s3_destination DatasyncTask#s3_destination}
        /// </remarks>
        [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigS3Destination\"}")]
        aws.DatasyncTask.IDatasyncTaskTaskReportConfigS3Destination S3Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#output_type DatasyncTask#output_type}.</summary>
        [JsiiProperty(name: "outputType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#report_level DatasyncTask#report_level}.</summary>
        [JsiiProperty(name: "reportLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReportLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>report_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#report_overrides DatasyncTask#report_overrides}
        /// </remarks>
        [JsiiProperty(name: "reportOverrides", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigReportOverrides\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DatasyncTask.IDatasyncTaskTaskReportConfigReportOverrides? ReportOverrides
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#s3_object_versioning DatasyncTask#s3_object_versioning}.</summary>
        [JsiiProperty(name: "s3ObjectVersioning", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3ObjectVersioning
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncTaskTaskReportConfig), fullyQualifiedName: "aws.datasyncTask.DatasyncTaskTaskReportConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncTask.IDatasyncTaskTaskReportConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#s3_destination DatasyncTask#s3_destination}
            /// </remarks>
            [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigS3Destination\"}")]
            public aws.DatasyncTask.IDatasyncTaskTaskReportConfigS3Destination S3Destination
            {
                get => GetInstanceProperty<aws.DatasyncTask.IDatasyncTaskTaskReportConfigS3Destination>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#output_type DatasyncTask#output_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#report_level DatasyncTask#report_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reportLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReportLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>report_overrides block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#report_overrides DatasyncTask#report_overrides}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reportOverrides", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigReportOverrides\"}", isOptional: true)]
            public aws.DatasyncTask.IDatasyncTaskTaskReportConfigReportOverrides? ReportOverrides
            {
                get => GetInstanceProperty<aws.DatasyncTask.IDatasyncTaskTaskReportConfigReportOverrides?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#s3_object_versioning DatasyncTask#s3_object_versioning}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3ObjectVersioning", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3ObjectVersioning
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
