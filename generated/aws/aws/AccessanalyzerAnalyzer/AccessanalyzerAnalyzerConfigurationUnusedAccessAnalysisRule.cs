using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerAnalyzer
{
    [JsiiByValue(fqn: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRule")]
    public class AccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRule : aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRule
    {
        private object? _exclusion;

        /// <summary>exclusion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#exclusion AccessanalyzerAnalyzer#exclusion}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclusion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRuleExclusion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Exclusion
        {
            get => _exclusion;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRuleExclusion[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccessAnalysisRuleExclusion).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exclusion = value;
            }
        }
    }
}
