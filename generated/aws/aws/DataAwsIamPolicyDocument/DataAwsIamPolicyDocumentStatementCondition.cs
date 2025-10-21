using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIamPolicyDocument
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsIamPolicyDocument.DataAwsIamPolicyDocumentStatementCondition")]
    public class DataAwsIamPolicyDocumentStatementCondition : aws.DataAwsIamPolicyDocument.IDataAwsIamPolicyDocumentStatementCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#test DataAwsIamPolicyDocument#test}.</summary>
        [JsiiProperty(name: "test", typeJson: "{\"primitive\":\"string\"}")]
        public string Test
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#values DataAwsIamPolicyDocument#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#variable DataAwsIamPolicyDocument#variable}.</summary>
        [JsiiProperty(name: "variable", typeJson: "{\"primitive\":\"string\"}")]
        public string Variable
        {
            get;
            set;
        }
    }
}
