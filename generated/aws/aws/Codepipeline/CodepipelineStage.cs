using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineStage")]
    public class CodepipelineStage : aws.Codepipeline.ICodepipelineStage
    {
        private object _action;

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#action Codepipeline#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineStageAction\"},\"kind\":\"array\"}}]}}")]
        public object Action
        {
            get => _action;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Codepipeline.ICodepipelineStageAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Codepipeline.ICodepipelineStageAction).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Codepipeline.ICodepipelineStageAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _action = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#name Codepipeline#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>before_entry block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#before_entry Codepipeline#before_entry}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "beforeEntry", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageBeforeEntry\"}", isOptional: true)]
        public aws.Codepipeline.ICodepipelineStageBeforeEntry? BeforeEntry
        {
            get;
            set;
        }

        /// <summary>on_failure block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#on_failure Codepipeline#on_failure}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnFailure\"}", isOptional: true)]
        public aws.Codepipeline.ICodepipelineStageOnFailure? OnFailure
        {
            get;
            set;
        }

        /// <summary>on_success block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#on_success Codepipeline#on_success}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onSuccess", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineStageOnSuccess\"}", isOptional: true)]
        public aws.Codepipeline.ICodepipelineStageOnSuccess? OnSuccess
        {
            get;
            set;
        }
    }
}
