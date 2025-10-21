using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolStartTaskUserIdentityAutoUser), fullyQualifiedName: "azurerm.batchPool.BatchPoolStartTaskUserIdentityAutoUser")]
    public interface IBatchPoolStartTaskUserIdentityAutoUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#elevation_level BatchPool#elevation_level}.</summary>
        [JsiiProperty(name: "elevationLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ElevationLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#scope BatchPool#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scope
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolStartTaskUserIdentityAutoUser), fullyQualifiedName: "azurerm.batchPool.BatchPoolStartTaskUserIdentityAutoUser")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolStartTaskUserIdentityAutoUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#elevation_level BatchPool#elevation_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elevationLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ElevationLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#scope BatchPool#scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scope
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
