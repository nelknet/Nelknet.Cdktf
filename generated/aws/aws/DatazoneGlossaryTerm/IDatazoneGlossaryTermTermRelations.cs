using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazoneGlossaryTerm
{
    [JsiiInterface(nativeType: typeof(IDatazoneGlossaryTermTermRelations), fullyQualifiedName: "aws.datazoneGlossaryTerm.DatazoneGlossaryTermTermRelations")]
    public interface IDatazoneGlossaryTermTermRelations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#classifies DatazoneGlossaryTerm#classifies}.</summary>
        [JsiiProperty(name: "classifies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Classifies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#is_a DatazoneGlossaryTerm#is_a}.</summary>
        [JsiiProperty(name: "isA", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IsA
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazoneGlossaryTermTermRelations), fullyQualifiedName: "aws.datazoneGlossaryTerm.DatazoneGlossaryTermTermRelations")]
        internal sealed class _Proxy : DeputyBase, aws.DatazoneGlossaryTerm.IDatazoneGlossaryTermTermRelations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#classifies DatazoneGlossaryTerm#classifies}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "classifies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Classifies
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_glossary_term#is_a DatazoneGlossaryTerm#is_a}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isA", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IsA
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
