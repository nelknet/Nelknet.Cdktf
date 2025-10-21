using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncTask
{
    [JsiiInterface(nativeType: typeof(IDatasyncTaskTaskReportConfigReportOverrides), fullyQualifiedName: "aws.datasyncTask.DatasyncTaskTaskReportConfigReportOverrides")]
    public interface IDatasyncTaskTaskReportConfigReportOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#deleted_override DatasyncTask#deleted_override}.</summary>
        [JsiiProperty(name: "deletedOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeletedOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#skipped_override DatasyncTask#skipped_override}.</summary>
        [JsiiProperty(name: "skippedOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SkippedOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#transferred_override DatasyncTask#transferred_override}.</summary>
        [JsiiProperty(name: "transferredOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransferredOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#verified_override DatasyncTask#verified_override}.</summary>
        [JsiiProperty(name: "verifiedOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerifiedOverride
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncTaskTaskReportConfigReportOverrides), fullyQualifiedName: "aws.datasyncTask.DatasyncTaskTaskReportConfigReportOverrides")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncTask.IDatasyncTaskTaskReportConfigReportOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#deleted_override DatasyncTask#deleted_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deletedOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeletedOverride
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#skipped_override DatasyncTask#skipped_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skippedOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SkippedOverride
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#transferred_override DatasyncTask#transferred_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transferredOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransferredOverride
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#verified_override DatasyncTask#verified_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifiedOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerifiedOverride
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
