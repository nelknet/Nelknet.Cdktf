using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueClassifier
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierConfig), fullyQualifiedName: "aws.glueClassifier.GlueClassifierConfig")]
    public interface IGlueClassifierConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#name GlueClassifier#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>csv_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#csv_classifier GlueClassifier#csv_classifier}
        /// </remarks>
        [JsiiProperty(name: "csvClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierCsvClassifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueClassifier.IGlueClassifierCsvClassifier? CsvClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>grok_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#grok_classifier GlueClassifier#grok_classifier}
        /// </remarks>
        [JsiiProperty(name: "grokClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierGrokClassifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueClassifier.IGlueClassifierGrokClassifier? GrokClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#id GlueClassifier#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>json_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#json_classifier GlueClassifier#json_classifier}
        /// </remarks>
        [JsiiProperty(name: "jsonClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierJsonClassifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueClassifier.IGlueClassifierJsonClassifier? JsonClassifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>xml_classifier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#xml_classifier GlueClassifier#xml_classifier}
        /// </remarks>
        [JsiiProperty(name: "xmlClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierXmlClassifier\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueClassifier.IGlueClassifierXmlClassifier? XmlClassifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierConfig), fullyQualifiedName: "aws.glueClassifier.GlueClassifierConfig")]
        internal sealed class _Proxy : DeputyBase, aws.GlueClassifier.IGlueClassifierConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#name GlueClassifier#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>csv_classifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#csv_classifier GlueClassifier#csv_classifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "csvClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierCsvClassifier\"}", isOptional: true)]
            public aws.GlueClassifier.IGlueClassifierCsvClassifier? CsvClassifier
            {
                get => GetInstanceProperty<aws.GlueClassifier.IGlueClassifierCsvClassifier?>();
            }

            /// <summary>grok_classifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#grok_classifier GlueClassifier#grok_classifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grokClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierGrokClassifier\"}", isOptional: true)]
            public aws.GlueClassifier.IGlueClassifierGrokClassifier? GrokClassifier
            {
                get => GetInstanceProperty<aws.GlueClassifier.IGlueClassifierGrokClassifier?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#id GlueClassifier#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>json_classifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#json_classifier GlueClassifier#json_classifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jsonClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierJsonClassifier\"}", isOptional: true)]
            public aws.GlueClassifier.IGlueClassifierJsonClassifier? JsonClassifier
            {
                get => GetInstanceProperty<aws.GlueClassifier.IGlueClassifierJsonClassifier?>();
            }

            /// <summary>xml_classifier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#xml_classifier GlueClassifier#xml_classifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xmlClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierXmlClassifier\"}", isOptional: true)]
            public aws.GlueClassifier.IGlueClassifierXmlClassifier? XmlClassifier
            {
                get => GetInstanceProperty<aws.GlueClassifier.IGlueClassifierXmlClassifier?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
