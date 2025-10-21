using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolStartTaskUserIdentity), fullyQualifiedName: "azurerm.batchPool.BatchPoolStartTaskUserIdentity")]
    public interface IBatchPoolStartTaskUserIdentity
    {
        /// <summary>auto_user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#auto_user BatchPool#auto_user}
        /// </remarks>
        [JsiiProperty(name: "autoUser", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskUserIdentityAutoUser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.BatchPool.IBatchPoolStartTaskUserIdentityAutoUser? AutoUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#user_name BatchPool#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolStartTaskUserIdentity), fullyQualifiedName: "azurerm.batchPool.BatchPoolStartTaskUserIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolStartTaskUserIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>auto_user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#auto_user BatchPool#auto_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoUser", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskUserIdentityAutoUser\"}", isOptional: true)]
            public azurerm.BatchPool.IBatchPoolStartTaskUserIdentityAutoUser? AutoUser
            {
                get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolStartTaskUserIdentityAutoUser?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#user_name BatchPool#user_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
