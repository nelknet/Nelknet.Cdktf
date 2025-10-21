using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerAnalyzer
{
    [JsiiClass(nativeType: typeof(aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationOutputReference), fullyQualifiedName: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AccessanalyzerAnalyzerConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AccessanalyzerAnalyzerConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AccessanalyzerAnalyzerConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AccessanalyzerAnalyzerConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putUnusedAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccess\"}}]")]
        public virtual void PutUnusedAccess(aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetUnusedAccess")]
        public virtual void ResetUnusedAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "unusedAccess", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccessOutputReference\"}")]
        public virtual aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccessOutputReference UnusedAccess
        {
            get => GetInstanceProperty<aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccessOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "unusedAccessInput", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccess\"}", isOptional: true)]
        public virtual aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccess? UnusedAccessInput
        {
            get => GetInstanceProperty<aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfiguration\"}", isOptional: true)]
        public virtual aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
