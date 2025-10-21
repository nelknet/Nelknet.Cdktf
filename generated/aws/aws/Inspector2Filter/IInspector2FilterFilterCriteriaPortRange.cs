using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    [JsiiInterface(nativeType: typeof(IInspector2FilterFilterCriteriaPortRange), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteriaPortRange")]
    public interface IInspector2FilterFilterCriteriaPortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#begin_inclusive Inspector2Filter#begin_inclusive}.</summary>
        [JsiiProperty(name: "beginInclusive", typeJson: "{\"primitive\":\"number\"}")]
        double BeginInclusive
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#end_inclusive Inspector2Filter#end_inclusive}.</summary>
        [JsiiProperty(name: "endInclusive", typeJson: "{\"primitive\":\"number\"}")]
        double EndInclusive
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IInspector2FilterFilterCriteriaPortRange), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteriaPortRange")]
        internal sealed class _Proxy : DeputyBase, aws.Inspector2Filter.IInspector2FilterFilterCriteriaPortRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#begin_inclusive Inspector2Filter#begin_inclusive}.</summary>
            [JsiiProperty(name: "beginInclusive", typeJson: "{\"primitive\":\"number\"}")]
            public double BeginInclusive
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#end_inclusive Inspector2Filter#end_inclusive}.</summary>
            [JsiiProperty(name: "endInclusive", typeJson: "{\"primitive\":\"number\"}")]
            public double EndInclusive
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
