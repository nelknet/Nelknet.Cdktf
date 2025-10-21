using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DlmLifecyclePolicy
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsEventSourceParameters), fullyQualifiedName: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsEventSourceParameters")]
    public interface IDlmLifecyclePolicyPolicyDetailsEventSourceParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#description_regex DlmLifecyclePolicy#description_regex}.</summary>
        [JsiiProperty(name: "descriptionRegex", typeJson: "{\"primitive\":\"string\"}")]
        string DescriptionRegex
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#event_type DlmLifecyclePolicy#event_type}.</summary>
        [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}")]
        string EventType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#snapshot_owner DlmLifecyclePolicy#snapshot_owner}.</summary>
        [JsiiProperty(name: "snapshotOwner", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SnapshotOwner
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsEventSourceParameters), fullyQualifiedName: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsEventSourceParameters")]
        internal sealed class _Proxy : DeputyBase, aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsEventSourceParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#description_regex DlmLifecyclePolicy#description_regex}.</summary>
            [JsiiProperty(name: "descriptionRegex", typeJson: "{\"primitive\":\"string\"}")]
            public string DescriptionRegex
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#event_type DlmLifecyclePolicy#event_type}.</summary>
            [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}")]
            public string EventType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#snapshot_owner DlmLifecyclePolicy#snapshot_owner}.</summary>
            [JsiiProperty(name: "snapshotOwner", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SnapshotOwner
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
