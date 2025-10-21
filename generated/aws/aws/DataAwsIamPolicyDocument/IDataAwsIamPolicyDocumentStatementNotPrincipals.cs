using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIamPolicyDocument
{
    [JsiiInterface(nativeType: typeof(IDataAwsIamPolicyDocumentStatementNotPrincipals), fullyQualifiedName: "aws.dataAwsIamPolicyDocument.DataAwsIamPolicyDocumentStatementNotPrincipals")]
    public interface IDataAwsIamPolicyDocumentStatementNotPrincipals
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#identifiers DataAwsIamPolicyDocument#identifiers}.</summary>
        [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Identifiers
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#type DataAwsIamPolicyDocument#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIamPolicyDocumentStatementNotPrincipals), fullyQualifiedName: "aws.dataAwsIamPolicyDocument.DataAwsIamPolicyDocumentStatementNotPrincipals")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsIamPolicyDocument.IDataAwsIamPolicyDocumentStatementNotPrincipals
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#identifiers DataAwsIamPolicyDocument#identifiers}.</summary>
            [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Identifiers
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#type DataAwsIamPolicyDocument#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
