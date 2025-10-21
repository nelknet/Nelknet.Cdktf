using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataexchangeEventAction
{
    [JsiiByValue(fqn: "aws.dataexchangeEventAction.DataexchangeEventActionEvent")]
    public class DataexchangeEventActionEvent : aws.DataexchangeEventAction.IDataexchangeEventActionEvent
    {
        private object? _revisionPublished;

        /// <summary>revision_published block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_event_action#revision_published DataexchangeEventAction#revision_published}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revisionPublished", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataexchangeEventAction.DataexchangeEventActionEventRevisionPublished\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RevisionPublished
        {
            get => _revisionPublished;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataexchangeEventAction.IDataexchangeEventActionEventRevisionPublished[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataexchangeEventAction.IDataexchangeEventActionEventRevisionPublished).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _revisionPublished = value;
            }
        }
    }
}
