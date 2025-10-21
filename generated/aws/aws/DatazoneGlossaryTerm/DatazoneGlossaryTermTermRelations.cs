using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazoneGlossaryTerm
{
    [JsiiByValue(fqn: "aws.datazoneGlossaryTerm.DatazoneGlossaryTermTermRelations")]
    public class DatazoneGlossaryTermTermRelations : aws.DatazoneGlossaryTerm.IDatazoneGlossaryTermTermRelations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#classifies DatazoneGlossaryTerm#classifies}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "classifies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Classifies
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#is_a DatazoneGlossaryTerm#is_a}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isA", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IsA
        {
            get;
            set;
        }
    }
}
