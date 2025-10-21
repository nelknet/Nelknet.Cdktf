using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxWindowsFileSystem
{
    [JsiiInterface(nativeType: typeof(IFsxWindowsFileSystemAuditLogConfiguration), fullyQualifiedName: "aws.fsxWindowsFileSystem.FsxWindowsFileSystemAuditLogConfiguration")]
    public interface IFsxWindowsFileSystemAuditLogConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#audit_log_destination FsxWindowsFileSystem#audit_log_destination}.</summary>
        [JsiiProperty(name: "auditLogDestination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuditLogDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#file_access_audit_log_level FsxWindowsFileSystem#file_access_audit_log_level}.</summary>
        [JsiiProperty(name: "fileAccessAuditLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileAccessAuditLogLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#file_share_access_audit_log_level FsxWindowsFileSystem#file_share_access_audit_log_level}.</summary>
        [JsiiProperty(name: "fileShareAccessAuditLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileShareAccessAuditLogLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxWindowsFileSystemAuditLogConfiguration), fullyQualifiedName: "aws.fsxWindowsFileSystem.FsxWindowsFileSystemAuditLogConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FsxWindowsFileSystem.IFsxWindowsFileSystemAuditLogConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#audit_log_destination FsxWindowsFileSystem#audit_log_destination}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "auditLogDestination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuditLogDestination
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#file_access_audit_log_level FsxWindowsFileSystem#file_access_audit_log_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileAccessAuditLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileAccessAuditLogLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#file_share_access_audit_log_level FsxWindowsFileSystem#file_share_access_audit_log_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileShareAccessAuditLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileShareAccessAuditLogLevel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
