using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerAssessment
{
    [JsiiInterface(nativeType: typeof(IAuditmanagerAssessmentScopeAwsAccounts), fullyQualifiedName: "aws.auditmanagerAssessment.AuditmanagerAssessmentScopeAwsAccounts")]
    public interface IAuditmanagerAssessmentScopeAwsAccounts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#id AuditmanagerAssessment#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAuditmanagerAssessmentScopeAwsAccounts), fullyQualifiedName: "aws.auditmanagerAssessment.AuditmanagerAssessmentScopeAwsAccounts")]
        internal sealed class _Proxy : DeputyBase, aws.AuditmanagerAssessment.IAuditmanagerAssessmentScopeAwsAccounts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#id AuditmanagerAssessment#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
