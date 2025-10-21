using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseSparkPool
{
    [JsiiInterface(nativeType: typeof(ISynapseSparkPoolAutoPause), fullyQualifiedName: "azurerm.synapseSparkPool.SynapseSparkPoolAutoPause")]
    public interface ISynapseSparkPoolAutoPause
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#delay_in_minutes SynapseSparkPool#delay_in_minutes}.</summary>
        [JsiiProperty(name: "delayInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        double DelayInMinutes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISynapseSparkPoolAutoPause), fullyQualifiedName: "azurerm.synapseSparkPool.SynapseSparkPoolAutoPause")]
        internal sealed class _Proxy : DeputyBase, azurerm.SynapseSparkPool.ISynapseSparkPoolAutoPause
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#delay_in_minutes SynapseSparkPool#delay_in_minutes}.</summary>
            [JsiiProperty(name: "delayInMinutes", typeJson: "{\"primitive\":\"number\"}")]
            public double DelayInMinutes
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
