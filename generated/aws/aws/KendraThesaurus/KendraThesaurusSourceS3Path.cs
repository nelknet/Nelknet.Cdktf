using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraThesaurus
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraThesaurus.KendraThesaurusSourceS3Path")]
    public class KendraThesaurusSourceS3Path : aws.KendraThesaurus.IKendraThesaurusSourceS3Path
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_thesaurus#bucket KendraThesaurus#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_thesaurus#key KendraThesaurus#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }
    }
}
