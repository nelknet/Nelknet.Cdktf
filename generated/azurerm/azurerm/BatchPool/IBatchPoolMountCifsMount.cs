using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolMountCifsMount), fullyQualifiedName: "azurerm.batchPool.BatchPoolMountCifsMount")]
    public interface IBatchPoolMountCifsMount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#password BatchPool#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#relative_mount_path BatchPool#relative_mount_path}.</summary>
        [JsiiProperty(name: "relativeMountPath", typeJson: "{\"primitive\":\"string\"}")]
        string RelativeMountPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#source BatchPool#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#user_name BatchPool#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#mount_options BatchPool#mount_options}.</summary>
        [JsiiProperty(name: "mountOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MountOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolMountCifsMount), fullyQualifiedName: "azurerm.batchPool.BatchPoolMountCifsMount")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolMountCifsMount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#password BatchPool#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#relative_mount_path BatchPool#relative_mount_path}.</summary>
            [JsiiProperty(name: "relativeMountPath", typeJson: "{\"primitive\":\"string\"}")]
            public string RelativeMountPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#source BatchPool#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#user_name BatchPool#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#mount_options BatchPool#mount_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mountOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountOptions
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
