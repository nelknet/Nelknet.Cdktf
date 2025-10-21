using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolAutoScale), fullyQualifiedName: "azurerm.batchPool.BatchPoolAutoScale")]
    public interface IBatchPoolAutoScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#formula BatchPool#formula}.</summary>
        [JsiiProperty(name: "formula", typeJson: "{\"primitive\":\"string\"}")]
        string Formula
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#evaluation_interval BatchPool#evaluation_interval}.</summary>
        [JsiiProperty(name: "evaluationInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EvaluationInterval
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolAutoScale), fullyQualifiedName: "azurerm.batchPool.BatchPoolAutoScale")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolAutoScale
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#formula BatchPool#formula}.</summary>
            [JsiiProperty(name: "formula", typeJson: "{\"primitive\":\"string\"}")]
            public string Formula
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#evaluation_interval BatchPool#evaluation_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "evaluationInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EvaluationInterval
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
