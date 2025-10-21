using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    [JsiiInterface(nativeType: typeof(IInspector2FilterFilterCriteriaLambdaFunctionRuntime), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionRuntime")]
    public interface IInspector2FilterFilterCriteriaLambdaFunctionRuntime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#comparison Inspector2Filter#comparison}.</summary>
        [JsiiProperty(name: "comparison", typeJson: "{\"primitive\":\"string\"}")]
        string Comparison
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#value Inspector2Filter#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IInspector2FilterFilterCriteriaLambdaFunctionRuntime), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionRuntime")]
        internal sealed class _Proxy : DeputyBase, aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionRuntime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#comparison Inspector2Filter#comparison}.</summary>
            [JsiiProperty(name: "comparison", typeJson: "{\"primitive\":\"string\"}")]
            public string Comparison
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#value Inspector2Filter#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
