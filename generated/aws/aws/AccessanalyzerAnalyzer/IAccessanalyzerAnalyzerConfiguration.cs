using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerAnalyzer
{
    [JsiiInterface(nativeType: typeof(IAccessanalyzerAnalyzerConfiguration), fullyQualifiedName: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfiguration")]
    public interface IAccessanalyzerAnalyzerConfiguration
    {
        /// <summary>unused_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#unused_access AccessanalyzerAnalyzer#unused_access}
        /// </remarks>
        [JsiiProperty(name: "unusedAccess", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccess? UnusedAccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessanalyzerAnalyzerConfiguration), fullyQualifiedName: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>unused_access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#unused_access AccessanalyzerAnalyzer#unused_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unusedAccess", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccess\"}", isOptional: true)]
            public aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccess? UnusedAccess
            {
                get => GetInstanceProperty<aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccess?>();
            }
        }
    }
}
