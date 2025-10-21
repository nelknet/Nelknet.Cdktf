using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerAnalyzer
{
    [JsiiByValue(fqn: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccess")]
    public class AccessanalyzerAnalyzerConfigurationUnusedAccess : aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccess
    {
        /// <summary>analysis_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#analysis_rule AccessanalyzerAnalyzer#analysis_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "analysisRule", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRule\"}", isOptional: true)]
        public aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRule? AnalysisRule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#unused_access_age AccessanalyzerAnalyzer#unused_access_age}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unusedAccessAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnusedAccessAge
        {
            get;
            set;
        }
    }
}
