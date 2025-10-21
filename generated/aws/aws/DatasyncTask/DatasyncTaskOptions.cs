using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncTask
{
    [JsiiByValue(fqn: "aws.datasyncTask.DatasyncTaskOptions")]
    public class DatasyncTaskOptions : aws.DatasyncTask.IDatasyncTaskOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#atime DatasyncTask#atime}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Atime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#bytes_per_second DatasyncTask#bytes_per_second}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bytesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BytesPerSecond
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#gid DatasyncTask#gid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Gid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#log_level DatasyncTask#log_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#mtime DatasyncTask#mtime}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mtime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#object_tags DatasyncTask#object_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#overwrite_mode DatasyncTask#overwrite_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "overwriteMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OverwriteMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#posix_permissions DatasyncTask#posix_permissions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "posixPermissions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PosixPermissions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#preserve_deleted_files DatasyncTask#preserve_deleted_files}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preserveDeletedFiles", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreserveDeletedFiles
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#preserve_devices DatasyncTask#preserve_devices}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preserveDevices", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreserveDevices
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#security_descriptor_copy_flags DatasyncTask#security_descriptor_copy_flags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityDescriptorCopyFlags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityDescriptorCopyFlags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#task_queueing DatasyncTask#task_queueing}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskQueueing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaskQueueing
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#transfer_mode DatasyncTask#transfer_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transferMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransferMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#uid DatasyncTask#uid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#verify_mode DatasyncTask#verify_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VerifyMode
        {
            get;
            set;
        }
    }
}
