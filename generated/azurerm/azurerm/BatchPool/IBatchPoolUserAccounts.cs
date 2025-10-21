using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolUserAccounts), fullyQualifiedName: "azurerm.batchPool.BatchPoolUserAccounts")]
    public interface IBatchPoolUserAccounts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#elevation_level BatchPool#elevation_level}.</summary>
        [JsiiProperty(name: "elevationLevel", typeJson: "{\"primitive\":\"string\"}")]
        string ElevationLevel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#name BatchPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#password BatchPool#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>linux_user_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#linux_user_configuration BatchPool#linux_user_configuration}
        /// </remarks>
        [JsiiProperty(name: "linuxUserConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolUserAccountsLinuxUserConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LinuxUserConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>windows_user_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#windows_user_configuration BatchPool#windows_user_configuration}
        /// </remarks>
        [JsiiProperty(name: "windowsUserConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolUserAccountsWindowsUserConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WindowsUserConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolUserAccounts), fullyQualifiedName: "azurerm.batchPool.BatchPoolUserAccounts")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolUserAccounts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#elevation_level BatchPool#elevation_level}.</summary>
            [JsiiProperty(name: "elevationLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string ElevationLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#name BatchPool#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#password BatchPool#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>linux_user_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#linux_user_configuration BatchPool#linux_user_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linuxUserConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolUserAccountsLinuxUserConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LinuxUserConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>windows_user_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#windows_user_configuration BatchPool#windows_user_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "windowsUserConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolUserAccountsWindowsUserConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WindowsUserConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
