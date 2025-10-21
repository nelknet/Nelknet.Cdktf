using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerGroup.ContainerGroupInitContainerVolume")]
    public class ContainerGroupInitContainerVolume : azurerm.ContainerGroup.IContainerGroupInitContainerVolume
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#mount_path ContainerGroup#mount_path}.</summary>
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}")]
        public string MountPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#name ContainerGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _emptyDir;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#empty_dir ContainerGroup#empty_dir}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emptyDir", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EmptyDir
        {
            get => _emptyDir;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _emptyDir = value;
            }
        }

        /// <summary>git_repo block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#git_repo ContainerGroup#git_repo}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitRepo", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupInitContainerVolumeGitRepo\"}", isOptional: true)]
        public azurerm.ContainerGroup.IContainerGroupInitContainerVolumeGitRepo? GitRepo
        {
            get;
            set;
        }

        private object? _readOnly;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#read_only ContainerGroup#read_only}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ReadOnly
        {
            get => _readOnly;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _readOnly = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#secret ContainerGroup#secret}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Secret
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#share_name ContainerGroup#share_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shareName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShareName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#storage_account_key ContainerGroup#storage_account_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#storage_account_name ContainerGroup#storage_account_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountName
        {
            get;
            set;
        }
    }
}
