using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerAnalyzer
{
    [JsiiInterface(nativeType: typeof(IAccessanalyzerAnalyzerConfigurationUnusedAccess), fullyQualifiedName: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccess")]
    public interface IAccessanalyzerAnalyzerConfigurationUnusedAccess
    {
        /// <summary>analysis_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#analysis_rule AccessanalyzerAnalyzer#analysis_rule}
        /// </remarks>
        [JsiiProperty(name: "analysisRule", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRule? AnalysisRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#unused_access_age AccessanalyzerAnalyzer#unused_access_age}.</summary>
        [JsiiProperty(name: "unusedAccessAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UnusedAccessAge
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessanalyzerAnalyzerConfigurationUnusedAccess), fullyQualifiedName: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccess")]
        internal sealed class _Proxy : DeputyBase, aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>analysis_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#analysis_rule AccessanalyzerAnalyzer#analysis_rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "analysisRule", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRule\"}", isOptional: true)]
            public aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRule? AnalysisRule
            {
                get => GetInstanceProperty<aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRule?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#unused_access_age AccessanalyzerAnalyzer#unused_access_age}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unusedAccessAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnusedAccessAge
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
