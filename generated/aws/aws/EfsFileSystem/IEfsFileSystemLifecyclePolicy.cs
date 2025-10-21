using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsFileSystem
{
    [JsiiInterface(nativeType: typeof(IEfsFileSystemLifecyclePolicy), fullyQualifiedName: "aws.efsFileSystem.EfsFileSystemLifecyclePolicy")]
    public interface IEfsFileSystemLifecyclePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#transition_to_archive EfsFileSystem#transition_to_archive}.</summary>
        [JsiiProperty(name: "transitionToArchive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransitionToArchive
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#transition_to_ia EfsFileSystem#transition_to_ia}.</summary>
        [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransitionToIa
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#transition_to_primary_storage_class EfsFileSystem#transition_to_primary_storage_class}.</summary>
        [JsiiProperty(name: "transitionToPrimaryStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransitionToPrimaryStorageClass
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsFileSystemLifecyclePolicy), fullyQualifiedName: "aws.efsFileSystem.EfsFileSystemLifecyclePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.EfsFileSystem.IEfsFileSystemLifecyclePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#transition_to_archive EfsFileSystem#transition_to_archive}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transitionToArchive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransitionToArchive
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#transition_to_ia EfsFileSystem#transition_to_ia}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransitionToIa
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#transition_to_primary_storage_class EfsFileSystem#transition_to_primary_storage_class}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transitionToPrimaryStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransitionToPrimaryStorageClass
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
