using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolUserAccountsLinuxUserConfiguration), fullyQualifiedName: "azurerm.batchPool.BatchPoolUserAccountsLinuxUserConfiguration")]
    public interface IBatchPoolUserAccountsLinuxUserConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#gid BatchPool#gid}.</summary>
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Gid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#ssh_private_key BatchPool#ssh_private_key}.</summary>
        [JsiiProperty(name: "sshPrivateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SshPrivateKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#uid BatchPool#uid}.</summary>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Uid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolUserAccountsLinuxUserConfiguration), fullyQualifiedName: "azurerm.batchPool.BatchPoolUserAccountsLinuxUserConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolUserAccountsLinuxUserConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#gid BatchPool#gid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Gid
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#ssh_private_key BatchPool#ssh_private_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sshPrivateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SshPrivateKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#uid BatchPool#uid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Uid
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
