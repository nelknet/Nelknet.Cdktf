using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueClassifier
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierXmlClassifier), fullyQualifiedName: "aws.glueClassifier.GlueClassifierXmlClassifier")]
    public interface IGlueClassifierXmlClassifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#classification GlueClassifier#classification}.</summary>
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
        string Classification
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#row_tag GlueClassifier#row_tag}.</summary>
        [JsiiProperty(name: "rowTag", typeJson: "{\"primitive\":\"string\"}")]
        string RowTag
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierXmlClassifier), fullyQualifiedName: "aws.glueClassifier.GlueClassifierXmlClassifier")]
        internal sealed class _Proxy : DeputyBase, aws.GlueClassifier.IGlueClassifierXmlClassifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#classification GlueClassifier#classification}.</summary>
            [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
            public string Classification
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#row_tag GlueClassifier#row_tag}.</summary>
            [JsiiProperty(name: "rowTag", typeJson: "{\"primitive\":\"string\"}")]
            public string RowTag
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
