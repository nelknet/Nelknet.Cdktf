using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineTriggerGitConfiguration")]
    public class CodepipelineTriggerGitConfiguration : aws.Codepipeline.ICodepipelineTriggerGitConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#source_action_name Codepipeline#source_action_name}.</summary>
        [JsiiProperty(name: "sourceActionName", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceActionName
        {
            get;
            set;
        }

        private object? _pullRequest;

        /// <summary>pull_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#pull_request Codepipeline#pull_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pullRequest", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPullRequest\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PullRequest
        {
            get => _pullRequest;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequest[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPullRequest).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pullRequest = value;
            }
        }

        private object? _push;

        /// <summary>push block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline#push Codepipeline#push}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "push", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineTriggerGitConfigurationPush\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Push
        {
            get => _push;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Codepipeline.ICodepipelineTriggerGitConfigurationPush[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Codepipeline.ICodepipelineTriggerGitConfigurationPush).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _push = value;
            }
        }
    }
}
