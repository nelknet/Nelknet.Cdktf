using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseSparkPool
{
    [JsiiInterface(nativeType: typeof(ISynapseSparkPoolLibraryRequirement), fullyQualifiedName: "azurerm.synapseSparkPool.SynapseSparkPoolLibraryRequirement")]
    public interface ISynapseSparkPoolLibraryRequirement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#content SynapseSparkPool#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#filename SynapseSparkPool#filename}.</summary>
        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}")]
        string Filename
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISynapseSparkPoolLibraryRequirement), fullyQualifiedName: "azurerm.synapseSparkPool.SynapseSparkPoolLibraryRequirement")]
        internal sealed class _Proxy : DeputyBase, azurerm.SynapseSparkPool.ISynapseSparkPoolLibraryRequirement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#content SynapseSparkPool#content}.</summary>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#filename SynapseSparkPool#filename}.</summary>
            [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}")]
            public string Filename
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
