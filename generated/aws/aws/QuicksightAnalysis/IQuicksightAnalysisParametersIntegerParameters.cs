using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightAnalysis
{
    [JsiiInterface(nativeType: typeof(IQuicksightAnalysisParametersIntegerParameters), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisParametersIntegerParameters")]
    public interface IQuicksightAnalysisParametersIntegerParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#name QuicksightAnalysis#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#values QuicksightAnalysis#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightAnalysisParametersIntegerParameters), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisParametersIntegerParameters")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightAnalysis.IQuicksightAnalysisParametersIntegerParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#name QuicksightAnalysis#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#values QuicksightAnalysis#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] Values
            {
                get => GetInstanceProperty<double[]>()!;
            }
        }
    }
}
