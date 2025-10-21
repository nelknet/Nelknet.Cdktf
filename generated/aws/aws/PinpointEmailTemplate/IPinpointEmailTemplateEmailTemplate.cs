using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PinpointEmailTemplate
{
    [JsiiInterface(nativeType: typeof(IPinpointEmailTemplateEmailTemplate), fullyQualifiedName: "aws.pinpointEmailTemplate.PinpointEmailTemplateEmailTemplate")]
    public interface IPinpointEmailTemplateEmailTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#default_substitutions PinpointEmailTemplate#default_substitutions}.</summary>
        [JsiiProperty(name: "defaultSubstitutions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultSubstitutions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#description PinpointEmailTemplate#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#header PinpointEmailTemplate#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pinpointEmailTemplate.PinpointEmailTemplateEmailTemplateHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#html_part PinpointEmailTemplate#html_part}.</summary>
        [JsiiProperty(name: "htmlPart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HtmlPart
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#recommender_id PinpointEmailTemplate#recommender_id}.</summary>
        [JsiiProperty(name: "recommenderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecommenderId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#subject PinpointEmailTemplate#subject}.</summary>
        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Subject
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#text_part PinpointEmailTemplate#text_part}.</summary>
        [JsiiProperty(name: "textPart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TextPart
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPinpointEmailTemplateEmailTemplate), fullyQualifiedName: "aws.pinpointEmailTemplate.PinpointEmailTemplateEmailTemplate")]
        internal sealed class _Proxy : DeputyBase, aws.PinpointEmailTemplate.IPinpointEmailTemplateEmailTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#default_substitutions PinpointEmailTemplate#default_substitutions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultSubstitutions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultSubstitutions
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#description PinpointEmailTemplate#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#header PinpointEmailTemplate#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pinpointEmailTemplate.PinpointEmailTemplateEmailTemplateHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Header
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#html_part PinpointEmailTemplate#html_part}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "htmlPart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HtmlPart
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#recommender_id PinpointEmailTemplate#recommender_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recommenderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecommenderId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#subject PinpointEmailTemplate#subject}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Subject
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_template#text_part PinpointEmailTemplate#text_part}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "textPart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TextPart
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
