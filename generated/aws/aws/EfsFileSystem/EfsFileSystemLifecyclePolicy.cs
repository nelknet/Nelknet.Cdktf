using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsFileSystem
{
    [JsiiByValue(fqn: "aws.efsFileSystem.EfsFileSystemLifecyclePolicy")]
    public class EfsFileSystemLifecyclePolicy : aws.EfsFileSystem.IEfsFileSystemLifecyclePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#transition_to_archive EfsFileSystem#transition_to_archive}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitionToArchive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransitionToArchive
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#transition_to_ia EfsFileSystem#transition_to_ia}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransitionToIa
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#transition_to_primary_storage_class EfsFileSystem#transition_to_primary_storage_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitionToPrimaryStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransitionToPrimaryStorageClass
        {
            get;
            set;
        }
    }
}
